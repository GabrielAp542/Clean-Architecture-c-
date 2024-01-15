using Entities.Entities.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interfaces.Controllers
{

    //controler that works as interface to use case
    public interface ICreateCarController
    {
        ValueTask<int> CreateCar(CarEntity car);
    }
}
