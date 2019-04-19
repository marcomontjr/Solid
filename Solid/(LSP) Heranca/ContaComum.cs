using System;

namespace Solid.Heranca
{
    public class ContaComum
    {
        public double Saldo { get; protected set; }

        public ContaComum() => Saldo = 0;

        public void Saca(double valor)
        {
            if (valor <= Saldo)
                Saldo -= valor;
            else
                throw new ArgumentException();
        } 
        
        public virtual void Deposita(double valor) => Saldo += valor;

        public virtual void SomaInvestimento() => Saldo += Saldo * 0.01;        
    }
}