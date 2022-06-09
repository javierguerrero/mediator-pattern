using MediatR;
using System.Diagnostics;

namespace MediatRDemo
{
    public class OneWayHandler : AsyncRequestHandler<OneWay>
    {
        protected override Task Handle(OneWay request, CancellationToken cancellationToken)
        {
            Debug.WriteLine("Mensaje OneWay...");
            return Task.CompletedTask;
        }
    }
}
