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
    }
}
