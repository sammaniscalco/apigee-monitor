using apigee_monitor.Models;
using System.Collections.Generic;

namespace apigee_monitor.Repository
{
    public interface IComponentRepository
    {
        IEnumerable<Component> GetComponents();
        IEnumerable<Component> GetComponents(IEnumerable<string> components);
        Component GetComponent(string id);
    }
}
