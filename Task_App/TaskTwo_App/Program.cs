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
            One();
            Two();
            Three();
            Four();
            Five();
        }

        /// <summary>
        /// <para>Напишите программу, которая позволяет пользователю ввести в консоли латинскую букву нижнего регистра, </para>
        /// <para> переводит её в верхний регистр и результат выводит в консоль.</para>
        /// </summary>
        public static void One()
        {
            Console.WriteLine("-------------------------task number 1:");
            Console.WriteLine("write litera: ");
            char s = Char.Parse(Console.ReadLine());
            string q = s.ToString();
            //вписанная пользователем буква в любом случае перейдет в нижний регистр по условию
            Console.WriteLine("litera: " + q.ToLower());
            string w;
            w = s.ToString();
            //результат с верхним регистром
            Console.WriteLine("result: " + w.ToUpper());
            Console.ReadKey();
            Console.ReadLine();

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
            Console.ReadLine();
        }

        /// <summary>
        /// <para>Составить алгоритм увеличения всех трех, введённых с клавиатуры</para>
        /// <para>переменных на 5,если среди них есть хотя бы две равные.  </para>
        /// <para>В противном случае выдать ответ </para>
        /// </summary>
        public static void Four()
        {
            Console.WriteLine("-------------------------task number 4: ");
            Console.WriteLine("write first digital: ");
            int x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("write second digital: ");
            int y = Int32.Parse(Console.ReadLine());
            Console.WriteLine("write third digital: ");
            int z = Int32.Parse(Console.ReadLine());
            Console.WriteLine("search equal digital: ");
            //проверка на наличие хотя бы двух равных чисел
            if (x == y || y == z || x == z)
            {
                x += 5;
                y += 5;
                z += 5;
                Console.WriteLine("x after search: " + x);
                Console.WriteLine("y after search: " + y);
                Console.WriteLine("z after search: " + z);
            }
            else
            {
                Console.WriteLine("no equal");
            }
            Console.ReadKey();            
        }

        /// <summary>
        /// <para>В зависимости от выбора пользователя вычислить</para>
        /// <para>площадь круга, прямоугольника или треугольника.  </para>
        /// <para>Для вычисления площади каждой фигуры должна быть написана отдельная функция.</para>
        /// </summary>
        public static void Five()
        {
            Console.WriteLine("-------------------------task number 5: ");
            Console.WriteLine("выберите какую площадь вычислить: ");
            Console.WriteLine("1 - треугольника");
            Console.WriteLine("2 - прямоугольника");
            Console.WriteLine("3 - круга");
            int i = Int32.Parse(Console.ReadLine());
            switch (i)
            {
                case 1:
                    Console.WriteLine("вы выбрали площадь треугольника");
                    Console.WriteLine("формула: ");
                    Console.WriteLine("S = 0.5*a*h");
                    Console.WriteLine("введите a: ");
                    double a = double.Parse(Console.ReadLine());
                    Console.WriteLine("введите h: ");
                    double h = double.Parse(Console.ReadLine());
                    Console.Write("S треугольника = ");
                    double S = 0.5 * a * h;
                    Console.Write(S);
                    break;
                case 2:
                    Console.WriteLine("вы выбрали площадь прямоугольника");
                    Console.WriteLine("формула: ");
                    Console.WriteLine("S = a * b");
                    Console.WriteLine("введите a: ");
                    double ap = double.Parse(Console.ReadLine());
                    Console.WriteLine("введите b: ");
                    double b = double.Parse(Console.ReadLine());
                    Console.Write("S прямогульника = ");
                    double Sp = ap * b;
                    Console.Write(Sp);
                    break;
                case 3:
                    Console.WriteLine("вы выбрали площадь круга");
                    Console.WriteLine("формула: ");
                    Console.WriteLine("S = pi * r2");
                    Console.WriteLine("введите r: ");
                    double r = double.Parse(Console.ReadLine());
                    Console.Write("S круга = ");
                    double Sc = Math.PI * Math.Pow(r, 2);
                    Console.Write(Sc);
                    break;
                default:
                    Console.WriteLine("такой фигуры нет");
                    break;
            }
            Console.ReadKey();
        }


    }
}
