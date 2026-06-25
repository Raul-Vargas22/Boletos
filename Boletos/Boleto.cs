using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boletos
{
    public abstract class Boleto
    {
        public double PrecioBase { get; set; }

        public Boleto()
        {
            PrecioBase = 80.00;
        }

        public abstract double CalcularPrecioFinal();
    }
}
