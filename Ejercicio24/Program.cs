namespace Ejercicio24
{
    internal class Program
    {
        enum State { Inactivo, Reproduciendo, Pausado, Parado, Cerrado}
        static void Main()
        {
            State firstEstado = State.Inactivo;
            
            while (firstEstado != State.Cerrado)
            {
                Console.WriteLine("Introduzca una acción p (play), s (stop), q (queue)");
                string estado = Console.ReadLine();
                estado = estado.ToLower();
                try
                {
                    switch (estado)
                    {
                        case "p":
                            if (firstEstado == State.Inactivo)
                            {
                                firstEstado = State.Reproduciendo;
                                Console.WriteLine((State)firstEstado);
                            }
                            else if (firstEstado == State.Reproduciendo)
                            {
                                firstEstado = State.Pausado;
                                Console.WriteLine((State)firstEstado);
                            }
                            else if (firstEstado == State.Pausado)
                            {
                                firstEstado= State.Reproduciendo;
                                Console.WriteLine((State)firstEstado);
                            }
                            break;
                        case "q":
                            if (firstEstado == State.Inactivo)
                            {
                                firstEstado = State.Cerrado;
                                Console.WriteLine((State)firstEstado);
                            }
                            else if (firstEstado == State.Reproduciendo)
                            {
                                firstEstado = State.Cerrado;
                                Console.WriteLine((State)firstEstado);
                            }
                            else if (firstEstado == State.Pausado)
                            {
                                firstEstado = State.Cerrado;
                                Console.WriteLine((State)firstEstado);
                            }
                            else if (firstEstado == State.Parado)
                            {
                                firstEstado = State.Cerrado;
                                Console.WriteLine((State)firstEstado);
                            }
                            break;
                        case "s":
                            if (firstEstado == State.Reproduciendo)
                            {
                                firstEstado = State.Parado;
                                Console.WriteLine((State)firstEstado);
                            }
                            else if (firstEstado == State.Pausado)
                            {
                                firstEstado = State.Parado;
                                Console.WriteLine((State)firstEstado);
                            }
                            break;
                        default:
                            throw new Exception("Acción no válida");
                            break;

                    }
                }
                catch (Exception nope)
                {
                    Console.WriteLine("La acción no esta disponible");
                }
            }
        }
    }
}