using System.Collections.Generic;

namespace Solid.O
{
    class GeradorDeNotaFiscal
    {
        private IList<IAcaoAposGerarNota> Acoes = new List<IAcaoAposGerarNota>();

        public GeradorDeNotaFiscal(IList<IAcaoAposGerarNota> acoes) => Acoes = acoes;        

        public NotaFiscal Gera(Fatura fatura)
        {
            double valor = fatura.ValorMensal;

            NotaFiscal nf = new NotaFiscal(valor, ImpostoSimplesSobreO(valor));

            foreach (var acao in Acoes)            
                acao.Executa(nf);            

            return nf;
        }

        private double ImpostoSimplesSobreO(double valor) => valor * 0.06;   
    }
}