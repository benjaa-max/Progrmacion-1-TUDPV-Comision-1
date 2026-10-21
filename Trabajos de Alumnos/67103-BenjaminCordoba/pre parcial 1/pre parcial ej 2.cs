using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== ÍTEM B: SELECTOR DE ATAQUE ===");

        List<int> balas = new List<int>();
        balas.Add(10);
        balas.Add(5);
        balas.Add(15);

        int opcion = -1;

        while (opcion != 0)
        {
            Console.WriteLine();
            Console.WriteLine("Balas disponibles:");
            Console.WriteLine("Arma 1 (Pistola): " + balas[0] + " balas");
            Console.WriteLine("Arma 2 (Escopeta): " + balas[1] + " balas");
            Console.WriteLine("Arma 3 (Rifle): " + balas[2] + " balas");

            Console.WriteLine();
            Console.WriteLine("¿Con qué arma querés disparar?");
            Console.WriteLine("1: Pistola | 2: Escopeta | 3: Rifle | 0: Salir");
            Console.Write("Opción: ");
            opcion = int.Parse(Console.ReadLine());

            if (opcion == 1 || opcion == 2 || opcion == 3)
            {
                int indice = opcion - 1;

                if (balas[indice] > 0)
                {
                    balas[indice] = balas[indice] - 1;
                    Console.WriteLine("¡Disparo realizado! Te quedan " + balas[indice] + " balas en esa arma.");
                }
                else
                {
                    Console.WriteLine("¡Sin balas! No se puede disparar con esta arma.");
                }
            }
            else if (opcion == 0)
            {
                Console.WriteLine("Saliendo del selector de armas...");
            }
            else
            {
                Console.WriteLine("Opción inválida.");
            }
        }

        Console.WriteLine();
        Console.WriteLine("Presioná una tecla para salir...");
        Console.ReadKey();
    }
}
