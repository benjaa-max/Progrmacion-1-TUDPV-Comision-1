using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== ÍTEM A: MONEDAS POR NIVEL ===");

        int[] monedas = new int[4];

        for (int i = 0; i < 4; i++)
        {
            Console.Write("Monedas obtenidas en el nivel " + (i + 1) + ": ");
            monedas[i] = int.Parse(Console.ReadLine());

            if (monedas[i] > 50)
            {
                monedas[i] = monedas[i] + 10;
                Console.WriteLine("¡Bonus de 10 monedas para el nivel " + (i + 1) + "!");
            }
        }

        int total = 0;

        Console.WriteLine();
        Console.WriteLine("Lista definitiva de monedas:");
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine("Nivel " + (i + 1) + ": " + monedas[i] + " monedas");
            total = total + monedas[i];
        }

        Console.WriteLine("Total acumulado: " + total + " monedas");

        Console.WriteLine();
        Console.WriteLine("Presioná una tecla para salir...");
        Console.ReadKey();
    }
}
