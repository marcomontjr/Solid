namespace Solid.OD
{
    public class Compra
    {
        public double Valor { get; set; }
        public string Cidade { get; set; }

        public Compra(double valor, string cidade)
        {
            Valor = valor;
            Cidade = cidade;
        }
    }
}