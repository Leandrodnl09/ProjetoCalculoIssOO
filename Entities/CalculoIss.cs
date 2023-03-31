namespace PrejetoBepecor.Entities
{
    public class CalculoIss
    {
        public static double Calculo(double valor)
        {
            return  valor * 100 / 97.99;
        }

        public static double Imposto(double valor1, double valor2)
        {
            return valor1 - valor2;
        }
    }
}