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
        }

        /// <summary>
        /// <para>Вычислить значение выражения по формуле (1-tg x)^(ctg x)+ cos(x-y).</para>
        /// </summary>
        public static void One()
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
        }

    }
}
