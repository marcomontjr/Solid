﻿namespace Solid.S
{
    public class DezOuVintePorCento : IRegraDeCalculo
    {
        public double Calcula(Funcionario funcionario)
        {
            if (funcionario.SalarioBase > 3000.0)
                return funcionario.SalarioBase * 0.8;
            else
                return funcionario.SalarioBase * 0.9;
        }
    }
}