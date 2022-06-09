using System.Diagnostics;

namespace Notifications
{
    public abstract class NotificationHandlerBase
    {
        public virtual void Handle(string message)
        {
            Debug.WriteLine($"{this.GetType()} => {message}");
        }
    }
}
