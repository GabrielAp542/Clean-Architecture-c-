using Infrastructure.Interfaces.Controllers;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Controllers
{
    //dependency injection
    public static class Dependencies
    {
        public static IServiceCollection AddControllers(this IServiceCollection services)
        {
            services.AddScoped<ICreateCarController,
                CreateCarController>();
            return services;
        }
    }
}
