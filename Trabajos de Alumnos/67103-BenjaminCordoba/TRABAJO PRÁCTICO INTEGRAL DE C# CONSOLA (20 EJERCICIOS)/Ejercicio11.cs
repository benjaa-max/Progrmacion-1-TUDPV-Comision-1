using System;
using System.Globalization;
using System.Threading;


class Program
{
    static void Main()
    {
        
        CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Puntos de salud (0 a 100): ");
        int salud = int.Parse(Console.ReadLine());

        if (salud <= 20)
        {
            Console.WriteLine("¡PELIGRO: Salud Crítica!");
        }
        else
        {
            Console.WriteLine("Estado de combate: Estable.");
        }

        Console.WriteLine();
        Console.WriteLine("Presioná una tecla para salir...");
        Console.ReadKey();
    }
}
