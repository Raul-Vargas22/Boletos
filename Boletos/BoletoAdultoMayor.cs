namespace Boletos
{
    public class BoletoAdultoMayor : Boleto
    {
        public string NumCredencialInapam { get; set; }

        public BoletoAdultoMayor(float precioB, string numCrede) : base(precioB)
        {
            this.NumCredencialInapam = numCredencial;
        }

        public override float CalcularPrecioFinal()
        {
            return this.precioBoleto + 0.5f;
        }
    }
}