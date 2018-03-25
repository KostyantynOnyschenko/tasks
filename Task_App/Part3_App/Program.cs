using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics;

namespace Part3_App
{
    class Program
    {
        static void Main(string[] args)
        {
            One();
        }

        /// <summary>
        /// <para>Вычислить факториал введенного числа.</para>
        /// </summary>
        private static void One()
        {
            Console.WriteLine("-------------------------task number 1: ");
            Console.WriteLine("введите число: ");
            int dig = Int32.Parse(Console.ReadLine());           
            Console.WriteLine("Факториал введенного числа равен: " + SpecialFunctions.Factorial(dig));
            Console.ReadKey();

        }

    }
}
