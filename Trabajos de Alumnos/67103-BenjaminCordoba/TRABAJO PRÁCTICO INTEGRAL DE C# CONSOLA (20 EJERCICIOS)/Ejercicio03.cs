using System;
using System.Globalization;
using System.Threading;


class Program
{
    static void Main()
    {
       
        CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

        int monedas = 20;

        Console.Write("Multiplicador de combo: ");
        int combo = int.Parse(Console.ReadLine());

        int puntaje = monedas * combo;

        Console.WriteLine("¡Puntaje con combo: " + puntaje + " puntos!");

        Console.WriteLine();
        Console.WriteLine("Presioná una tecla para salir...");
        Console.ReadKey();
    }
}
