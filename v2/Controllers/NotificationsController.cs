using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Notifications.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationsController : ControllerBase
    {
        [HttpGet]
        public IActionResult SaveChanges()
        {
            PersistenceService service = new PersistenceService(
                new Mediator(
                    new NotificationHandler1(),
                    new NotificationHandler2(),
                    new NotificationHandler3()
                )
            );

            service.SaveChanges();

            return Ok("Save!!!");
        }
    }
}
