using System;

/*
 Consigna

Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos (excluido el mismo) que son divisores del número.

El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.

Escribir una aplicación que encuentre los 4 primeros números perfectos.
 
 */



namespace Ejercicio_I04___Un_número_perfecto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numerosPerfectosEncontrados = 0;
            int posiblePerfecto = 2;
            while (numerosPerfectosEncontrados <= 4)
            {
                int sumatoriaDivisores = 0;
                for (int i = 1; i < posiblePerfecto; i++)
                {
                    if (posiblePerfecto%i == 0)
                    {
                        sumatoriaDivisores+=i;
                    }
                }
                if (sumatoriaDivisores == posiblePerfecto)
                {
                    Console.WriteLine($"Numero Perfecto {posiblePerfecto}");
                    numerosPerfectosEncontrados++;
                }
                    
                posiblePerfecto++;
            }
        }
    }
}
