namespace Solid.OD
{
    public class CalculadoraDePrecos
    {
        private ITabelaDePrecos Tabela;
        private IServico Entrega;

        public CalculadoraDePrecos(ITabelaDePrecos tabela, IServico entrega)
        {
            Tabela = tabela;
            Entrega = entrega;
        }

        public double Calcula(Compra produto)
        {
            double desconto = Tabela.DescontoPara(produto.Valor);
            double frete = Entrega.Para(produto.Cidade);

            return produto.Valor * (1 - desconto) + frete;
        }        
    }
}