using System;

namespace Ejercicio_I07___Recibo_de_sueldo
{
    internal class Program
    {
        /*Se debe pedir el ingreso por teclado del valor hora, el nombre, la antigüedad (en años) 
         * y la cantidad de horas trabajadas en el mes de N cantidad de empleados de una fábrica.

        Se pide calcular el importe a cobrar teniendo en cuenta que el total (que resulta de multiplicar el valor hora
        por la cantidad de horas trabajadas), hay que sumarle la cantidad de años trabajados multiplicados por $150, 
        y al total de todas esas operaciones restarle el 13% en concepto de descuentos.

        Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar en bruto 
        y el total a cobrar neto de todos los empleados ingresados. 
         */
        static void Main(string[] args)
        {
            string otroDato;
            do
            {
                bool datoValido;
                decimal totalEnMano;
                decimal totalBruto;
                decimal precioHora;
                int cantidadHoras;
                int antiguedadAnios;
                Console.WriteLine("Ingrese Nombre");
                string nombreEmpleado = Console.ReadLine();
                do
                {
                    Console.WriteLine("Ingrese Valor Hora");
                    datoValido = decimal.TryParse(Console.ReadLine(), out precioHora);
                } while (!datoValido);
                do
                {
                    Console.WriteLine("Ingrese Cantidad Horas (Entero)");
                    datoValido = int.TryParse(Console.ReadLine(), out cantidadHoras);

                } while (!datoValido);
                do
                {
                    Console.WriteLine("Ingrese antiguedad (anios)");
                    datoValido = int.TryParse(Console.ReadLine(), out antiguedadAnios);
                } while (!datoValido);

                totalBruto = (precioHora * cantidadHoras) + (antiguedadAnios*150);
                totalEnMano = totalBruto - (totalBruto * 13/100);

                Console.WriteLine($"Empleado: {nombreEmpleado}, antiguedad {antiguedadAnios} años, horas trabajadas {cantidadHoras}, valor hora: {precioHora}");
                Console.WriteLine($"Sueldo Bruto: {totalBruto:C2} en mano cobra: {totalEnMano:C2}");
                
                Console.WriteLine("Ingrese s si desea ingresar otro");
                otroDato = Console.ReadLine().ToLower();
            } while (otroDato == "s");
            Console.ReadKey();
            Console.Clear();
            

        }
    }
}
