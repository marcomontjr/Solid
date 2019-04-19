namespace Solid.O
{
    class Fatura
    {
        public double ValorMensal { get; set; }
        public string NomeCliente { get; set; }

        public Fatura(double valorMensal, string nomeCliente)
        {
            ValorMensal = valorMensal;
            NomeCliente = nomeCliente;
        }
    }
}