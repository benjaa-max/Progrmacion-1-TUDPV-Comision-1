using System;
using System.Globalization;
using System.Threading;


class Program
{
    static void Main()
    {
     
        CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Velocidad del personaje (ej. 6.5): ");
        float velocidad = float.Parse(Console.ReadLine());

        Console.WriteLine("Velocidad del personaje fijada en: " + velocidad + " m/s");

        Console.WriteLine();
        Console.WriteLine("Presioná una tecla para salir...");
        Console.ReadKey();
    }
}
