using System;
using System.Globalization;
using System.Threading;


class Program
{
    static void Main()
    {
       
        CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Segundos jugados: ");
        int segundosTotales = int.Parse(Console.ReadLine());

        int minutos = segundosTotales / 60;
        int segundos = segundosTotales % 60;

        Console.WriteLine("Tiempo registrado: " + minutos + " min " + segundos + " seg");

        Console.WriteLine();
        Console.WriteLine("Presioná una tecla para salir...");
        Console.ReadKey();
    }
}
