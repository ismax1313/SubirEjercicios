namespace Ejercicio25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserta dos números");
            double numberN = Convert.ToDouble(Console.ReadLine());
            double numberM = Convert.ToDouble(Console.ReadLine());

            double result = FactorialN(numberN) - FactorialM(numberM);
            Console.WriteLine(result);
        }

        static double FactorialN(double numberN)
        {
            double counterN = 1;
            for (double i = 1; i <= numberN; i++)
            {
                counterN *= i; 
            }
            return counterN;
        }

        static double FactorialM(double numberM)
        {
            double counterM = 1;
            for (double i = 1; i <= numberM; i++)
            {
                counterM *= i;
            }
            return counterM;
        }
    }
}