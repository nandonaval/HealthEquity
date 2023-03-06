using CarsApi.Data;
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
        private readonly ICarRepository _carRepository;

        public CarController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }


        // GET: CarController
        [HttpGet]
        public IEnumerable<Car> Get()
        {            
            return _carRepository.GetAll();
        }

        [Route("{id}")]
        [HttpGet]
        public Car GetCar(int id)
        {
            return _carRepository.GetById(id);
        }

        // GET: CarController
        [HttpPost]
        public IActionResult Create(Car car)
        {
            _carRepository.Add(car);
            return Ok();
        }

        [Route("{id}")]
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _carRepository.Remove(id);
            return Ok();
        }

        
        [HttpPut]
        public IActionResult Update(Car car)
        {
            _carRepository.Udate(car);
            return Ok();
        }
    }
}
