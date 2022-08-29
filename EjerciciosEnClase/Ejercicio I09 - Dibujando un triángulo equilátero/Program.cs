using System;

namespace Ejercicio_I09___Dibujando_un_triángulo_equilátero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Introduce la altura del triangulo");
            if (int.TryParse(Console.ReadLine(), out int triangulo))
            {
                for (int i = 0; i < triangulo; i++)
                {
                    int j = 0;
                    int altura = triangulo-i;
                    while (altura > 0)
                    {
                        Console.Write(" ");
                        altura--;
                    }
                       
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
