using System;

namespace Ejercicio_I01___Maximo_Minimo_y_Promedio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeroIngresadoString;
            int numeroIngresado;
            int maximo = int.MinValue;
            int minimo = int.MaxValue;
            double promedioNumerosIngresados = 0F;

            for (int i = 0; i <5; i++)
            {
                Console.WriteLine($"Ingrese {i + 1}° valor");
                numeroIngresadoString = Console.ReadLine();
                if (int.TryParse(numeroIngresadoString, out numeroIngresado))
                {
                    if(numeroIngresado > maximo)
                        maximo = numeroIngresado;
                    if(numeroIngresado < minimo)
                        minimo = numeroIngresado;
                    promedioNumerosIngresados += numeroIngresado;
                }
                else
                {
                    i--;
                    Console.WriteLine("Valor Invalido");
                }
            }
            Console.WriteLine($"1. el maximo: {maximo}, el minimo: {minimo} y el promedio {promedioNumerosIngresados / 5}{Environment.NewLine}");
            //Console.WriteLine("2. el maximo: " + maximo + ", el minimo: " + minimo + " y el promedio " + promedioNumerosIngresados / 5 + Environment.NewLine);
            //Console.WriteLine("3. el maximo: {0}, el minimo: {1} y el promedio {2} {3}", maximo, minimo, promedioNumerosIngresados / 5, Environment.NewLine);
            //Console.WriteLine($"si fuera un precio se puede usar para la moneda: {promedioNumerosIngresados:C2}");

        }
    }
}
