using System;
using System.Globalization;
using System.Threading;


class Program
{
    static void Main()
    {
    
        CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

        int vidaBoss = 80;

        while (vidaBoss > 0)
        {
            Console.Write("Daño de tu golpe: ");
            int dano = int.Parse(Console.ReadLine());

            vidaBoss = vidaBoss - dano;

            if (vidaBoss < 0)
            {
                vidaBoss = 0; 
            }

            Console.WriteLine("Vida restante del Boss: " + vidaBoss);
        }

        Console.WriteLine("¡VICTORIA! Derrotaste al Jefe.");

        Console.WriteLine();
        Console.WriteLine("Presioná una tecla para salir...");
        Console.ReadKey();
    }
}
