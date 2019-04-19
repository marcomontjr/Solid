using System;

namespace Solid.O
{
    class EnviadorDeEmail : IAcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf) =>        
            Console.WriteLine("Enviando Email...");        
    }
}