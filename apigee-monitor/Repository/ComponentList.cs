using apigee_monitor.Models;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;

namespace apigee_monitor.Repository
{
    public class ComponentList:IComponentRepository
    {
        private readonly List<Component> _context;

        public ComponentList(IOptions<List<Component>> context)
        {
            _context = context.Value;
        }

        public IEnumerable<Component> GetComponents()
        {
            return _context;
        }

        public IEnumerable<Component> GetComponents(IEnumerable<string> components)
        {
            return _context.Where(c => components.Contains(c.Id));
        }

        public Component GetComponent(string id)
        {
            return _context.FirstOrDefault(c => c.Id == id);
        }
    }
}
