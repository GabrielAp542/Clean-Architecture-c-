using Application.Interfaces.Ports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Presenters
{
    //interface to make a contract for presenter in infraestructure
    public interface ICreateCarPresenter : ICreateCarOutputPort
    {
        int CarId { get; }
    }
}
