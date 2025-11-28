using Xunit;
using Tyuiu.AnisimovNV.Sprint2.Task1.V10.Lib;

namespace Tyuiu.AnisimovNV.Sprint2.Task1.V10.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void ValidGetLogicOperations()
        {
            DataService ds = new DataService();
            int a = 455;
            int b = 335;
            int c = 14;
            int d = 17;

            bool[] res = ds.GetLogicOperations(a, b, c, d);
            bool[] wait = { true, false, false, false, true, false };

            Assert.Equal(wait, res);
        }

        [Fact]
        public void ValidCheckEachOperation()
        {
            DataService ds = new DataService();
            int a = 455;
            int b = 335;
            int c = 14;
            int d = 17;

            bool[] res = ds.GetLogicOperations(a, b, c, d);

            Assert.True(res[0]);   // (a > b) | (c < d)
            Assert.False(res[1]);  // (a == b) & (c > d)
            Assert.False(res[2]);  // (a != b) || (c == d)
            Assert.False(res[3]);  // (a <= b) && (c >= d)
            Assert.True(res[4]);   // !(a < b) ^ (c == d)
            Assert.False(res[5]);  // (a < b) | (c > d) & (a == c)
        }
    }
}