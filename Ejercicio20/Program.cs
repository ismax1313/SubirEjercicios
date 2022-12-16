namespace Ejercicio20
{
    internal class Program
    {
        enum Months { Enero = 1, Febrero, Marzo, Abril, Mayo, Junio, Julio, Agosto, Septiembre, Octubre, Noviembre, Diciembre};
        static void Main()
        {
            
            Console.WriteLine("Introduzca el número del mes");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine((Months)month);
        }
    }
}