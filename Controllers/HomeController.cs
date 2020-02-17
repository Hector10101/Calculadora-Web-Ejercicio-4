using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Calculadora_Web_Ejercicio_4.Models;
using static Calculadora_Web_Ejercicio_4.Models.Operaciones;

namespace Calculadora_Web_Ejercicio_4.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Operaciones()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Operaciones operaciones, string Funtion)
        {
            float Total = 0;
            float V1 = Convert.ToSingle(operaciones.Valor1.ToString());
            float V2 = Convert.ToSingle(operaciones.Valor2.ToString());            

            switch (Funtion) {
                case "+":
                    Total = V1 + V2;
                    break;

                case "-":
                    Total = V1 - V2;
                    break;

                case "*":
                    Total = V1 * V2;
                    break;

                case "/":
                    Total = V1 / V2;
                    break;

                default:
                    Total = 0;
                    break;
            }
            ViewData["Resultado"] = Total;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
