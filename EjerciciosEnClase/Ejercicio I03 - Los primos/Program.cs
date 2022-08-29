using System;

namespace Ejercicio_I03___Los_primos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Consigna

Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.
Validar que el dato ingresado por el usuario sea un número.
Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".
Si ingresa "salir", cerrar la consola.
Al finalizar, preguntar al usuario si desea volver a operar. Si la respuesta es afirmativa, iterar. De lo contrario, cerrar la consola.
             */
            string continuar;

            do
            {
                Console.WriteLine("Ingrese Numero Entero para Calcular Valores Primos o salir para salir del sistema");
                continuar = Console.ReadLine().ToLower();
                int.TryParse(continuar, out int numeroIngresado);
                if (numeroIngresado > 0)
                {
                    if (numeroIngresado == 1)
                    {
                        Console.WriteLine("No hay Numeros Primos");
                    }
                    else
                    {
                        for (int i = 2; i <=numeroIngresado; i++)
                        {
                            int divisores = 0;
                            for (int j = 1; j <=i; j++)
                            {
                                if ((i % j) == 0)
                                divisores++;
                            }
                            if (divisores <= 2)
                                Console.WriteLine($"Numero Primo: {i}");
                        }
                    }
                    Console.WriteLine("Presione S si desea probar otro numero o cualquier otra tecla si desea salir");
                    if(Console.ReadLine().ToLower() != "s")
                    {
                        continuar = "salir";
                    }
                }
                else if (continuar != "salir")
                {
                    Console.WriteLine("Dato Introducido Invalido, Escriba salir si desea salir del sistema");
                    continuar = Console.ReadLine().ToLower();
                }

            }while (continuar != "salir");
        }
    }
}
