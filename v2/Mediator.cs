namespace Notifications
{
    public class Mediator
    {
        // Declarar las variables para almacenar las
        // instancias de los manejadores de notificaciones
        private readonly NotificationHandler1 _handler1;
        private readonly NotificationHandler2 _handler2;
        private readonly NotificationHandler3 _handler3;

        // Obtener las instancias de los manejadores a través del constructor
        public Mediator(NotificationHandler1 handler1, NotificationHandler2 handler2, NotificationHandler3 handler3)
        {
            _handler1 = handler1;
            _handler2 = handler2;
            _handler3 = handler3;
        }

        // Publicar la notificación
        public void Publish(string message)
        {
            _handler1.Handle(message);
            _handler2.Handle(message);
            _handler3.Handle(message);
        }
    }
}
