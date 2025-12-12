using System;
using Tyuiu.AnisimovNV.Sprint2.Task6.V9.Lib;

namespace Tyuiu.AnisimovNV.Sprint2.Task6.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Анисимов Н.В. | ИСТИБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Сокращенная форма записи оператора switch                         *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Анисимов Н.В. | ИСТИБ-25-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует сокращенную форму записи        *");
            Console.WriteLine("* оператора switch вычисляет требуемое значение и возвращает результат.   *");
            Console.WriteLine("* Условие: Дата некоторого дня характеризуется двумя натуральными числами:*");
            Console.WriteLine("* m (порядковый номер месяца) и n (число). По заданным n и m определить   *");
            Console.WriteLine("* дату следующего дня (принять, что n и m не характеризуют 31 декабря).   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите номер месяца (1-12): ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число (1-31 в зависимости от месяца): ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string result = ds.FindDateOfNextDay(m, n);
            Console.WriteLine($"Дата следующего дня: {result}");

            Console.ReadKey();
        }
    }
}