using Entities.Entities.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories
{
    //interface to use case
    public interface ICommandRepository
    {
        ValueTask CreateCar(CarEntity car);
    }
}
