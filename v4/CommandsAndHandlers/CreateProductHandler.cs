using Mediator;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandsAndHandlers
{
    public class CreateProductHandler : IRequestHandler<CreateProduct, int>
    {
        public Task<int> Handle(CreateProduct request, CancellationToken cancellationToken)
        {
            // Lógica para crear un nuevo producto...
            Debug.WriteLine($"Crear el producto: {request.Name}");

            // Lógica para devolver el Id...
            return Task.FromResult(new Random().Next(1, 1000));
        }
    }
}
