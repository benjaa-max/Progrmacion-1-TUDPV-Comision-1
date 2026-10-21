using System;
using System.Globalization;
using System.Threading;


class Program
{
    static void Main()
    {
       
        CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Puntos de la etapa 1: ");
        int p1 = int.Parse(Console.ReadLine());

        Console.Write("Puntos de la etapa 2: ");
        int p2 = int.Parse(Console.ReadLine());

        Console.Write("Puntos de la etapa 3: ");
        int p3 = int.Parse(Console.ReadLine());

        float promedio = (p1 + p2 + p3) / 3f;

        Console.WriteLine("Puntaje promedio obtenido: " + promedio + " puntos");

        Console.WriteLine();
        Console.WriteLine("Presioná una tecla para salir...");
        Console.ReadKey();
    }
}
