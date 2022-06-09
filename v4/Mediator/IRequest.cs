using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    // Representa una petición que no devuelve resultado.
    public interface IRequest { }

    // Representa una petición que devuelve un resultado de tipo ResponseType
    public interface IRequest<ResponseType> { }
}
