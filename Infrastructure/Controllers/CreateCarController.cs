using Application.Interfaces.Ports;
using Application.Interfaces.Presenters;
using Entities.Entities.Cars;
using Infrastructure.Interfaces.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Controllers
{
    //controller to the actual task (called from framework)
    public class CreateCarController : ICreateCarController
    {
        readonly ICreateCarInputPort InputPort;
        readonly ICreateCarPresenter Presenter;

        public CreateCarController(ICreateCarInputPort inputPort, ICreateCarPresenter presenter)
            => (InputPort, Presenter) = (inputPort, presenter);

        public async ValueTask<int> CreateCar(CarEntity car)
        {
            await InputPort.Handle(car);
            return Presenter.CarId;
        }
    }
}
