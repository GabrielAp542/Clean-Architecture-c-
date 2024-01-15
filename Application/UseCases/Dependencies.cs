using Application.Interfaces.Ports;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases
{
    //dependency injeccion by Microsoft.Extensions.DependencyInjection so this inner layers can communicate with
    //external layers while keeping the dependency rule
    public static class Dependencies
    {
        public static IServiceCollection AddUseCasesServices(this IServiceCollection services)
        {
            services.AddScoped<ICreateCarInputPort, CreateCarInteractor>();
            return services;
        }
    }
}
