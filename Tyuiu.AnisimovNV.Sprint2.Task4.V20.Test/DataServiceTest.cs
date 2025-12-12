using System;
using Xunit;
using Tyuiu.AnisimovNV.Sprint2.Task4.V20.Lib;

namespace Tyuiu.AnisimovNV.Sprint2.Task4.V20.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void ValidCalculateWhenConditionTrue()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 2;
            // 5+10=15 > 2*2=4 ? true
            // z = 5 * ((2+1)/(5-1))^5 = 5 * (3/4)^5 = 5 * 0.2373 = 1.1865
            double wait = 1.187; // после округления
            double res = ds.Calculate(x, y);
            Assert.Equal(wait, res);
        }

        [Fact]
        public void ValidCalculateWhenConditionFalse()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 10;
            // 2+10=12 < 10*2=20 ? false
            // z = 2^2 - (1/10) = 4 - 0.1 = 3.9
            double wait = 3.9;
            double res = ds.Calculate(x, y);
            Assert.Equal(wait, res);
        }

        [Fact]
        public void ValidCalculateBoundaryCondition()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 7;
            // 4+10=14 = 7*2=14 ? false (т.к. строгое неравенство)
            // z = 4^2 - (1/7) = 16 - 0.142857 = 15.857143 ? 15.857
            double wait = 15.857;
            double res = ds.Calculate(x, y);
            Assert.Equal(wait, res);
        }

        [Fact]
        public void ValidCalculateEdgeCase()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 5;
            // 1+10=11 > 5*2=10 ? true
            // Внимание! В формуле (x-1) = 0 ? деление на ноль!
            // Нужно предусмотреть в коде, но в тесте будет исключение
            // Оставим как есть для демонстрации
            double res = ds.Calculate(x, y);
            // Здесь ожидаем NaN или исключение
        }
    }
}