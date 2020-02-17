using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculadora_Web_Ejercicio_4.Models;
using Microsoft.AspNetCore.Mvc;

namespace Calculadora_Web_Ejercicio_4.Controllers
{
    public class PotenciaController : Controller
    {
        public IActionResult PotenciaView()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PotenciaView(Operaciones operaciones, string Funtion)
        {
            Double Total = 0;
            Double V1 = operaciones.Valor1;
            Double V2 = operaciones.Valor2;
            Total = Math.Pow(V1, V2);

            ViewData["Resultado"] = Total;
            return View();
        }
    }
}