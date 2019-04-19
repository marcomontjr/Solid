using System.Collections.Generic;

namespace Solid
{
    public class ProcessadorDeBoleto
    {
        public void Processa(IList<Boleto> boletos, Fatura fatura)
        {
            foreach (Boleto boleto in boletos)
            {
                Pagamento pagamento = new Pagamento(boleto.Valor, MeioDePagamento.Boleto);
                fatura.AdicionaPagamento(pagamento);                
            }
        }
    }
}