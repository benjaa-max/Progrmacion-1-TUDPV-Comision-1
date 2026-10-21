using System;
using System.Globalization;
using System.Threading;


class Program
{
    static void Main()
    {
        
        CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

        for (int i = 10; i >= 1; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(500);
        }
        Console.WriteLine("¡DESPEGUE EXITOSO!");

        Console.WriteLine();
        Console.WriteLine("Presioná una tecla para salir...");
        Console.ReadKey();
    }
}
