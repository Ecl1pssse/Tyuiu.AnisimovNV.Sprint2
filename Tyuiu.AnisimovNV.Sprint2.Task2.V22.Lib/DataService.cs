using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AnisimovNV.Sprint2.Task2.V22.Lib
{
    public class DataService : ISprint2Task2V22
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            // Анализируем заштрихованную область по координатам
            // Область обычно представляет собой прямоугольник или комбинацию прямоугольников

            // Пример для прямоугольной области от (3,3) до (10,10)
            bool inHorizontalStrip = (x >= 3) && (x <= 10) && (y >= 3) && (y <= 10);

            // Или для более сложной области (пример)
            bool inComplexArea = ((x >= 2) && (x <= 6) && (y >= 2) && (y <= 7)) ||
                                ((x >= 5) && (x <= 9) && (y >= 4) && (y <= 9));

            // Возвращаем true если точка в заштрихованной области
            // Нужно уточнить конкретную область по изображению
            return inHorizontalStrip; // Замени на нужную логику
        }
    }
}