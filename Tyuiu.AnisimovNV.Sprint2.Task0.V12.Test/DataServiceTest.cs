using Xunit;
using Tyuiu.AnisimovNV.Sprint2.Task0.V12.Lib;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AnisimovNV.Sprint2.Task0.V12.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();
            int x = 1095;
            int y = 475;

            bool[] res = ds.GetCompareOperations(x, y);
            bool[] wait = { true, false, true, false, true, false };

            Assert.Equal(wait, res);
        }

        [Fact]
        public void ValidCheckEachOperation()
        {
            DataService ds = new DataService();
            int x = 1095;
            int y = 475;

            bool[] res = ds.GetCompareOperations(x, y);

            Assert.True(res[0]);   // x == y + 620
            Assert.False(res[1]);  // x != y * 2 + 145
            Assert.True(res[2]);   // x > y * 2 + 100
            Assert.False(res[3]);  // x < y * 3 - 300
            Assert.True(res[4]);   // x >= y * 2 + 145
            Assert.False(res[5]);  // x <= y + 620
        }
    }
}