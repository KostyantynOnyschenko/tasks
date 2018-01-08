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
            Eight();
            Ten();
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

        public static void Ten()
        {
            Console.WriteLine();
            Console.WriteLine("task number 10: ");
            for (int i = 100; i > 0; i-=4)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();
        }
    }
}
