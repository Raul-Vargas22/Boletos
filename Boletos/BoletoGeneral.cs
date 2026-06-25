using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boletos
{
    public class BoletoGeneral : Boleto
    {
        public override double CalcularPrecioFinal()
        {
            return PrecioBase;
        }
    }
}