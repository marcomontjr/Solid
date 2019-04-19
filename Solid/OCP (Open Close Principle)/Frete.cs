namespace Solid.OD
{
    class Frete : IServico
    {
        public double Para(string cidade)
        {
            if ("SÃO PAULO".Equals(cidade.ToUpper()))            
                return 15;

            return 30;
        }
    }
}