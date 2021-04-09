using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebServer.web
{
    /// <summary>
    /// aspx 动态文件web请求示例
    /// 请求地址为:   http://yourip:port/helloworld.aspx
    /// 如: http://127.0.0.1:88/helloworld.aspx
    /// </summary>
    class HelloWorld : IMyHttpHandler
    {
        public void ProcessRequest(MyHttpContext context)
        {
            string str = $"<!DOCTYPE html><html lang=en> <head><meta charset=UTF-8>" +
              $"<meta name=viewport content=\"width = device - width, initial - scale = 1.0\">" +
              $"<title>Hello World Aspx from C#</title></head> " +
              $"<body> <h1>Hello world! C# Aspx</h1>" +
              $"<h2>ReqTime: {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}</2> " +
              $"</body> </html>";
            context.Response.StateCode = "200";
            context.Response.StateDes = "OK";
            context.Response.ContentType = "text/html";
            context.Response.Body = Encoding.UTF8.GetBytes(str);
        }
    }
}
