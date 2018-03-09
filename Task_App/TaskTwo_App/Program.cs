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
        }

        /// <summary>
        /// <para>Программа должна переводить число, введенное с клавиатуры с метра в километры.</para>
        /// </summary>
        public static void Two()
        {
            Console.WriteLine("task number 2: ");
            Console.WriteLine("write meters: ");
            double n = Int32.Parse(Console.ReadLine());
            Console.WriteLine(n + " meters");
            double km;
            km = n / 1000;
            Console.Write(km + " km");
            Console.ReadKey();         
        }
    }
}
