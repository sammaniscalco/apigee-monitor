using System.Net.Http;

namespace apigee_monitor.Services
{
    public class ApigeeClient:IApigeeClient
    {

        private readonly IHttpClientFactory _httpClientFactory;

        public ApigeeClient(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public bool IsServiceRunning(string url, int port)
        {
            //create endpoint url
            string endpoint = $"{url}:{port}/self";

            //get client and call endpoint
            var client = _httpClientFactory.CreateClient("monitor");
            var httpResponse = client.GetAsync(endpoint).Result;

            //return status code
            return httpResponse.IsSuccessStatusCode;

        }
    }
}
