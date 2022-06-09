namespace Notifications
{
    public class Mediator: IMediator
    {
        // Declarar las variables para almacenar las
        // instancias de los manejadores de notificaciones
        private readonly IEnumerable<INotificationHandler> _handlers;

        // Obtener las instancias de los manejadores a través del constructor
        public Mediator(IEnumerable<INotificationHandler> handlers)
        {
            _handlers = handlers;
        }

        // Publicar la notificación
        public void Publish(string message)
        {
            _handlers.ToList().ForEach(h => h.Handle(message));
        }
    }
}
