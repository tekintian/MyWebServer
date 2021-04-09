namespace MyWebServer
{
    public interface IMyHttpHandler
    {
        void ProcessRequest(MyHttpContext context);
    }
}
