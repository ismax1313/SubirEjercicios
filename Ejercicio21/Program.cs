namespace Ejercicio21
{
    internal class Program
    {
        enum WeekDays { Monday = 1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday};
        static void Main()
        {
            Console.WriteLine("Indica un día de la semana");
            string day = Console.ReadLine();

            WeekDays semana = (WeekDays)Enum.Parse(typeof(WeekDays), day, true);

            if (semana == WeekDays.Saturday || semana == WeekDays.Sunday)
            {
                Console.WriteLine("No laboral");
            }
            else
            {
                Console.WriteLine("laboral");
            }
        }
    }
}