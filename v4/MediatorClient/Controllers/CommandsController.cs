using CommandsAndHandlers;
using Mediator;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MediatorClient.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        readonly IMediator Mediator;

        public CommandsController(IMediator mediator) => Mediator = mediator;

        [HttpPost]
        public async Task<IActionResult> CreateProduct(string name)
        {
            int Id = await Mediator.Send(new CreateProduct { Name = name });
            return Ok(Id);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            await Mediator.Send(new DeleteProduct { Id = id });
            return Ok($"Producto {id} eliminado!!!");
        }
    }
}
