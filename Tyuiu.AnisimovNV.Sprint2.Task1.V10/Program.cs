using System;
using Tyuiu.AnisimovNV.Sprint2.Task1.V10.Lib;

namespace Tyuiu.AnisimovNV.Sprint2.Task1.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Анисимов Н. В. | ИСТНБ-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Логические операции                                               *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Анисимов Н. В. | ИСТНБ-25-1                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений и логических операций,        *");
            Console.WriteLine("* которая вернет логическую последовательность:                          *");
            Console.WriteLine("* (True, False, False, False, True, False) при a=455, b=335, c=14, d=17  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int a = 455;
            int b = 335;
            int c = 14;
            int d = 17;

            Console.WriteLine($"A = {a}");
            Console.WriteLine($"B = {b}");
            Console.WriteLine($"C = {c}");
            Console.WriteLine($"D = {d}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            bool[] results = ds.GetLogicOperations(a, b, c, d);

            Console.WriteLine("Логическая последовательность:");
            for (int i = 0; i < results.Length; i++)
            {
                Console.WriteLine($"[{i}] = {results[i]}");
            }

            Console.ReadLine();
        }
    }
}