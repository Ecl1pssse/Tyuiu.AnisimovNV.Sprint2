using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AnisimovNV.Sprint2.Task6.V9.Lib
{
    public class DataService : ISprint2Task6V9
    {
        public string FindDateOfNextDay(int m, int n)
        {
            // Определяем количество дней в месяце (невисокосный год)
            int daysInMonth = m switch
            {
                1 => 31,  // Январь
                2 => 28,  // Февраль
                3 => 31,  // Март
                4 => 30,  // Апрель
                5 => 31,  // Май
                6 => 30,  // Июнь
                7 => 31,  // Июль
                8 => 31,  // Август
                9 => 30,  // Сентябрь
                10 => 31, // Октябрь
                11 => 30, // Ноябрь
                12 => 31, // Декабрь
                _ => 0    // Ошибка
            };

            // Проверяем корректность входных данных
            if (m < 1 || m > 12 || n < 1 || n > daysInMonth)
            {
                return "Ошибка: некорректная дата";
            }

            // Определяем дату следующего дня
            if (n < daysInMonth)
            {
                // Остаемся в том же месяце
                return $"{n + 1}.{m}";
            }
            else
            {
                // Переходим в следующий месяц
                // Условие гарантирует, что это не 31 декабря
                return $"1.{m + 1}";
            }
        }
    }
}