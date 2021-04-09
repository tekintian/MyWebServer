using System;
using System.IO;
using System.Reflection;
using System.Text;

namespace MyWebServer
{
    public class MyHttpApplication : IMyHttpHandler
    {
        public MyHttpApplication()
        {
        }

        public void ProcessRequest(MyHttpContext context)
        {
            //获得请求信息  context.Request
            //根据请求信息获取响应内容
            string baseWebPath = MyConfigUtil.Get("baseWebPath");

            string fileName = Path.Combine(baseWebPath, context.Request.Url.TrimStart('/'));

            //根据请求的URL判断请求文件的类型
            string contentType = MyMIMEDict.GetType(Path.GetExtension(context.Request.Url));

            string dfileName = fileName;
            #region 处理动态文件
            string ext = Path.GetExtension(context.Request.Url);
            if (ext == ".aspx")
            {
                var className = Path.GetFileNameWithoutExtension(context.Request.Url);

                //应为所有的aspx的类都继承了IHttpHandler 所以这里可以将实例化的类型设置为接口类型来接收, 以便使用接口定义的方法
                IMyHttpHandler obj = Assembly.Load("MyWebServer").CreateInstance("MyWebServer.web." + className, true) as IMyHttpHandler;
                if (obj != null)
                {
                    obj.ProcessRequest(context);
                    return;//终止执行
                }

            }
            #endregion


            #region 处理静态文件
            if (Directory.Exists(fileName) && (File.Exists(Path.Combine(fileName, "index.html"))))
            {
                dfileName = Path.Combine(fileName, "index.html".TrimStart('/'));
                contentType = "text/html";
            }
            else if (Directory.Exists(fileName) && File.Exists(Path.Combine(fileName, "default.html")))
            {
                dfileName = Path.Combine(fileName, "default.html".TrimStart('/'));
                contentType = "text/html";
            }


            if (!File.Exists(dfileName))
            {
                NotExistResp(context);
            }
            else
            {
                context.Response.StateCode = "200";
                context.Response.StateDes = "OK";
                //获取请求文件的类型 
                // Path.GetExtension(context.Request.Url);
                context.Response.ContentType = contentType;

                context.Response.Body = File.ReadAllBytes(dfileName);
            }
            #endregion

        }
        //404页面返回
        private void NotExistResp(MyHttpContext context)
        {
            string str = $"<!DOCTYPE html><html lang=en> <head><meta charset=UTF-8>" +
             $"<meta name=viewport content=\"width = device - width, initial - scale = 1.0\">" +
             $"<title>C# WebServer 404 Error</title></head> " +
             $"<body> <h1>Opps 您要找的页面不存在!</h1>" +
             $"<h2>{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}</h2> " +
             $"</body> </html>";
            context.Response.StateCode = "404";
            context.Response.StateDes = "Not Found!";
            context.Response.ContentType = "text/html";
            context.Response.Body = Encoding.UTF8.GetBytes(str);
            // string notExistHtml = Path.Combine(MyConfigUtil.Get("baseWebPath"), "404.html");
            //context.Response.Body = File.ReadAllBytes(notExistHtml);
        }
    }
}
