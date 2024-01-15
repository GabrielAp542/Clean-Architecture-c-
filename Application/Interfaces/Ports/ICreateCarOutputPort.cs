using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Ports
{

    //this interface works as an output port to external layers
    public interface ICreateCarOutputPort
    {
        ValueTask Handle(int CarId);
    }
}
