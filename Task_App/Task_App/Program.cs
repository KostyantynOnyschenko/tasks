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
            //Ten();
        }

        public static void Eight()
        {
            for (int i = 1; i < 21; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }

        public static void Ten()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
