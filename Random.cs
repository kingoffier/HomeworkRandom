﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            //ex1(rnd);
            //ex2(rnd);
            //ex3(rnd);
            //ex4(rnd);
            //ex5(rnd);
            //ex6(rnd);
            //ex7(rnd);
            //ex8(rnd);
            //ex9(rnd);

        }

        private static void ex9(Random rnd)
        {
            string symbols = "!@#$%^&*()<>;:|_-";
            for (int i = 0; i < 15; i++)
            {
                int w = rnd.Next(0, symbols.Length);
                Console.WriteLine(symbols[w]);
            }
        }

        private static void ex8(Random rnd)
        {
            for (int i = 0; i < 10; i++)
            {
                int index = rnd.Next(65, 91);
                Console.WriteLine(Convert.ToChar(index));
            }
        }

        private static void ex7(Random rnd)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            int w = rnd.Next(0, alphabet.Length);
            Console.WriteLine(alphabet[w]);
        }
        private static void ex6(Random rnd)
        {
            string str = Console.ReadLine();
            while (str.Contains("  "))
            {
                str = str.Replace("  ", " ");
            }
            string[] textMass;
            textMass = str.Split(' ');
            int w = rnd.Next(0, textMass.Length);
            Console.WriteLine(textMass[w]);
        }
        private static void ex5(Random rnd)
        {
            string str = Console.ReadLine();
            while (str.Contains(" "))
            {
                str = str.Replace(" ", "");
            }
            int w = rnd.Next(0, str.Length);
            Console.WriteLine(str[w]);
        }
        private static void ex4(Random rnd)
        {
            double result = 0;
            int j = 0;
            for (int i = 0; i < 10; i++)
            {
                double w = rnd.NextDouble() * 200 - 100;
                Console.WriteLine("{0,8:F3}", w);
                if (w < 0)
                {
                    result += w;
                    j++;
                }

            }
            Console.WriteLine("Сумма отрицательных элементов = " + result);
            Console.WriteLine("Кол-во отрицательных элементов = " + j);
        }

        private static void ex3(Random rnd)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0,8:F3}", rnd.NextDouble() * 10 - 5);
            }
        }

        private static void ex2(Random rnd)
        {
            for (int i = 0; i < 10; i++)
            {
                rnd.NextDouble();
                Console.WriteLine("{0,8:F4}", rnd.NextDouble());
            }
            Console.ReadKey();
        }

        private static void ex1(Random rnd)
        {
            for (int i = 0; i < 10; i++)
            {
                int w = rnd.Next(1, 11);
                Console.WriteLine(w);
            }
            Console.ReadKey();
        }
    }
}
