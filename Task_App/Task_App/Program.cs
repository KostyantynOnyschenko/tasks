using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_App
{
    class Program
    {
        static void Main(string[] args)
        {
            First();
            Five();
            Eight();
            Nine();
            Ten();
            Eleven();
        }

        public static void First()
        {
            Console.WriteLine("task number 1: ");
            bool simple = true;
            Console.WriteLine("enter the numer:\n");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n/n; i++)
            {
                if (n % i == 0)
                {
                    simple = false;
                    break;
                }
            }
            if (simple)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            Console.ReadKey();
        }

        public static void Four()
        {
            Console.WriteLine("task number 4: ");
            Console.WriteLine("введите первое число: ");
            int one = int.Parse(Console.ReadLine());
            Console.WriteLine("введите второе число: ");
            int two = int.Parse(Console.ReadLine());
            Console.WriteLine("введите третье число: ");
            int three = int.Parse(Console.ReadLine());
            Console.WriteLine("введите четвертое число: ");
            int four = int.Parse(Console.ReadLine());

            Console.ReadKey();
        }

        public static void Five()
        {
            Console.WriteLine();
            Console.WriteLine("task number 5: ");
            int a = 5;
            int b = 6;
            int c = 5;
            if (a == b)
            {
                Console.WriteLine("no");
            }
            else
            {
                Console.WriteLine("yes");
            }
        }

        public static void Seven()
        {
            Console.WriteLine("task number 7: ");
            int number;

        }

        public static void Eight()
        {
            Console.WriteLine("task number 8: ");
            for (int i = 1; i < 21; i++)
            {
                Console.Write(i + " ");
            }
            //Console.ReadLine();
        }

        public static void Nine()
        {
            Console.WriteLine();
            Console.WriteLine("task number 9: ");
            for (int i = 1001; i < 1026; i += 3)
            {
                Console.Write(i + " ");
            }
        }

        public static void Ten()
        {
            Console.WriteLine();
            Console.WriteLine("task number 10: ");
            for (int i = 100; i > 0; i-=4)
            {
                Console.Write(i + " ");
            }
            //Console.ReadLine();
        }

        public static void Eleven()
        {
            Console.WriteLine();
            Console.WriteLine("task number 11: ");
            Random rnd = new Random();
            HashSet<int> somenumb = new HashSet<int>();
            int[] arr = new int[3];
            for (int i = 0; i < arr.Length; i++)
            {
                int num;
                do
                {
                    num = rnd.Next(100);
                } while (!somenumb.Add(num));
                arr[i] = num;
                Console.Write(arr[i] + " ");
            }
            /*int[] a = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Random rnd = new Random();
                a[i] = rnd.Next(1, 100);
                Console.Write(a[i] + " ");
            }*/
            Console.ReadLine();
        }
        
        
    }
}
