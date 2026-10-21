using System;
using System.Globalization;
using System.Threading;


class Program
{
    static void Main()
    {
      
        CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

        string clave = "";

        while (clave != "EXCALIBUR")
        {
            Console.Write("Ingresá la contraseña mágica: ");
            clave = Console.ReadLine();

            if (clave != "EXCALIBUR")
            {
                Console.WriteLine("Clave incorrecta. Intentá de nuevo.");
            }
        }

        Console.WriteLine("¡Clave correcta! Bienvenido al portal VIP.");

        Console.WriteLine();
        Console.WriteLine("Presioná una tecla para salir...");
        Console.ReadKey();
    }
}
