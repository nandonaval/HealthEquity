using CarsApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarsApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarController : Controller
    {
        private static readonly string[] Summaries = new[]{
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };


        private static List<Car> _cars = new List<Car>()
        {
                new Car() { Id = 1, Make = "Audi", Model = "R8", Year = 2018, Doors = 2, Color = "Red", Price = 79995},
                new Car() { Id = 2, Make = "Tesla", Model = "3", Year = 2018, Doors = 4, Color = "Black", Price = 54995},
                new Car() { Id = 3, Make = "Porsche", Model = "911 991", Year = 2020, Doors = 2, Color = "White", Price = 155000},
                new Car() { Id = 4, Make = "Mercedez-Benz", Model = "GLE 63S", Year = 2021, Doors = 5, Color = "Blue", Price = 83995},
                new Car() { Id = 5, Make = "BMW", Model = "X 6M", Year = 2020, Doors = 5, Color = "Silver", Price = 62995}  
        };


        // GET: CarController
        [HttpGet]
        public IEnumerable<Car> Get()
        {            
            return _cars;
        }

        [Route("{id}")]
        [HttpGet]
        public IEnumerable<Car> GetCar(int id)
        {
            return _cars.Where(x => x.Id == id );
        }

        // GET: CarController
        [HttpPost]
        public IActionResult Create(Car car)
        {   
            _cars.Add(car);
            return Ok();
        }

        [Route("{id}")]
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            Car car = _cars.Where(x => x.Id == id).FirstOrDefault();
            if (car != null)
                _cars.Remove(car);

            return Ok();
        }

        
        [HttpPut]
        public IActionResult Update(Car _car)
        {
            var index = _cars.FindIndex(x => x.Id == _car.Id);

            if (index != -1)
            {
                _cars[index].Make = _car.Make;
                _cars[index].Model = _car.Model;
                _cars[index].Year = _car.Year;
                _cars[index].Doors = _car.Doors;
                _cars[index].Price = _car.Price;
                _cars[index].Color = _car.Color;
            }

            return Ok();
        }
    }
}
