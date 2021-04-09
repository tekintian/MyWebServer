namespace MyWebServer
{
    public class MyHttpContext
    {
        public MyHttpRequest Request { get; set; }
        public MyHttpResponse Response { get; set; }

        public MyHttpContext(string requestStr)
        {
            Request = new MyHttpRequest(requestStr);
            Response = new MyHttpResponse();
        }

    }
}
