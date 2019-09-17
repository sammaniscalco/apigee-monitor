using apigee_monitor.Models;
using System.Collections.Generic;

namespace apigee_monitor.Services
{
    public interface IMonitorService
    {
        List<Component> ComponentStatus(string serverId);
        Component ComponentStatus(string serverId, string serviceId);
    }
}
