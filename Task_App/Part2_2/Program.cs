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
        /// <para>Все элементы массива поделить на значение наибольшего элемента этого массива.</para>
        /// </summary>
        private static void One()
        {
            Console.WriteLine("-------------------------task number 1: ");
            int[] arr = { 1, 5, 6, 4, 9, 21, 12, 9, 45, 47, 46, 79, 23 };
            int min, max;
            min = max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
                if (arr[i] > max) max = arr[i];
                if (arr[i] < min) min = arr[i];
                double result = arr[i] / max;
                Console.WriteLine();
                Console.WriteLine(result);
            }
            Console.WriteLine("max: " + max + " min: " + min);

            Console.ReadLine();
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
        /// <para>Дан одномерный массив. Найти среднее арифметическое его элементов. 
        /// Вывести на экран только те элементы массива, 
        /// которые больше найденного среднего арифметического.</para>
        /// </summary>
        private static void Seven()
        {
            Console.WriteLine("-------------------------task number 7: ");
            int[] arr = { 1, 5, 6, 4, 9, 21, 12, 9, 5, 47, 46, 79, 23 };
            for (int i = 0; i < arr.Length; i++)
            {
                
            }
            Console.ReadLine();
        }


        /// <summary>
        /// <para>Написать функцию, которая возвращает среднее арифметическое 
        /// двух переданных ей аргументов (параметров).</para>
        /// </summary>
        private static void Eight()
        {
            Console.WriteLine("-------------------------task number 8: ");
            Console.WriteLine("введите первое число: ");
            double x = Double.Parse(Console.ReadLine());
            Console.WriteLine("введите второе число: ");
            double y = Double.Parse(Console.ReadLine());
            double c = (x + y) / 2;
            Console.WriteLine("среднее арифметическое: " + c);
            Console.ReadKey();
        }


    }
}
