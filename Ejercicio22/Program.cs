namespace Ejercicio22
{
    internal class Program
    {
        enum State { ON , OFF }
        static void Main()
        {
            State firstEstado = State.OFF;
            
            while (true)
            {
                Console.WriteLine("Indica el estado de la lámpara");
                string estado = Console.ReadLine();

                State state = (State)Enum.Parse(typeof(State), estado, true);

                    if (firstEstado == State.ON && state == State.OFF)
                    {
                        firstEstado = State.OFF;
                        Console.WriteLine("La lámpara esta apagada");
                    }
                    else if (firstEstado == State.OFF && state == State.ON)
                    {
                        firstEstado = State.ON;
                        Console.WriteLine("La lámpara esta encendida");
                    }
                    else
                    {
                        throw new Exception("Accción no válida");
                    }
                
                

            }
            

        }
    }
}