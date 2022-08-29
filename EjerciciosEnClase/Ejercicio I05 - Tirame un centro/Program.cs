using System;

namespace Ejercicio_I05___Tirame_un_centro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese Numero Para buscar los centros Numericos");
            int.TryParse(Console.ReadLine(), out int numeroFinal);
            while (numeroFinal > 1)
            {
                int sumatoria = 0;
                for (int i = 1; i < numeroFinal; i++)
                {
                    sumatoria += i;
                    if (i == numeroFinal-1)
                    {
                        int numeroARestar = numeroFinal + 1;
                        while (sumatoria > 0)
                        {
                            sumatoria -= numeroARestar;
                            numeroARestar++;
                            if (sumatoria == 0)
                                Console.WriteLine($"centro Numerico Encontrado: {numeroFinal}");
                        }
                    }

                }
                numeroFinal--;
            }
        }
    }
}
