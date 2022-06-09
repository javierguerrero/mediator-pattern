namespace Notifications
{
    public class PersistenceService
    {
        // Declarar las variables para almacenar las 
        // instancias de los manejadores de notificaciones
        private readonly NotificationHandler1 _handler1;
        private readonly NotificationHandler2 _handler2;
        private readonly NotificationHandler3 _handler3;

        // Obtener las instancias de los manejadores a través del constructor
        public PersistenceService(NotificationHandler1 handler1, NotificationHandler2 handler2, NotificationHandler3 handler3)
        {
            _handler1 = handler1;
            _handler2 = handler2;   
            _handler3 = handler3;   
        }

        // Método para guardar los cambios del usuario
        public void SaveChanges()
        {
            // Lógica para guardar cambios
            // ...

            // Notificar a los manejadores
            _handler1.Handle("SaveChanges");
            _handler2.Handle("SaveChanges");
            _handler3.Handle("SaveChanges");
        }

    }
}
