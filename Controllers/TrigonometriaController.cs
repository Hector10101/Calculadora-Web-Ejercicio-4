using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculadora_Web_Ejercicio_4.Models;
using Microsoft.AspNetCore.Mvc;

namespace Calculadora_Web_Ejercicio_4.Controllers
{
    public class TrigonometriaController : Controller
    {
        public IActionResult Trigonometria()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Trigonometria(Operaciones operaciones, string Funtion)
        {
            Double Total = 0;
            Double V1 = (operaciones.Valor1 * Math.PI)/180;
           
            switch (Funtion)
            {
                case "sen":
                    Total = Math.Sin(V1);
                    break;

                case "cos":
                    Total = Math.Cos(V1);
                    break;

                case "tan":
                    Total = Math.Tan(V1);
                    break;

                case "cot":
                    Total = 1/Math.Tan(V1);
                    break;

                case "sec":
                    Total = 1/Math.Cos(V1);
                    break;

                case "csc":
                    Total = 1/Math.Sin(V1);
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