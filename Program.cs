using System;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables
            decimal num1, num2, resultado = 0.0M;//le ponemos M para inicializarla en decimal
            byte opcion;

            //Menu
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicacion");
            Console.WriteLine("4. Division");
            Console.WriteLine("Escoge una opcion: ");
            opcion = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Dame el numero uno: ");
            num1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Dame el numero dos: ");
            num2 = Convert.ToDecimal(Console.ReadLine());

           
            switch (opcion)
            {
                case 1:
                    resultado = num1 + num2;
                    break;
                case 2:
                    resultado = num1 - num2;
                    break;
                case 3:
                    resultado = num1 * num2;
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                    }
                    else 
                    {
                        Console.WriteLine("No se puede dividir entre 0 ");
                    }
                  
                    break;

                default:
                    Console.WriteLine("Ingresa un opcion valida");
                    break;

                    



            }
           
            Console.WriteLine("El resultado de tu operacion es: {0}", resultado);
            Console.WriteLine("El resultado de tu operacion es: {0}", resultado);

        }
    }
}
