using System;
using System.Globalization;
using System.Threading;


class Program
{
    static void Main()
    {
       
        CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Nombre del clan: ");
        string clan = Console.ReadLine();

        Console.Write("Nombre del líder: ");
        string lider = Console.ReadLine();

        Console.Write("Cantidad de miembros activos: ");
        int miembros = int.Parse(Console.ReadLine());

        Console.Write("¿El clan es público? (s/n): ");
        string respuesta = Console.ReadLine();
        bool esPublico = (respuesta == "s");

        Console.WriteLine();
        Console.WriteLine("===== FICHA OFICIAL DEL CLAN =====");
        Console.WriteLine("Clan: " + clan);
        Console.WriteLine("Líder: " + lider);
        Console.WriteLine("Miembros activos: " + miembros);
        Console.WriteLine("Público: " + esPublico);
        Console.WriteLine("==================================");

        Console.WriteLine();
        Console.WriteLine("Presioná una tecla para salir...");
        Console.ReadKey();
    }
}
