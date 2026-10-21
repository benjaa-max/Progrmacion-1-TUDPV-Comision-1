using System;
using System.Globalization;
using System.Threading;


class Program
{
    static void Main()
    {
    
        CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

        for (int i = 1; i <= 8; i++)
        {
            Console.WriteLine("¡Comienza la oleada " + i + "!");
            Thread.Sleep(500); 
        }

        Console.WriteLine();
        Console.WriteLine("Presioná una tecla para salir...");
        Console.ReadKey();
    }
}
