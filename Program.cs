using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear(); // Задание 1
            int a, b, c, a2, b2, c2;
            int S, S2, p, p2;
            Console.ForegroundColor = ConsoleColor.Green;
            try
            {
                Console.WriteLine("Определение равносильности треугольников");
                Console.Write("Введите сторону a: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите сторону b: ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите сторону c: ");
                c = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите сторону a2: ");
                a2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите сторону b2: ");
                b2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите сторону c2: ");
                c2 = Convert.ToInt32(Console.ReadLine());

                p = (a + b + c) / 2;
                p2 = (a2 + b2 + c2) / 2;

                S = (int)Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                S2 = (int)Math.Sqrt(p2 * (p2 - a2) * (p2 - b2) * (p2 - c2));

                switch (S)
                { 
                    case 1:
                        {
                            S = S2; Console.Write("Треугольники равносильны"); break;
                        }
                    default:  Console.Write("Треугольники не равносильны"); break;
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Ошибка: {ex.Message}");
                Console.ForegroundColor = ConsoleColor.Green;
            }

        }
    }
}
