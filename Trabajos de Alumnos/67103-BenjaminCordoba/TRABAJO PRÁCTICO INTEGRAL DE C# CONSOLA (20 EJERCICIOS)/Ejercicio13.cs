using System;
using System.Globalization;
using System.Threading;


class Program
{
    static void Main()
    {
    
        CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Nivel del jugador: ");
        int nivel = int.Parse(Console.ReadLine());

        Console.Write("Monedas de oro: ");
        int oro = int.Parse(Console.ReadLine());

        if (nivel >= 15 && oro >= 100)
        {
            Console.WriteLine("Acceso concedido al calabozo supremo.");
        }
        else
        {
            Console.WriteLine("Acceso rechazado: necesitás nivel 15+ y 100 monedas de oro.");
        }

        Console.WriteLine();
        Console.WriteLine("Presioná una tecla para salir...");
        Console.ReadKey();
    }
}
