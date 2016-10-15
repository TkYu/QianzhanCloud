#if !NET40 && !NET20
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace Qianzhan
{
    public partial class QianzhanCloud
    {
        #region 内部方法
        private async Task RefreshTokenAsync()
        {
            _keyLock.EnterWriteLock();
            var url = $"{BaseURI}/GetToken?type=JSON&appkey={_appkey}&seckey={_seckey}";
            JObject result;
            using (var hc = new HttpClient())
            {
                hc.Timeout = TimeSpan.FromMilliseconds(Timeout);
                var data = await hc.GetByteArrayAsync(url);
                result = JsonConvert.DeserializeObject<JObject>(Encoding.UTF8.GetString(data));
            }
            if (result.HasValues && (int)result["status"] != 200)
                throw new Exception("API请求错误：" + result["message"]);
            _token = result["result"].Value<string>("token");
            _expTime = DateTime.UtcNow.AddMinutes(110);
            if (_saveTokenToFile)
                File.WriteAllText(_configPath, JsonConvert.SerializeObject(new Dictionary<string, string> { { "token", _token }, { "expTime", _expTime.ToString("yyyyMMddHHmmss") } }));
            _keyLock.ExitWriteLock();
        }
        private async Task<T> GetAsync<T>(string iName, string extParams = "")
        {
            using (var hc = new HttpClient())
            {
                hc.Timeout = TimeSpan.FromMilliseconds(Timeout);
                var url = $"{BaseURI}/{iName}?type=JSON&token={await GetTokenAsync()}&{extParams}";
                var data = await hc.GetByteArrayAsync(url);
                var value = Encoding.UTF8.GetString(data);
                var result = JsonConvert.DeserializeObject<JObject>(value);
                if (!result.HasValues) throw new Exception("返回值解析失败：" + value);
                if ((int)result["status"] == 200) return result["result"].ToObject<T>();
                if ((int)result["status"] != 101) throw new Exception("API请求错误：" + result["message"]);
                RefreshToken();
                return await GetAsync<T>(iName, extParams);
            }
        }
        private async Task<T> PostAsync<T>(string iName, IReadOnlyCollection<KeyValuePair<string, string>> kv)
        {
            using (var hc = new HttpClient())
            {
                hc.Timeout = TimeSpan.FromMilliseconds(Timeout);
                var lst = new Dictionary<string, string>
                {
                    {"token", await GetTokenAsync()},
                    {"type", "JSON"}
                };
                if (kv != null && kv.Count > 0)
                {
                    foreach (var keyValuePair in kv)
                        lst.Add(keyValuePair.Key, keyValuePair.Value);
                }
                var url = $"{BaseURI}/{iName}";
                var data = await hc.PostAsync(url, new StringContent(JsonConvert.SerializeObject(lst), Encoding.UTF8, "application/json"));
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
    }
}
#endif