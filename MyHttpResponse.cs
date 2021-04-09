using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebServer
{
    public class MyHttpResponse
    {
        public string StateCode { get; set; }
        public string StateDes { get; set; }
        public string ContentType { get; set; }
        public byte[] Body { get; set; }

        public byte[] GetResponseHeader()
        {
            string strRequestHeader = string.Format(@"HTTP/1.1 {0} {1}
access-control-allow-origin: *
content-type: {2}; charset=utf-8
Accept-Ranges:bytes
Content-Length:{3}
date: {4}
server: TekinWebServer/1.0


", StateCode, StateDes, ContentType, Body.Length, DateTime.Now.ToString());

            return Encoding.Default.GetBytes(strRequestHeader);
        }

    }
}
