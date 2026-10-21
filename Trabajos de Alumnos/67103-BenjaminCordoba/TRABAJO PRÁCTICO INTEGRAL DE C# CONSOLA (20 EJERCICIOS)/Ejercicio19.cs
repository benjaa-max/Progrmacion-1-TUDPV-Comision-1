using System;
using System.Globalization;
using System.Threading;


class Program
{
    static void Main()
    {
      
        CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

        int opcion = 1;

        while (opcion == 1)
        {
            Console.WriteLine("Jugando la partida... ¡Has perdido!");
            Console.Write("¿Deseas jugar otra partida? (1: Si / 2: No): ");
            opcion = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Gracias por jugar. ¡Hasta la próxima!");

        Console.WriteLine();
        Console.WriteLine("Presioná una tecla para salir...");
        Console.ReadKey();
    }
}
