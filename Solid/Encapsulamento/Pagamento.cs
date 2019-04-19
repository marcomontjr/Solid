namespace Solid
{
    public class Pagamento
    {
        public Pagamento(double valor, MeioDePagamento meioDePagamento)
        {
            Valor = valor;
            MeioDePagamento = meioDePagamento;
        }

        public double Valor { get; set; }
        public MeioDePagamento MeioDePagamento { get; set; }
    }
}