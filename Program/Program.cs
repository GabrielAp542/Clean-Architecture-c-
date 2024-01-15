using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main()
        {
            // Dependency injection can be used in a real application
            ICreateCarRepository carRepository = new CarRepository();
            ICarService carService = new CarService();

            var brand = new Entities.Brand { Id = 1, Name = "Toyota" };
            var model = new Domain.Model { Id = 1, Name = "Camry" };

            var car = new Domain.Car { Id = 1, BrandId = brand.Id, ModelId = model.Id, Year = 2022, IsAvailable = false };

            // Make the car available
            car = carService.MakeCarAvailable(car);

            // Save the updated car to the database
            car = carRepository.SaveCar(car);

            // Fetch the car from the database by ID
            var fetchedCar = carRepository.GetCarById(car.Id);

            // Display the car information
            Console.WriteLine($"Fetched Car ID: {fetchedCar.Id}, Brand: {brand.Name}, Model: {model.Name}, Year: {fetchedCar.Year}, Available: {fetchedCar.IsAvailable}");
        }
    }
}
