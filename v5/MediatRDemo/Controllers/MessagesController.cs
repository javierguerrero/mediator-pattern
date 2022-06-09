using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MediatRDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        readonly IMediator Mediator;
        public MessagesController(IMediator mediator) => Mediator = mediator;

        [HttpGet("Send-And-Wait-For-Response")]
        public async Task<IActionResult> SendAndWaitForResponse()
        {
            var Response = await Mediator.Send(new Ping());
            return Ok(Response);
        }

        [HttpGet("Send-Without-Response")]
        public async Task<IActionResult> SendWithoutResponse()
        {
            await Mediator.Send(new OneWay());
            return Ok("Completed!!!");
        }
    }


}
