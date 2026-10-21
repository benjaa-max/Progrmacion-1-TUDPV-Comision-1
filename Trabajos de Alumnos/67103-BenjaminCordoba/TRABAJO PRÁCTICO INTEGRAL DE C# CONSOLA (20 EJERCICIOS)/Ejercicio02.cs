using System;
using System.Globalization;
using System.Threading;

class Program
{
    static void Main()
    {
       
        CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

        int vida = 120;

        Console.Write("Daño del ataque enemigo: ");
        int dano = int.Parse(Console.ReadLine());

        int vidaFinal = vida - dano;

        Console.WriteLine("Salud restante tras el impacto: " + vidaFinal + " HP");

        Console.WriteLine();
        Console.WriteLine("Presioná una tecla para salir...");
        Console.ReadKey();
    }
}
