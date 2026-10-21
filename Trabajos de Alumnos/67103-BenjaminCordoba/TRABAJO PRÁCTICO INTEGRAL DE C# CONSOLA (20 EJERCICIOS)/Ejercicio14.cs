using System;
using System.Globalization;
using System.Threading;


class Program
{
    static void Main()
    {
        
        CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("=== DIFICULTAD ===");
        Console.WriteLine("1: Fácil");
        Console.WriteLine("2: Normal");
        Console.WriteLine("3: Difícil");
        Console.Write("Elegí la dificultad: ");
        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.WriteLine("Dificultad Fácil: enemigos con 50 HP.");
                break;
            case 2:
                Console.WriteLine("Dificultad Normal: enemigos con 100 HP.");
                break;
            case 3:
                Console.WriteLine("Dificultad Difícil: enemigos con 200 HP y velocidad x2.");
                break;
            default:
                Console.WriteLine("Opción inválida.");
                break;
        }

        Console.WriteLine();
        Console.WriteLine("Presioná una tecla para salir...");
        Console.ReadKey();
    }
}
