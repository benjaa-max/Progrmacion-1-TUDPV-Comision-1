using System;
using System.Globalization;
using System.Threading;


class Program
{
    static void Main()
    {
        
        CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

        int expNecesaria = 500;

        Console.Write("EXP actual: ");
        int expActual = int.Parse(Console.ReadLine());

        float porcentaje = (float)expActual / expNecesaria * 100;

        Console.WriteLine("Progreso de la barra de nivel: " + porcentaje + "%");

        Console.WriteLine();
        Console.WriteLine("Presioná una tecla para salir...");
        Console.ReadKey();
    }
}
