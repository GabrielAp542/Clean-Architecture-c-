using Application.Interfaces.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Presenter
{
    //presenter to view
    public class CreateCarPresenter : ICreateCarPresenter
    {
        public int CarId { get; private set; }
        public ValueTask Handle(int carId)
        {
            CarId = carId;
            return ValueTask .CompletedTask;
        }
    }
}
