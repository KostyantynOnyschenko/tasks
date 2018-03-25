using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTwoPart1_App
{
    class Program
    {
        static void Main(string[] args)
        {
            One();
            Seven();
        }

        /// <summary>
        /// <para>Вычислить значение выражения по формуле (1-tg x)^(ctg x)+ cos(x-y).</para>
        /// </summary>
        private static void One()
        {
            Console.WriteLine("-------------------------task number 1: ");
            Console.WriteLine("введите x: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("введите y: ");
            double y = double.Parse(Console.ReadLine());
            Console.Write("(1-tg x)^(ctg x)+ cos(x-y) = ");
            double ctg = 1 / Math.Tan(x);
            x = ((1 - Math.Tan(x) * Math.Pow(ctg, x)+ (Math.Cos(x) - Math.Cos(y))));
            Console.Write(x);
            Console.ReadKey();
            Console.ReadLine();
        }

        /// <summary>
        /// <para>Составить программу, которая на входе должна получать последовательность цифр</para>
        /// <para>после чего  программа показывает цифру, порядковый номер которой ввел пользователь.</para>
        /// </summary>
        private static void Two()
        {
            Console.WriteLine("-------------------------task number 2: ");
            Console.WriteLine("введите число: ");
            int numuser = int.Parse(Console.ReadLine());
            
            Console.ReadKey();
        }

        /// <summary>
        /// <para>Разработать функцию, в которую передаются в качестве аргументов массив типа float</para>
        /// <para>и его размер. Функция должна возвращать среднее арифметическое элементов массива.</para>
        /// </summary>
        private static void Five()
        {
            Console.WriteLine("-------------------------task number 5: ");
            float[] arr = new float[10];
            for (int i = 0; i < arr.Length; i++)
            {
                float aver = arr[i];
                
            }
        }


        /// <summary>
        /// <para>Программа проверяет, является ли введенное с клавиатуры число — целым числом.</para>
        /// </summary>
        private static void Six()
        {
            Console.WriteLine("-------------------------task number 6: ");
            Console.WriteLine("введите число: ");

        }

        /// <summary>
        /// <para>Составить программу, которая будет требовать ввод цифр с клавиатуры до тех пор</para>
        /// <para> пока не будет введена цифра 1.</para>
        /// </summary>
        private static void Seven()
        {
            Console.WriteLine("-------------------------task number 7: ");
            Console.WriteLine("введите число: ");
            for (;;)
            {
                int usnum = int.Parse(Console.ReadLine());
                if (usnum == 1) break;
                
            }
            Console.WriteLine("условие задачи выполнено");
            Console.ReadKey();        
        }

    }
}
