namespace Notifications
{
    public class PersistenceService
    {
        // Declarar la variable para almacenar la instancia de Mediator 
        private readonly IMediator _mediator;

        // Obtener instancia de Mediator
        public PersistenceService(IMediator mediator)
        {
            _mediator = mediator;
        }

        // Método para guardar los cambios del usuario
        public void SaveChanges()
        {
            // Lógica para guardar cambios
            // ...

            // Notificar a los manejadores
            _mediator.Publish("SaveChanges");
        }

    }
}
