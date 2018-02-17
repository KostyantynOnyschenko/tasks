using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Task_App
{
    class Program
    {
        static void Main(string[] args)
        {
            First();
            Two();
            Three();
            Four();
            Five();
            Seven();
            Seven_VersionTwo();
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

        public static void Two()
        {
            Console.WriteLine("task number two: ");
            int a, b, c;
            a = 78;
            b = 56;
            c = 89;
            Console.WriteLine("three digital: " + a + " " + b + " " + c);
            if (a > b || a > c)
            {
                Console.WriteLine("max: " +  a);
            }
            else if (b > a || b > c)
            {
                Console.WriteLine("max: " + b);
            }
            else if (c > a || c > b)
            {
                Console.WriteLine("max: " + c);
            }
            
        }

        public static void TwoTwo()
        {
            Console.WriteLine("task number two: ");
            HashSet<int> somenumbers = new HashSet<int>();
            Random rnd = new Random();
            int[] arr = new int[3];
            int min, max;
            min = max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                int digital;
                do
                {
                    digital = rnd.Next(1, 100);

                } while (!somenumbers.Add(digital));
                arr[i] = digital;
                Console.WriteLine("three digital:\n ");
                Console.Write(arr[i] + " ");
                Console.Write(arr[i] + " ");
                if (digital > min)
                    max = digital;
                Console.WriteLine("max: " + max);

            }
        }

        public static void Three()
        {
            Console.WriteLine("task number three: ");
            int a = 3;
            int b = 4;
            int c = 2;
            int y, z, w;
            y = a + b;
            z = b + c;
            w = a + c;

            Console.WriteLine();
            if (y > z)
            {
                Console.WriteLine("big sum: a + b: " + y);
            }
            else
            {
                Console.WriteLine("big sum: a + c:" + w);
            }
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
            Console.WriteLine("вы ввели: " + one + ", " + two + ", " + three + ", " + four);
            if (one % 2 == 0)
            {
                Console.WriteLine("число четное: " + one);              
            }
            else
            {
                Console.WriteLine("число нечетное: " + one);
            }
            if (two % 2 == 0)
            {
                Console.WriteLine("число четное: " + two);
            }
            else
            {
                Console.WriteLine("число нечетное: " + two);
            }
            if (three % 2 == 0)
            {
                Console.WriteLine("число четное: " + three);
            }
            else
            {
                Console.WriteLine("число нечетное: " + three);
            }
            if (four % 2 == 0)
            {
                Console.WriteLine("число четное: " + four);
            }
            else
            {
                Console.WriteLine("число нечетное: " + four);
            }            
            Console.WriteLine("поиск наибольшего четного числа: ");
            int one_1 = one;
            int two_1 = two;
            int three_1 = three;
            int four_1 = four;
            if (one_1 == two_1 || one_1 == three_1 || one_1 == four_1)
            {
                Console.WriteLine("нет наибольшего");
            }
            else
            {
                Console.WriteLine("Наибольшее четное: " + Math.Max(one_1, Math.Max(two_1, Math.Max(three_1, four_1))));
            }
            

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
            number = 3569;
            Console.WriteLine("number: " + number);
            int a, b, c, d;
            a = 3;
            b = 5;
            c = 6;
            d = 9;
            if (a == b)
            {
                Console.WriteLine("a equal b");
            }
            else
            {
                Console.WriteLine("a not equal b");
            }
            if (c == d)
            {
                Console.WriteLine("c equal b");
            }
            else
            {
                Console.WriteLine("c not equal d");
            }
            if (a == c)
            {
                Console.WriteLine("a equal c");
            }
            else
            {
                Console.WriteLine("a not equal c");
            }
            if (b == d)
            {
                Console.WriteLine("b equal d");
            }
            else
            {
                Console.WriteLine("b not equal d");
            }
            if (a == d)
            {
                Console.WriteLine("a equal d");
            }
            else
            {
                Console.WriteLine("a not equal d");
            }
            if (b == c)
            {
                Console.WriteLine("b equal c");
            }
            else
            {
                Console.WriteLine("b not equal c");
                Console.WriteLine("number " + number + " don't have sample");
            }

        }

        public static void Seven_VersionTwo()
        {
            Console.WriteLine("task number 7 (version solution 2): ");
            int number;
            number = 3425;
            Console.WriteLine("number " + number);
            int a, b, c, d;
            a = 3;
            b = 4;
            c = 2;
            d = 5;
            if (a == b)
            {
                Console.WriteLine("a equal b");
                if (c == d)
                {
                    Console.WriteLine("c equal d");
                    if (a == c)
                    {
                        Console.WriteLine("a equal c");
                        if (b == d)
                        {
                            Console.WriteLine("b equal d");
                            if (a == d)
                            {
                                Console.WriteLine("a equal d");
                                if (b == c)
                                {
                                    Console.WriteLine("b equal c");
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("number " + number + " don't have sample nums");
            }
        }

        public static void Eight()
        {
            Console.WriteLine("task number 8: ");
            for (int i = 1; i < 21; i++)
            {
                Console.Write(i + " ");
            }
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
            Console.ReadLine();
        }
        
        
    }
}
