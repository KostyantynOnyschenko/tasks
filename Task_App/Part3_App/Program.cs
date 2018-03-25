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
            Three();
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

        /// <summary>
        /// <para>Сгенерировать 20 случайных целых чисел в диапазоне от -5 до 4, записать их в ячейки массива.</para>
        /// <para>Посчитать сколько среди них положительных, отрицательных и нулевых значений.  </para>
        /// <para>Вывести на экран элементы массива и посчитанные количества.</para>
        /// </summary>
        private static void Three()
        {
            Console.WriteLine("-------------------------task number 3: ");
            Random r = new Random();
            HashSet<int> hs = new HashSet<int>();
            int[] arr = new int[9];
            for (int i = 0; i < arr.Length; i++)
            {
                int num;
                do
                {
                    num = r.Next(-5, 4);
                } while (!hs.Add(num));
                arr[i] = num;
                Console.Write(arr[i] + " ");
            }
            Console.ReadLine();
        }



        /// <summary>
        /// <para>Написать функцию, которая заполняет массив случайными числами в диапазоне</para>
        /// <para>указанном пользователем. </para>
        /// <para>Функция должна принимать два аргумента - начало диапазона и его конец.</para>
        /// </summary>
        private static void Eleven()
        {
            Console.WriteLine("-------------------------task number 11: ");
            Console.WriteLine("введите начало диапазона: ");
            int begin = Int32.Parse(Console.ReadLine());
            Console.WriteLine("введите конец диапазона: ");
            int end = Int32.Parse(Console.ReadLine());
             
        }

    }
}
