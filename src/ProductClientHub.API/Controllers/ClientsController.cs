using Microsoft.AspNetCore.Mvc;
using ProductCientHub.API.UseCases.Clients.Registers;
using ProductClientHub.Communication.Reponses;
using ProductClientHub.Communication.Requests;
using ProductClientHub.Exceptions.ExceptionBase;

namespace ProductCientHub.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseClient), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ResponseClient), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ResponseClient), StatusCodes.Status500InternalServerError)]
        public IActionResult Register([FromBody] RequestClient request)
        {
            var useCase = new RegisterClientUseCase();

            var response = useCase.Execute(request);

            return Created(string.Empty, response);
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
