using System;
using System.Collections.Generic;
#if NET20 || NET40
using System.Net;
#else
using System.Linq;
using System.Net.Http;
#endif
using System.Text;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Qianzhan
{
    public partial class QianzhanCloud
    {
        #region 内部变量
        private readonly string _appkey;
        private readonly string _seckey;
        private readonly bool _saveTokenToFile;
        private const string BaseURI = "http://api.qianzhan.com/OpenPlatformService";

        private string _token;
        private readonly string _configPath;
        private DateTime _expTime;
#if NET20
        private readonly object _keyLock = new object();
#else
        private readonly System.Threading.ReaderWriterLockSlim _keyLock = new System.Threading.ReaderWriterLockSlim();
#endif
        #endregion

        #region 入口及属性
        /// <summary>
        /// 入口
        /// </summary>
        /// <param name="appkey">产品的appkey</param>
        /// <param name="seckey">私钥key</param>
        /// <param name="saveTokenToFile">是否将Token保存到Temp文件夹</param>
        public QianzhanCloud(string appkey, string seckey, bool saveTokenToFile = false)
        {
            _appkey = appkey;
            _seckey = seckey;
            _saveTokenToFile = saveTokenToFile;
            _configPath = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "QZKeys.json");
        }

        /// <summary>
        /// 请求的超时时间，如果请求超出时间会抛出错误
        /// </summary>
        public int Timeout { get; set; } = 10000;
        #endregion

        #region 内部方法

        private void LoadKeyFromFile()
        {
            if (!File.Exists(_configPath))
                return;
#if NET20
            lock(_keyLock)
            {
#else
                _keyLock.EnterReadLock();
#endif
            try
            {
                var values = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText(_configPath));
                _expTime = DateTime.ParseExact(values["expTime"], "yyyyMMddHHmmss", null, System.Globalization.DateTimeStyles.None);
                _token = values["token"];
            }
            catch
            {
                //TODO
            }
#if NET20
            }
#else
            _keyLock.ExitReadLock();
#endif
        }

        private void RefreshToken()
        {
#if NET20
            lock(_keyLock)
            {
#else
            _keyLock.EnterWriteLock();
#endif
            var url = $"{BaseURI}/GetToken?type=JSON&appkey={_appkey}&seckey={_seckey}";
            JObject result;
#if NET20 || NET40
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Method = "GET";
            httpWebRequest.Timeout = Timeout;
            using (var httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
            {
                var rs = httpWebResponse.GetResponseStream();
                if (rs == null) throw new Exception("服务器没有返回任何内容");
                using (var streamReader = new StreamReader(rs))
                {
                    var content = streamReader.ReadToEnd();
                    result = JsonConvert.DeserializeObject<JObject>(content);
                }
            }
#else
            using (var hc = new HttpClient())
            {
                hc.Timeout = TimeSpan.FromMilliseconds(Timeout);
                var t = hc.GetByteArrayAsync(url);
                t.Wait(Timeout);
                if (!t.IsCompleted)
                    throw new TimeoutException("请求超时");
                var data = t.Result;
                result = JsonConvert.DeserializeObject<JObject>(Encoding.UTF8.GetString(data));
            }
#endif
            if (result.HasValues && (int)result["status"] != 200)
                throw new Exception("API请求错误：" + result["message"]);
            _token = result["result"].Value<string>("token");
            _expTime = DateTime.UtcNow.AddMinutes(110);
            if (_saveTokenToFile)
                File.WriteAllText(_configPath, JsonConvert.SerializeObject(new Dictionary<string, string> { { "token", _token }, { "expTime", _expTime.ToString("yyyyMMddHHmmss") } }));
#if NET20
            }
#else
            _keyLock.ExitWriteLock();
#endif
        }

        private T Get<T>(string iName, string extParams = "")
        {
            while (true)
            {
                var url = $"{BaseURI}/{iName}?type=JSON&token={GetToken()}&{extParams}";
                string value;
#if NET20 || NET40
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                httpWebRequest.Method = "GET";
                httpWebRequest.Timeout = Timeout;
                using (var httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
                {
                    var rs = httpWebResponse.GetResponseStream();
                    if (rs == null) throw new Exception("服务器没有返回任何内容");
                    using (var streamReader = new StreamReader(rs))
                    {
                        value = streamReader.ReadToEnd();
                    }
                }
#else
                using (var hc = new HttpClient())
                {
                    hc.Timeout = TimeSpan.FromMilliseconds(Timeout);
                    var t = hc.GetByteArrayAsync(url);
                    t.Wait(Timeout);
                    if (!t.IsCompleted)
                        throw new TimeoutException("请求超时");
                    var data = t.Result;
                    value = Encoding.UTF8.GetString(data);
                }
#endif
                var result = JsonConvert.DeserializeObject<JObject>(value);
                if (!result.HasValues) throw new Exception("返回值解析失败：" + value);
                if ((int)result["status"] == 200) return result["result"].ToObject<T>();
                if ((int)result["status"] != 101) throw new Exception("API请求错误：" + result["message"]);
                RefreshToken();
            }
        }

        private T Post<T>(string iName, KeyValuePair<string, string>[] kv)
        {
            while (true)
            {
                var lst = new Dictionary<string, string>
                {
                    {"token", GetToken()}, {"type", "JSON"}
                };
                if (kv != null && kv.Length > 0)
                {
                    foreach (var keyValuePair in kv)
                        lst.Add(keyValuePair.Key, keyValuePair.Value);
                }
                var url = $"{BaseURI}/{iName}";
                var requestBody = JsonConvert.SerializeObject(lst);
                string value;
#if NET20 || NET40
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";
                httpWebRequest.Timeout = Timeout;
                var btBodys = Encoding.UTF8.GetBytes(requestBody);
                httpWebRequest.ContentLength = btBodys.Length;
                httpWebRequest.GetRequestStream().Write(btBodys, 0, btBodys.Length);
                using (var httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
                {
                    var rs = httpWebResponse.GetResponseStream();
                    if (rs == null) throw new Exception("服务器没有返回任何内容");
                    using (var streamReader = new StreamReader(rs))
                    {
                        value = streamReader.ReadToEnd();
                    }
                }
#else
                using (var hc = new HttpClient())
                {
                    var t1 = hc.PostAsync(url, new StringContent(requestBody, Encoding.UTF8, "application/json"));
                    t1.Wait(Timeout);
                    if (!t1.IsCompleted)
                        throw new TimeoutException("请求超时");
                    var data = t1.Result;
                    var t2 = data.Content.ReadAsByteArrayAsync();
                    t2.Wait(Timeout);
                    if (!t2.IsCompleted)
                        throw new TimeoutException("请求超时");
                    value = Encoding.UTF8.GetString(t2.Result);
                }
#endif
                var result = JsonConvert.DeserializeObject<JObject>(value);
                if (!result.HasValues) throw new Exception("返回值解析失败：" + value);
                if ((int)result["status"] == 200) return result["result"].ToObject<T>();
                if ((int)result["status"] != 101) throw new Exception("API请求错误：" + result["message"]);
                RefreshToken();
            }
        }

#endregion
    }
}
