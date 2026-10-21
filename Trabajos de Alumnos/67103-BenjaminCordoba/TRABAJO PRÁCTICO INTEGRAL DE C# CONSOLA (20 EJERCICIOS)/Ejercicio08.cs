using System;
using System.Globalization;
using System.Threading;


class Program
{
    static void Main()
    {
       
        CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Kills (bajas): ");
        int kills = int.Parse(Console.ReadLine());

        Console.Write("Deaths (muertes): ");
        int deaths = int.Parse(Console.ReadLine());

       
        float ratio = (float)kills / deaths;

        Console.WriteLine("Ratio K/D de la partida: " + ratio);

        Console.WriteLine();
        Console.WriteLine("Presioná una tecla para salir...");
        Console.ReadKey();
    }
}
