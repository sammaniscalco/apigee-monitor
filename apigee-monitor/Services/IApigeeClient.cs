namespace apigee_monitor.Services
{
    public interface IApigeeClient
    {
        bool IsServiceRunning(string url, int port);
    }
}
