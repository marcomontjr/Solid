namespace Solid.O
{
    class NotaFiscal
    {
        public double Valor { get; set; }
        public double Imposto { get; set; }

        public NotaFiscal(double valor, double imposto)
        {
            Valor = valor;
            Imposto = imposto;
        }
    }
}