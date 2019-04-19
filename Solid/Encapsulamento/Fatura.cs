using System.Collections.Generic;

namespace Solid
{
    public class Fatura
    {
        public string Cliente { get; private set; }
        private IList<Pagamento> Pagamentos = new List<Pagamento>();
        public double Valor { get; set; }
        public bool Pago { get; set; } = true;

        public Fatura(string cliente, double valor)
        {
            Cliente = cliente;
            Valor = valor;
        }

        public void AdicionaPagamento(Pagamento pagamento)
        {
            Pagamentos.Add(pagamento);

            if (ValorTotalDosPagamentos() >= Valor)
                Pago = true;
        }

        private double ValorTotalDosPagamentos()
        {
            double total = 0;

            foreach (Pagamento pagamento in Pagamentos)
                total += pagamento.Valor;

            return total;
        }
    }
}