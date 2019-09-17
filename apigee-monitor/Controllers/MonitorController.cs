using apigee_monitor.Models;
using apigee_monitor.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace apigee_monitor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonitorController : ControllerBase
    {
        private readonly IMonitorService _monitorService;
        public MonitorController(IMonitorService monitorService)
        {
            _monitorService = monitorService;
        }

        // GET: api/Monitor/5
        [HttpGet("{serverId}")]
        public ActionResult<IEnumerable<Component>> Get(string serverId)
        {
            //get all service statuses
            var components=_monitorService.ComponentStatus(serverId);

            //return result
            if (components != null)
            {
                return Ok(components);
            }
            else
            {
                return NotFound();
            }
        }

        // GET: api/Monitor/5
        [HttpGet("{serverId}/{componentId}")]
        public ActionResult<Component> Get(string serverId, string componentId)
        {
            //get service status
            var component = _monitorService.ComponentStatus(serverId, componentId);

            //return result
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