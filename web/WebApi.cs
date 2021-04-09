using System;
using System.Text;

namespace MyWebServer.web
{
    /// <summary>
    /// aspx 动态文件web请求示例
    /// 请求地址为:   http://yourip:port/webapi.aspx
    /// </summary>
    public class WebApi : IMyHttpHandler
    {
        public void ProcessRequest(MyHttpContext context)
        {
            string str = $"<!DOCTYPE html><html lang=en> <head><meta charset=UTF-8>" +
             $"<meta name=viewport content=\"width = device - width, initial - scale = 1.0\">" +
             $"<title> C# webapi</title></head> " +
             $"<body> <h1>Weocome to C# webapi page!</h1>" +
             $"<h2>ReqTime: {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}</h2> " +
             $"<h3>CurrentDomain:{AppDomain.CurrentDomain.ToString()}</h3> " +
             $"</body> </html>";
            context.Response.StateCode = "200";
            context.Response.StateDes = "OK";
            context.Response.ContentType = "text/html";
            context.Response.Body = Encoding.UTF8.GetBytes(str);
        }
    }
}
