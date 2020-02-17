using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculadora_Web_Ejercicio_4.Models;
using Microsoft.AspNetCore.Mvc;

namespace Calculadora_Web_Ejercicio_4.Controllers
{
    public class RaicesController : Controller
    {
        public IActionResult Raices()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Raices(Operaciones operaciones, string Funtion)
        {
            Double Total = 0;
            Double V1 = operaciones.Valor1;

            switch (Funtion)
            {
                case "sqrt":
                    Total = Math.Sqrt(V1);
                    break;

                case "cbrt":
                    Total = Math.Cbrt(V1);
                    break;
                default:
                    Total = 0;
                    break;
            }
            Total = (Math.Round((double)Total * 10000)) / 10000;
            ViewData["Resultado"] = Total;
            return View();
        }
    }
}