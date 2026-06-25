namespace Boletos
{
    public class BoletoAdultoMayor : Boleto
    {
        public string NumCredencialInapam { get; set; }

        public BoletoAdultoMayor(string numCredencialInapam)
        {
            NumCredencialInapam = numCredencialInapam;
        }

        public override double CalcularPrecioFinal()
        {
            double descuento = PrecioBase * 0.50;
            double precioFinal = PrecioBase - descuento;

            return precioFinal;
        }
    }
}