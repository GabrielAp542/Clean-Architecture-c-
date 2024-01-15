using Entities.Entities.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Ports
{
    //this interface works as an input port from external layers
    public interface ICreateCarInputPort
    {
        ValueTask Handle(CarEntity car);
    }
}
