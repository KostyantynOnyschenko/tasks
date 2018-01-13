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
            Five();
            Eight();
            Nine();
            Ten();
            Eleven();
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
