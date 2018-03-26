using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet;

namespace Part2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Two();
            Eight();
        }

        /// <summary>
        /// <para>В массиве найти минимальный и максимальный элементы, поменять их местами.</para>
        /// </summary>
        private static void Two()
        {
            Console.WriteLine("-------------------------task number 2: ");
            int[] arr = {1, 5, 6, 4, 9, 21, 12, 9, 945, 47, 46, 79, 23};
            int min, max;
            min = max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
                if (arr[i] > max) max = arr[i];
                if (arr[i] < min) min = arr[i];
            }
            Console.WriteLine();
            Console.WriteLine("max: " + max + " min: " + min);
            Console.ReadLine();
        }

        /// <summary>
        /// <para>Обменять значения двух переменных, используя третью (буферную) переменную</para>
        /// </summary>
        private static void Three()
        {
            Console.WriteLine("-------------------------task number 3: ");
            int a = 2;
            int b = 5;
            int c;
            Console.WriteLine("a = " + a + " b = " + b);
            c = a;
            b = c;
            c = b;
            a = c;
            Console.WriteLine("b = " + b + " a = " + a);
            Console.ReadLine();
        }

        /// <summary>
        /// <para>Написать функцию, которая возвращает среднее арифметическое 
        /// двух переданных ей аргументов (параметров).</para>
        /// </summary>
        private static void Eight()
        {
            Console.WriteLine("-------------------------task number 8: ");
            double a = Double.Parse(Console.ReadLine());
            double b = Double.Parse(Console.ReadLine());
            double c;
            //c = a + b / 2;
            //Console.WriteLine("среднее арифметическое: " + c);
            Console.ReadKey();
        }


    }
}
