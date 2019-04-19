namespace Solid.S
{
    public class Funcionario
    {
        public Cargo Cargo { get; set; }
        public double SalarioBase { get; set; }

        public Funcionario(Cargo cargo, double salarioBase)
        {
            Cargo = cargo;
            SalarioBase = salarioBase;
        }

        public double CalculaSalario() => Cargo.Regra.Calcula(this);
    }
}