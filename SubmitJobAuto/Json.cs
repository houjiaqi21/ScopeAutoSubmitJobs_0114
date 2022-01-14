using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SubmitJobAuto
{
    public class Json
    {
        /// <summary>
        /// 读取JSON文件
        /// </summary>
        /// <param name="key">JSON文件中的key值</param>
        /// <returns>JSON文件中的value值</returns>
        public static string Readjson(string key)
        {
            string jsonfile = @"..\..\..\SubmitJobAuto\Setting.json";//JSON文件路径

            using (System.IO.StreamReader file = System.IO.File.OpenText(jsonfile))
            {
                using (JsonTextReader reader = new JsonTextReader(file))
                {
                    JObject o = (JObject)JToken.ReadFrom(reader);
                    var value = o[key].ToString();
                    return value;
                }
            }
        }

        public static string Readjson(string key1, string key2)
        {
            string jsonfile = @"..\..\..\SubmitJobAuto\Setting.json";//JSON文件路径

            using (System.IO.StreamReader file = System.IO.File.OpenText(jsonfile))
            {
                using (JsonTextReader reader = new JsonTextReader(file))
                {
                    JObject o = (JObject)JToken.ReadFrom(reader);
                    var value = o[key1][key2].ToString();
                    return value;
                }
            }
        }
    }
}
