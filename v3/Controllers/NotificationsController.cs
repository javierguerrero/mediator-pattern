using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Notifications.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public NotificationsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public IActionResult SaveChanges()
        {
            PersistenceService service = new PersistenceService(_mediator);

            service.SaveChanges();

            return Ok("Save!!!");
        }
    }
}
