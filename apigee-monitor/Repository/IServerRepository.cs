using apigee_monitor.Models;
using System.Collections.Generic;

namespace apigee_monitor.Repository
{
    public interface IServerRepository
    {
        IEnumerable<Server> GetServers();
        Server GetServer(string id);
    }
}
