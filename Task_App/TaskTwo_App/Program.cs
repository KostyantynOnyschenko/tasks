using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTwo_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Two();
            Three();
        }

        /// <summary>
        /// <para>Программа должна переводить число, введенное с клавиатуры с метра в километры.</para>
        /// </summary>
        public static void Two()
        {
            Console.WriteLine("-------------------------task number 2: ");
            Console.WriteLine("write meters: ");
            double n = Int32.Parse(Console.ReadLine());
            Console.WriteLine(n + " meters");
            double km;
            km = n / 1000;
            Console.Write(km + " km");
            Console.ReadKey();
            Console.ReadLine();
        }

        /// <summary>
        /// <para>Составить программу, которая требует ввести два числа.</para>
        /// <para> Если первое число больше второго, то программа печатает слово больше. </para>
        /// <para>Если первое число меньше второго, то программа печатает слово меньше. </para>
        /// <para>А если числа равны, программа напечатает сообщение Эти числа равны.</para>
        /// </summary>
        public static void Three()
        {
            Console.WriteLine("-------------------------task number 3: ");
            Console.WriteLine("write digital number 1: ");
            int n_1 = int.Parse(Console.ReadLine());
            Console.WriteLine("write digital number 2: ");
            int n_2 = Int32.Parse(Console.ReadLine());
            if (n_1 > n_2)
            {
                Console.WriteLine("first digital larger");
            }
            else if (n_1 < n_2)
            {
                Console.WriteLine("second digital larger");
            }
            else
            {
                Console.WriteLine("this diital equal");
            }
            Console.ReadKey();
        }

    }
}
