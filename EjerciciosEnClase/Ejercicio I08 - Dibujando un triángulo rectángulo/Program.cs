using System;

namespace Ejercicio_I08___Dibujando_un_triángulo_rectángulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int triangulo;
            Console.WriteLine("Introduce la altura del triangulo");
            if (int.TryParse(Console.ReadLine(), out triangulo))
            {
                for (int i = 0; i < triangulo; i++)
                {
                    int j = 0;

                    while (j < i)
                    {
                        Console.Write("*");
                        Console.Write("*");
                        j++;
                    }
                    Console.WriteLine("*");
                }


            }

        }
    }
}
