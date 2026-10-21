using System;
using System.Globalization;
using System.Threading;


class Program
{
    static void Main()
    {
       
        CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Nickname: ");
        string nick = Console.ReadLine();

        Console.Write("Clase preferida: ");
        string clase = Console.ReadLine();

        Console.Write("Nivel inicial: ");
        int nivel = int.Parse(Console.ReadLine());

        Console.WriteLine("Héroe: " + nick + " | Clase: " + clase + " | Nivel: " + nivel);

        Console.WriteLine();
        Console.WriteLine("Presioná una tecla para salir...");
        Console.ReadKey();
    }
}
