using Lab1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab1.Controllers
{
    public class VehicleController : Controller
    {
        List<Vehicle> vehicles;
        public VehicleController()
        {
            vehicles = new List<Vehicle>();
            Vehicle vehicle1 = new Vehicle
            {
                Id = 1,
                Year = "2000",
                Make = "Ford",
                Model = "Mustang",
                Price = 9999,
                Mileage = 100000,
                MPG = 25
            };

            Vehicle vehicle2 = new Vehicle
            {
                Id = 2,
                Year = "1999",
                Make = "Nissan",
                Model = "Sentra",
                Price = 15000,
                Mileage = 2000,
                MPG = 28
            };

            Vehicle vehicle3 = new Vehicle
            {
                Id = 3,
                Year = "2020",
                Make = "Kia",
                Model = "Soul",
                Price = 20000,
                Mileage = 1000,
                MPG = 29
            };
            vehicles.Add(vehicle1);
            vehicles.Add(vehicle2);
            vehicles.Add(vehicle3);
        }


        
        public IActionResult Index()
        {
            return View(vehicles);

        }

        public IActionResult Details(int id)
        {
            foreach (Vehicle vehicle in vehicles)
            {
                if (vehicle.Id == id)
                {
                    return View(vehicle);
                }
                
            }

            return NotFound();
        }

    }
}
