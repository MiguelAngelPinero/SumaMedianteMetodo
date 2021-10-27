using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(calcular());
            Console.Read();
        }

        public static int calcular()
        {
            Console.WriteLine("Ingresa un número");
            string num1Imput = Console.ReadLine();

            Console.WriteLine("Ingresa otro número para sumarlo al anterior");
            string num2Imput = Console.ReadLine();

            int num1 = int.Parse(num1Imput);
            int num2 = int.Parse(num2Imput);

            int resultado = num1 + num2;

            Console.WriteLine("La suma de, " + num1Imput + " + " + num2Imput + " es: " + resultado);
            Console.Read();

            return resultado;
        }

    }
}
