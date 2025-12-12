using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AnisimovNV.Sprint2.Task4.V20.Lib
{
    public class DataService : ISprint2Task4V20
    {
        public double Calculate(double x, double y)
        {
            // Тернарный оператор: условие ? значение_если_истина : значение_если_ложь
            double z = (x + 10 > y * 2)
                ? x * Math.Pow((y + 1) / (x - 1), x)
                : Math.Pow(x, 2) - (1 / y);

            return Math.Round(z, 3);
        }
    }
}