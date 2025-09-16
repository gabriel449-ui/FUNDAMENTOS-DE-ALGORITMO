using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA_4_C_
{
    internal class ejer4
    {
        static void Main(string[] args)
        {
            Console.Write("bienvenidos al calculo de areas\n");
            Console.WriteLine("1. cuadrado");
            Console.WriteLine("2. rectangulo");
            Console.WriteLine("3. triangulo");
            Console.WriteLine("4. circulo");
            Console.Write("\ningrese una opcion: ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1: 
                    Console.Write("\ningrese un lado": );
                    int lado = int.Parse(Console.ReadLine());
                    Console.WriteLine("\narea: " + (lado * lado));
                    break;
                case 2: 
                    Console.Write("\ningrese la base: ");
                    int bse = int.Parse(Console.ReadLine());
                    Console.Write("ingrese la altura");
                    int alt = int.Parse(Console.ReadLine());
                    Console.WriteLine("\narea: " + (bse * alt));
                    break;
                case 3:
                    Console.Write("\ningrese la base: ");
                    int bse2 = int.Parse(Console.ReadLine());
                    Console.Write("ingrese la altura");
                    int alt2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("\narea: " + ((bse2 * alt2)/2)); 
                    break;
                case 4:
                    Console.Write("\ningrese la radio: ");
                    double radio = double.Parse(Console.ReadLine());
                    Console.WriteLine("\narea: " + Math.Round(Math.PI * (radio * radio),2));
                    break;
                default: Console.WriteLine("\nopcion incorrecta"); break;
            }
            Console.ReadKey();
        }
    }
}
