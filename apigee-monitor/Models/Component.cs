namespace apigee_monitor.Models
{
    public class Component
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Port { get; set; }
        public string Description { get; set; }
        public bool Running { get; set; }
    }
}
