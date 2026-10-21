using System;
using System.Globalization;
using System.Threading;


class Program
{
    static void Main()
    {
       
        CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

        int total = 0;

        for (int i = 1; i <= 5; i++)
        {
            Console.Write("Oro del cofre " + i + ": ");
            int oro = int.Parse(Console.ReadLine());
            total = total + oro;
        }

        Console.WriteLine("Total de oro acumulado: " + total);

        Console.WriteLine();
        Console.WriteLine("Presioná una tecla para salir...");
        Console.ReadKey();
    }
}
