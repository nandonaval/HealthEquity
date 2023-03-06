using CarsWeb.Models;
using CarsWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CarsWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICarService _service;

        public HomeController(ICarService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var cars = await _service.GetAll();
            return View(cars);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
