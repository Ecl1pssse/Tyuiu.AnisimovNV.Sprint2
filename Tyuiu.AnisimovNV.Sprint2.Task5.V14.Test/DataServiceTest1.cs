using Xunit;
using Tyuiu.AnisimovNV.Sprint2.Task5.V14.Lib;

namespace Tyuiu.AnisimovNV.Sprint2.Task5.V14.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void ValidFindDayName1()
        {
            DataService ds = new DataService();
            int k = 1;  // 1 января
            int d = 1;  // понедельник
            string wait = "понедельник";
            string res = ds.FindDayName(k, d);
            Assert.Equal(wait, res);
        }

        [Fact]
        public void ValidFindDayName2()
        {
            DataService ds = new DataService();
            int k = 2;  // 2 января
            int d = 1;  // 1 января - понедельник
            string wait = "вторник";
            string res = ds.FindDayName(k, d);
            Assert.Equal(wait, res);
        }

        [Fact]
        public void ValidFindDayName3()
        {
            DataService ds = new DataService();
            int k = 8;  // 8 января
            int d = 1;  // 1 января - понедельник
            string wait = "понедельник"; // (0 + 7) % 7 = 0 ? понедельник
            string res = ds.FindDayName(k, d);
            Assert.Equal(wait, res);
        }

        [Fact]
        public void ValidFindDayName4()
        {
            DataService ds = new DataService();
            int k = 365;  // 31 декабря
            int d = 1;    // 1 января - понедельник
            string wait = "понедельник"; // (0 + 364) % 7 = 364 % 7 = 0 ? понедельник
            string res = ds.FindDayName(k, d);
            Assert.Equal(wait, res);
        }

        [Fact]
        public void ValidFindDayName5()
        {
            DataService ds = new DataService();
            int k = 15;  // 15 января
            int d = 7;   // 1 января - воскресенье
            string wait = "воскресенье"; // (6 + 14) % 7 = 20 % 7 = 6 ? воскресенье
            string res = ds.FindDayName(k, d);
            Assert.Equal(wait, res);
        }

        [Fact]
        public void ValidFindDayName6()
        {
            DataService ds = new DataService();
            int k = 32;  // 1 февраля
            int d = 4;   // 1 января - четверг
            string wait = "воскресенье"; // (3 + 31) % 7 = 34 % 7 = 6 ? воскресенье
            string res = ds.FindDayName(k, d);
            Assert.Equal(wait, res);
        }
    }
}