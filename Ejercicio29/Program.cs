namespace Ejercicio29_2_
{
    class Program
    {

        const double EURO_A_LIBRA = 0.86;
        const double EURO_A_YEN = 1.28611;
        const double EURO_A_DOLAR = 129.852;
        enum Divisa { libras, yenes, dolares };

        static void Main()
        {
            Console.WriteLine("Introduzca cuantos euros quiere cambiar");
            double dinero = double.Parse(Console.ReadLine());
            Console.WriteLine("Ahora seleccione a qué divisa desea cambiarlo(libras, yenes, dolares)");
            string divisa = Console.ReadLine();

            Convertir(dinero, divisa.ToString());
        }

        static void Convertir(double dinero, string divisa)
        {
            object currency;

            if (Enum.TryParse(typeof(Divisa), divisa, true, out currency))

            {
                double result = 0;

                switch ((Divisa)currency)
                {
                    case Divisa.libras:
                        result = dinero * EURO_A_LIBRA;
                        break;

                    case Divisa.yenes:
                        result = dinero * EURO_A_YEN;
                        break;


                    case Divisa.dolares:
                        result = dinero * EURO_A_DOLAR;
                        break;
                }

                Console.WriteLine($"{dinero} son {result} {currency}");
            }
            else
            {
                Console.WriteLine("No sé que moneda es esa");
            }
        }



    }
}