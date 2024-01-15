using Application.Interfaces;
using Infrastructure.Repositories;
using Infrastructure.Interfaces;
using System;
using Entities.Entities.Cars;
using Infrastructure.Controllers;

namespace UI.Program
{
    internal class Program
    {
        //framework layer (frontend)
        static void Main(string[] args)
        {
            CarEntity car = new CarEntity();
            car.Id = 1;
            car.Year = "2022";
            car.ModelId = 1;
            car.IsAvailable = true;
            car.ColorId = 3;
            CreateCarController create = new CreateCarController();
            create.CreateCar(car);
        }
    }
}