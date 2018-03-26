using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Two();
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
            Console.ReadLine();
        }


    }
}
