using System;
using System.Globalization;
using System.Threading;


class Program
{
    static void Main()
    {
       
        CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

        int precioPocion = 30;

        Console.Write("¿Cuánto oro tenés?: ");
        int oro = int.Parse(Console.ReadLine());

        int pociones = oro / precioPocion;   
        int sobrante = oro % precioPocion;   

        Console.WriteLine("Pociones compradas: " + pociones);
        Console.WriteLine("Oro sobrante: " + sobrante + " monedas");

        Console.WriteLine();
        Console.WriteLine("Presioná una tecla para salir...");
        Console.ReadKey();
    }
}
