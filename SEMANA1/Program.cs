using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejer5();
            Console.ReadKey();
        }
        static void ejer1()
        {
            string nombre, carrera;
            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese su carrera: ");
            carrera = Console.ReadLine();
            Console.WriteLine($"\n{nombre}, bienvenidos al curso de fundamentos de algoritmo de la carrera {carrera}");

        }
        static void ejer2()
        {
            Console.WriteLine("\"Gabriel\"");
        }
        static void ejer3()
        {
            Console.Write("Ingrese numero 1: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese numero 2: ");
            int num2 = int.Parse(Console.ReadLine());

            double divi = (double)num1 / (double)num2;

            Console.WriteLine("suma: "+(num1+num2));
            Console.WriteLine("resta: " + (num1 - num2));
            Console.WriteLine("multiplicacion: " + (num1 * num2));
            Console.WriteLine("division: " + divi);
            Console.ReadKey();
        }
        static void ejer4()
        {
            Console.Write("ingrese un numero decimal: ");
            double num = double.Parse(Console.ReadLine());

            double raiz = Math.Sqrt(num);
            double redo = Math.Round(num, 2);
            double cubo = Math.Pow(num, 3);
            double cubica = Math.Pow(num, 1/3d);

            Console.WriteLine("raiz cuadrada: " + raiz);
            Console.WriteLine("redondeado: " + redo);
            Console.WriteLine("elevado a la 3: " + cubo);
            Console.WriteLine("raiz cubica: " + cubica);
            Console.ReadKey();
        }
        static void ejer5()
        {
            Console.WriteLine("Ingrese un numero: ");
            string num = Console.ReadLine();

            int entero = int.Parse(num);
            double deci = double.Parse(num);

            Console.WriteLine("resto: " + (entero % 2));
            Console.WriteLine("decimal: " + (deci / 3));
            Console.ReadKey();
        }
        static void ejer6()
        {

        }
    }
}
