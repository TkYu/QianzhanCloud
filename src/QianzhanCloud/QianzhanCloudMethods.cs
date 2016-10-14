using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
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
        #endregion

        #region 内部方法
        private async Task<JObject> GetToken()
        {
            using (var hc = new HttpClient())
            {
                var po = $"{BaseURI}/GetToken?type=JSON&appkey={_appkey}&seckey={_seckey}";
                var data = await hc.GetByteArrayAsync(po);
                var result = JsonConvert.DeserializeObject<JObject>(Encoding.UTF8.GetString(data));
                if (result.HasValues && (int)result["status"] != 200)
                    throw new Exception("API请求错误：" + result["message"]);
                return result;
            }
        }
        private T Get<T>(string iName, string extParams = "")
        {
            //return GetAsync<T>(iName, extParams).Result;
            using (var hc = new HttpClient())
            {
                var po = $"{BaseURI}/{iName}?type=JSON&token={Token}&{extParams}";
                var data = hc.GetByteArrayAsync(po).Result;
                var value = Encoding.UTF8.GetString(data);
                var result = JsonConvert.DeserializeObject<JObject>(value);
                if (!result.HasValues) throw new Exception("返回值解析失败：" + value);
                if ((int) result["status"] == 200) return result["result"].ToObject<T>();
                if ((int) result["status"] != 101) throw new Exception("API请求错误：" + result["message"]);
                RefreshToken();
                return Get<T>(iName, extParams);
            }
        }

        private async Task<T> GetAsync<T>(string iName, string extParams = "")
        {
            using (var hc = new HttpClient())
            {
                var po = $"{BaseURI}/{iName}?type=JSON&token={Token}&{extParams}";
                var data = await hc.GetByteArrayAsync(po);
                var value = Encoding.UTF8.GetString(data);
                var result = JsonConvert.DeserializeObject<JObject>(value);
                if (!result.HasValues) throw new Exception("返回值解析失败：" + value);
                if ((int)result["status"] == 200) return result["result"].ToObject<T>();
                if ((int)result["status"] != 101) throw new Exception("API请求错误：" + result["message"]);
                RefreshToken();
                return await GetAsync<T>(iName, extParams);
            }
        }

        private T Post<T>(string iName, KeyValuePair<string, string>[] kv)
        {
            //return PostAsync<T>(iName, kv).Result;
            using (var hc = new HttpClient())
            {
                var lst = new Dictionary<string, string>
                {
                    {"token", Token},
                    {"type", "JSON"}
                };
                if (kv != null && kv.Any())
                {
                    foreach (var keyValuePair in kv)
                        lst.Add(keyValuePair.Key, keyValuePair.Value);
                }
                var po = $"{BaseURI}/{iName}";
                var data = hc.PostAsync(po, new StringContent(JsonConvert.SerializeObject(lst), Encoding.UTF8, "application/json")).Result;
                var value = Encoding.UTF8.GetString(data.Content.ReadAsByteArrayAsync().Result);
                var result = JsonConvert.DeserializeObject<JObject>(value);
                if (!result.HasValues) throw new Exception("返回值解析失败：" + value);
                if ((int)result["status"] == 200) return result["result"].ToObject<T>();
                if ((int)result["status"] != 101) throw new Exception("API请求错误：" + result["message"]);
                RefreshToken();
                return Post<T>(iName, kv);
            }
        }

        private async Task<T> PostAsync<T>(string iName, KeyValuePair<string, string>[] kv)
        {
            using (var hc = new HttpClient())
            {
                var lst = new Dictionary<string, string>
                {
                    {"token", Token},
                    {"type", "JSON"}
                };
                if (kv != null && kv.Any())
                {
                    foreach (var keyValuePair in kv)
                        lst.Add(keyValuePair.Key, keyValuePair.Value);
                }
                var po = $"{BaseURI}/{iName}";
                var data = await hc.PostAsync(po, new StringContent(JsonConvert.SerializeObject(lst), Encoding.UTF8, "application/json"));
                var value = Encoding.UTF8.GetString(await data.Content.ReadAsByteArrayAsync());
                var result = JsonConvert.DeserializeObject<JObject>(value);
                if (!result.HasValues) throw new Exception("返回值解析失败：" + value);
                if ((int)result["status"] == 200) return result["result"].ToObject<T>();
                if ((int)result["status"] != 101) throw new Exception("API请求错误：" + result["message"]);
                RefreshToken();
                return await PostAsync<T>(iName, kv);
            }
        }
        #endregion

        #region 入口及令牌
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
            _configPath = Path.Combine(Path.GetTempPath(), "QZKeys.json");
        }

        /// <summary>
        /// 访问令牌
        /// </summary>
        public string Token
        {
            get
            {
                if (_saveTokenToFile && File.Exists(_configPath))
                {
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
                }
                if (_token == null || DateTime.UtcNow > _expTime)
                    RefreshToken();
                return _token;
            }
        }

        /// <summary>
        /// 强制刷新Token
        /// </summary>
        public void RefreshToken()
        {
            var r = GetToken().Result;
            _token = r["result"].Value<string>("token");
            _expTime = DateTime.UtcNow.AddSeconds(6600);
            if (_saveTokenToFile)
                File.WriteAllText(_configPath, JsonConvert.SerializeObject(new Dictionary<string, string> { { "token", _token }, { "expTime", _expTime.ToString("yyyyMMddHHmmss") } }));
        }
        #endregion
    }
}
