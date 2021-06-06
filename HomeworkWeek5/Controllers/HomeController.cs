using HomeworkWeek5.Logic;
using HomeworkWeek5.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HomeworkWeek5.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();              
        }

        [HttpGet]
        public IActionResult SortArray()
        {

            return View();
        }

        [HttpPost]
        public IActionResult SortArray(int num1, int num2, int num3, int num4, int num5, int indice)
        {

            LoopTypes bucles = new LoopTypes();
            int[] antiguo = { num1, num2, num3, num4, num5 };
            ViewBag.antiguo = antiguo;
            ViewBag.array = bucles.ReSort(num1, num2, num3, num4, num5, indice);


            return View();
        }

        [HttpGet]
        public IActionResult CreateThings()
        {
 
            ViewBag.mostrarVehiculo = null;
            ViewBag.mostrararea = null;

            return View();

        }

        [HttpPost]
        public IActionResult GetTriangleArea(float num1, float num2)
        {
            ParameterTypes parametro = new ParameterTypes();

            ViewBag.area = parametro.CalculateArea(num1, num2);
            ViewBag.mostrararea = 0;

            return View("CreateThings");
        }


        [HttpPost]
        public IActionResult CreateVehicle(string modelo, int year, string color, int llantas)
        {

            ParameterTypes parametro = new ParameterTypes();
            parametro.CreateVehicle(modelo, year, color, llantas);
            ViewBag.vehicles = ParameterTypes.vehicles;

            ViewBag.mostrarVehiculo = 0;

            return View("CreateThings");
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
