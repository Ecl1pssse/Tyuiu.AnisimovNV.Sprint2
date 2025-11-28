using Xunit;
using Tyuiu.AnisimovNV.Sprint2.Task2.V22.Lib;

namespace Tyuiu.AnisimovNV.Sprint2.Task2.V22.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            // Тестируем точку внутри области
            bool res1 = ds.CheckDotInShadedArea(5, 5);
            Assert.True(res1);

            // Тестируем точку вне области
            bool res2 = ds.CheckDotInShadedArea(1, 1);
            Assert.False(res2);
        }

        [Fact]
        public void ValidCheckBoundaryPoints()
        {
            DataService ds = new DataService();

            // Граничные точки
            bool res1 = ds.CheckDotInShadedArea(3, 3); // Минимальные координаты
            bool res2 = ds.CheckDotInShadedArea(8, 8); // Максимальные координаты

            Assert.True(res1);
            Assert.True(res2);
        }
    }
}