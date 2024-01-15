using Application.Interfaces;
using Application.Interfaces.Ports;
using Application.Repositories;
using Application.Validations.Car;
using Entities.Entities.Cars;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Application.UseCases
{
    //current use case (business logic)
    public class CreateCarInteractor : ICreateCarInputPort
    {
        readonly ICreateCarOutputPort createCarOutputPort;
        readonly ICommandRepository commandRepository;
        public CreateCarInteractor (ICreateCarOutputPort outputPort, ICommandRepository commandRepository)
        {
            createCarOutputPort = outputPort;
            this.commandRepository = commandRepository;
        }

        public async ValueTask Handle(CarEntity car)
        {
            await commandRepository.CreateCar(car);
            await createCarOutputPort.Handle(car.Id);
        }
    }
}
