using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public static class DependecyInjection
    {
        public static IServiceCollection AddMediator(this IServiceCollection services, Assembly handlersAssembly)
        {
            services.AddSingleton<IMediator>(provider => new Mediator(handlersAssembly));
            return services;
        }
    }
}
