using System;
using System.Globalization;
using System.Threading;


class Program
{
    static void Main()
    {
        
        CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("=== MENÚ DE COMBATE ===");
        Console.WriteLine("1: Ataque Físico");
        Console.WriteLine("2: Magia Elemental");
        Console.WriteLine("3: Defender");
        Console.WriteLine("4: Huir");
        Console.Write("Elegí una opción: ");
        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.WriteLine("¡Lanzás un ataque físico!");
                break;
            case 2:
                Console.WriteLine("¡Invocás magia elemental!");
                break;
            case 3:
                Console.WriteLine("Te preparás para defender.");
                break;
            case 4:
                Console.WriteLine("Huís del combate...");
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
