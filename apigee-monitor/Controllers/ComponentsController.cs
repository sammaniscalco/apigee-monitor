using apigee_monitor.Models;
using apigee_monitor.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace apigee_monitor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComponentsController : ControllerBase
    {
        private readonly IComponentRepository _componentRepository;
        public ComponentsController(IComponentRepository componentRepository)
        {
            _componentRepository = componentRepository;
        }

        // GET: api/Components
        [HttpGet]
        public ActionResult<IEnumerable<Component>> Get()
        {
            return Ok(_componentRepository.GetComponents());
        }

        // GET: api/Components/5
        [HttpGet("{id}")]
        public ActionResult<Component> Get(string id)
        {
            var component = _componentRepository.GetComponent(id);

            //make sure service exists
            if (component != null)
            {
                return Ok(component);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
