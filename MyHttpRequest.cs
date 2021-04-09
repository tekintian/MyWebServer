using System.Collections.Generic;
using System.Linq;

namespace MyWebServer
{
    public class MyHttpRequest
    {
        public MyHttpRequest(string requestStr)
        {
            //根据回车换行切分字符 先将 \r\n字符替换为 \r 字符 然后在使用 split进行分割
            var lines = requestStr.Replace("\r\n", "\r").Split('\r');
            string[] arr1 = lines[0].Split(' ');
            if (arr1.Count() > 1)
            {
                HttpMethod = arr1[0];
                Url = arr1[1];
                HttpVersion = arr1[2];

                for (int i = 1; i < lines.Length - 2; i++)
                {
                    string k, v;
                    k = lines[i].Split(':')[0];
                    v = lines[i].Split(':')[1];
                    HeaderDictionary.Add(k, v);
                }
            }
            //body处理
            BodyDictionary.Add("body", lines.Last().ToString());

        }
        public string HttpMethod { get; set; }
        public string Url { get; set; }
        public string HttpVersion { get; set; }
        public Dictionary<string, string> HeaderDictionary = new Dictionary<string, string>();
        public Dictionary<string, string> BodyDictionary = new Dictionary<string, string>();

    }
}
