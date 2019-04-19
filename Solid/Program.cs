using Solid.OD;
using Solid.O;
using Solid.S;
using System;
using System.Collections.Generic;
using Solid.Heranca;

namespace Solid
{
    class Program
    {
        static void Main(string[] args)
        {
            //S
            //CalculadoraDeSalario cs = new CalculadoraDeSalario();
            //Funcionario funcionario = new Funcionario(new Desenvolvedor(new DezOuVintePorCento()), 2000.0);
            //double resultado;

            //resultado = cs.Calcula(funcionario);

            //Console.WriteLine($"O Salário de um desenvolvedor que ganha {funcionario.SalarioBase} é: {resultado}");

            //O
            //EnviadorDeEmail enviadorDeEmail = new EnviadorDeEmail();
            //NotaFiscalDao nfDao = new NotaFiscalDao();

            //IList<IAcaoAposGerarNota> acoes = new List<IAcaoAposGerarNota>()
            //{
            //    enviadorDeEmail,
            //    nfDao
            //};

            //GeradorDeNotaFiscal gnf = new GeradorDeNotaFiscal(acoes);

            //Fatura fatura = new Fatura(200, "Renan");
            //gnf.Gera(fatura);

            //OD
            //Compra compra = new Compra(500, "São Paulo");
            //CalculadoraDePrecos calc = new CalculadoraDePrecos(new TabelaDePrecoPadrao(), new Frete());

            //double resultado = calc.Calcula(compra);

            //Console.WriteLine($"O preço da compra é {resultado}");

            //Encapsulamento
            //List<Boleto> boletos = new List<Boleto>()
            //{
            //    new Boleto(200),
            //    new Boleto(300),
            //    new Boleto(400)
            //};

            //Fatura fatura = new Fatura("Caelum", 900);

            //ProcessadorDeBoleto pdb = new ProcessadorDeBoleto();

            //pdb.Processa(boletos, fatura);

            //Console.WriteLine(fatura.Pago);

            //Herança
            IList<ContaComum> contas = new List<ContaComum>();

            foreach (ContaComum conta in contas)
            {
                conta.SomaInvestimento();
                Console.WriteLine("Novo Saldo: " + conta.Saldo);
            }
            Console.ReadKey();
        }

        private static IList<ContaComum> ContasDoBanco()
        {
            List<ContaComum> contas = new List<ContaComum>();
            contas.Add(UmaContaComum(100));
            contas.Add(UmaContaComum(150));
            contas.Add(UmaContaEstudante(100));
            return contas;
        }

        private static ContaEstudante UmaContaEstudante(double saldo)
        {
            ContaEstudante conta = new ContaEstudante();
            conta.Deposita(saldo);
            return conta;
        }

        private static ContaComum UmaContaComum(double saldo)
        {
            ContaComum conta = new ContaComum();
            conta.Deposita(saldo);
            return conta;
        }
    }
}