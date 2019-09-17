using apigee_monitor.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace apigee_monitor.Repository
{
    public class ComponentRepository : IComponentRepository
    {
        private readonly ComponentContext _context;

        public ComponentRepository(ComponentContext context)
        {
            _context = context;
        }

        public IEnumerable<Component> GetComponents()
        {
            return _context.Components.ToList();
        }

        public IEnumerable<Component> GetComponents(IEnumerable<string> components)
        {
            return _context.Components.Where(c=> components.Contains(c.Id));
        }

        public Component GetComponent(string id)
        {
            return _context.Components.Find(id);
        }
    }
}
