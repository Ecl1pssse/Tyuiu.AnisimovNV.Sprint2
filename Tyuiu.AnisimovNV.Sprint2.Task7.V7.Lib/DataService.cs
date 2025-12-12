using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AnisimovNV.Sprint2.Task7.V7.Lib
{
    public class DataService : ISprint2Task7V7
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            // Вычисляем значение функции y = 2 - x^2 в точке x
            double parabolaValue = 2 - Math.Pow(x, 2);

            // Проверяем, находится ли точка под параболой или на ней (y ≤ 2 - x²)
            // Если изображение показывает другую область, измените условие
            bool isInShadedArea = y <= parabolaValue;

            return isInShadedArea;
        }
    }
}