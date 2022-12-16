namespace Ejercicio26
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Introduce un número");
            double numberN = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(FactorialM(numberN));
            
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

        static double FactorialM(double numberN)
        {
            double fact = 0; 

            if (numberN <= 1)
            {
                fact = FactorialN(numberN) + 1;
            }
            else if (numberN >= 2)
            {
                for (double i = numberN; i >= 1 ; i--)
                {
                    fact += FactorialN(numberN - 1) + numberN; //mirar luego 
                }
                    
            }

            return fact;    
        }
    }
}