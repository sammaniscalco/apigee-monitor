using apigee_monitor.Models;
using apigee_monitor.Repository;
using System.Collections.Generic;

namespace apigee_monitor.Services
{
    public class MonitorService : IMonitorService
    {
        private readonly IServerRepository _serverRepository;
        private readonly IComponentRepository _componentRepository;
        private readonly IApigeeClient _apigeeClient;

        public MonitorService(IServerRepository serverRepository,
            IComponentRepository componentRepository,
            IApigeeClient apigeeClient)
        {
            _serverRepository = serverRepository;
            _componentRepository = componentRepository;
            _apigeeClient = apigeeClient;
        }

        public List<Component> ComponentStatus(string serverId)
        {
            List<Component> components = new List<Component>();

            //get server by serverId
            var server = _serverRepository.GetServer(serverId);

            //make sure server with services exists
            if (server != null && server.Components != null)
            {
                //loop through server services
                foreach (var componentId in server.Components)
                {
                    //get service status
                    var component = ComponentStatus(server, componentId);
                    if (component != null)
                    {
                        components.Add(component);
                    }
                }
            }

            return components;
        }

        public Component ComponentStatus(string serverId, string componentId)
        {
            //get server by serverId
            var server = _serverRepository.GetServer(serverId);

            //get service status
            return ComponentStatus(server, componentId);
        }

        private Component ComponentStatus(Server server, string componentId)
        {
            //make sure server with services exists and service is valid for the server
            if (server != null &&
                server.Components != null &&
                server.Components.Contains(componentId))
            {
                //get service from serviceId
                var component = _componentRepository.GetComponent(componentId);
                if (component != null)
                {
                    //check if service is running on host
                    component.Running = _apigeeClient.IsServiceRunning(server.Url, component.Port);
                    return component;
                }
            }

            return null;
        }

       
    }
}
