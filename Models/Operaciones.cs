using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora_Web_Ejercicio_4.Models
{
    public class Operaciones
    {
        [Required]

        public double Valor1 { get; set; }

        [Required]
        public double Valor2 { get; set; }


        public double Resultado { get; set; }

    }
}
