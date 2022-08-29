using System;

namespace Ejercicio_I06___Años_bisiestos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese Año Inicio");
            int.TryParse(Console.ReadLine(), out int anioInicio);
            Console.WriteLine("Ingrese Año Inicio");
            int.TryParse(Console.ReadLine(), out int anioFin);

            while (anioFin >= anioInicio)
            {
                if ((anioInicio%4 == 0 && anioInicio % 100 != 0) || (anioInicio % 100 == 0 && anioInicio % 400 == 0))
                    Console.WriteLine($"Es Biciesto: {anioInicio}");
                anioInicio++;
            }
        }
    }
}
