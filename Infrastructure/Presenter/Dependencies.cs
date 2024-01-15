using Application.Interfaces.Ports;
using Application.Interfaces.Presenters;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Presenter
{
    //dependency injection
    public static class Dependencies
    {
        public static IServiceCollection AddPresenters(
            this IServiceCollection services)
        {
            services.AddScoped<CreateCarPresenter>();

            services.AddScoped<ICreateCarOutputPort>(
                provider => provider.GetService<CreateCarPresenter>());

            services.AddScoped<ICreateCarPresenter>(
                provider => provider.GetService<CreateCarPresenter>());

            return services;
        }
    }
}
