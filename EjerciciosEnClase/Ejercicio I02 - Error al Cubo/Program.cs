using System;

namespace Ejercicio_I02___Error_al_Cubo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Ingrese Numero Mayor a 0");
                int.TryParse(Console.ReadLine(), out int numeroIngresado);
                if (numeroIngresado > 0)
                {
                    double cuadradoDelNumero = Math.Pow(numeroIngresado, 2);
                    double cuboDelNumero = Math.Pow(numeroIngresado, 3);
                    Console.WriteLine($"el numero ingresado: {numeroIngresado} su cuadrado es: {cuadradoDelNumero} y su cubo es: {cuboDelNumero}");
                    break;
                }
                Console.WriteLine($"Error Al Ingresar Valor{Environment.NewLine}");
            }while (true);


        }
    }
}
