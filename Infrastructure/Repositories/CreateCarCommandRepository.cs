using Application.UseCases;
using Entities.Entities.Cars;
using Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Infrastructure.Repositories.DataContext;
using Application.Repositories;

namespace Infrastructure.Repositories
{
    //repository that call Create Data Context
    public class CreateCarCommandRepository : ICommandRepository {

        readonly CreateCarDataContext Context;
        public CreateCarCommandRepository(CreateCarDataContext context) => Context = context;

        public async ValueTask CreateCar(CarEntity car)
        {
            //call implementation to save in database
        }

        public async ValueTask SaveChanges()
        {
            //save changes un db
            //await Context.SaveChangesAsync();
        }
    }
}
