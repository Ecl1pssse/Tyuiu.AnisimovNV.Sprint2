using System;
using Tyuiu.AnisimovNV.Sprint2.Task0.V12.Lib;

namespace Tyuiu.AnisimovNV.Sprint2.Task0.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Анисимов Н. В. | ИСТНБ-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил: Анисимов Н. В. | ИСТНБ-25-1                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений и арифметических выражений,   *");
            Console.WriteLine("* которая вернет логическую последовательность:                          *");
            Console.WriteLine("* (True, False, True, False, True, False) при x = 1095, y = 475          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 1095;
            int y = 475;

            Console.WriteLine($"X = {x}");
            Console.WriteLine($"Y = {y}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            bool[] results = ds.GetCompareOperations(x, y);

            Console.WriteLine("Логическая последовательность:");
            for (int i = 0; i < results.Length; i++)
            {
                Console.WriteLine($"[{i}] = {results[i]}");
            }

            Console.ReadLine();
        }
    }
}