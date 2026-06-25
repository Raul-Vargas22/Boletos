using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boletos
{
    internal class BoletoEstudiante : Boleto
    {
        public string Matricula { get; set; }

        public BoletoEstudiante(string matricula)
        {
            Matricula = matricula;
        }

        public override double CalcularPrecioFinal()
        {
            return PrecioBase * 0.70;
        }
    }
}