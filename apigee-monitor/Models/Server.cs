using System.Collections.Generic;

namespace apigee_monitor.Models
{
    public class Server
    {
        public string Id { get; set; }
        public string Url { get; set; }
        public List<string> Components { get; set; }
    }
}
