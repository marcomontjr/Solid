namespace Solid.O
{
    class NotaFiscalDao : IAcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf) =>        
            System.Console.WriteLine("Salvando no banco...");        
    }
}