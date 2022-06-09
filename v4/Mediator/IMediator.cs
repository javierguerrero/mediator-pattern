using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public interface IMediator
    {
        // Enviar una petición que no espera resultado.
        Task Send(IRequest request, CancellationToken cancellationToken = default);

        // Enviar una petición que espera resultado.
        Task<ResponseType> Send<ResponseType>(IRequest<ResponseType> request, CancellationToken cancellationToken = default);
    }
}
