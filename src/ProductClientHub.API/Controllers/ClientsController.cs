using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProductCientHub.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        [HttpPost]
        public IActionResult Register()
        {
            return Ok(new List<string> { "Client 1", "Client 2", "Client 3" });
        }

        [HttpGet]
        public IActionResult GetClients()
        {
            return Ok(new List<string> { "Client 1", "Client 2", "Client 3" });
        }

        [HttpGet("{id}")]
        [Route("{id}")]
        public IActionResult GetClientById(Guid id)
        {
            return Ok(new List<string> { $"Client {id}" });
        }

        [HttpPut()]
        [Route("{id}")]
        public IActionResult UpdateClient(Guid id)
        {
            return Ok(new List<string> { $"Client {id} updated" });
        }

        [HttpDelete()]
        [Route("{id}")]
        public IActionResult DeleteClient(Guid id)
        {
            return Ok(new List<string> { $"Client {id} deleted" });
        }

    }
}
