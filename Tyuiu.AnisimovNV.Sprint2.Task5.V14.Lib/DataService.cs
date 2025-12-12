using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AnisimovNV.Sprint2.Task5.V14.Lib
{
    public class DataService : ISprint2Task5V14
    {
        public string FindDayName(int k, int d)
        {
            // Вычисляем день недели для k-го дня
            // (d - 1) переводим в 0-6 диапазон (0 = понедельник, 6 = воскресенье)
            // (k - 1) - количество дней, прошедших с 1 января
            int dayOfWeek = ((d - 1) + (k - 1)) % 7;

            // Используем оператор switch для определения дня недели
            switch (dayOfWeek)
            {
                case 0: return "понедельник";
                case 1: return "вторник";
                case 2: return "среда";
                case 3: return "четверг";
                case 4: return "пятница";
                case 5: return "суббота";
                case 6: return "воскресенье";
                default: return "ошибка";
            }
        }
    }
}