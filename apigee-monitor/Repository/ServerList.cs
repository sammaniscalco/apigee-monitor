using apigee_monitor.Models;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Linq;

namespace apigee_monitor.Repository
{
    public class ServerList : IServerRepository
    {
        private readonly List<Server> _context;
        
        public ServerList(IOptions<List<Server>> context)
        {
            _context = context.Value;
        }

        public IEnumerable<Server> GetServers()
        {
            return _context;
        }

        public Server GetServer(string id)
        {
            return _context.FirstOrDefault(s=>s.Id==id);
        }
    }
}
