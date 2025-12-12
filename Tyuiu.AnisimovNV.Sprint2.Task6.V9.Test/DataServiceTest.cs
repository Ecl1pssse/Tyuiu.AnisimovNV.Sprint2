using Xunit;
using Tyuiu.AnisimovNV.Sprint2.Task6.V9.Lib;

namespace Tyuiu.AnisimovNV.Sprint2.Task6.V9.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void ValidFindDateOfNextDay1()
        {
            DataService ds = new DataService();
            int m = 1;  // Январь
            int n = 15; // 15 января
            string wait = "16.1"; // 16 января
            string res = ds.FindDateOfNextDay(m, n);
            Assert.Equal(wait, res);
        }

        [Fact]
        public void ValidFindDateOfNextDay2()
        {
            DataService ds = new DataService();
            int m = 1;  // Январь
            int n = 31; // 31 января
            string wait = "1.2"; // 1 февраля
            string res = ds.FindDateOfNextDay(m, n);
            Assert.Equal(wait, res);
        }

        [Fact]
        public void ValidFindDateOfNextDay3()
        {
            DataService ds = new DataService();
            int m = 2;  // Февраль
            int n = 28; // 28 февраля
            string wait = "1.3"; // 1 марта
            string res = ds.FindDateOfNextDay(m, n);
            Assert.Equal(wait, res);
        }

        [Fact]
        public void ValidFindDateOfNextDay4()
        {
            DataService ds = new DataService();
            int m = 4;  // Апрель
            int n = 30; // 30 апреля
            string wait = "1.5"; // 1 мая
            string res = ds.FindDateOfNextDay(m, n);
            Assert.Equal(wait, res);
        }

        [Fact]
        public void ValidFindDateOfNextDay5()
        {
            DataService ds = new DataService();
            int m = 12; // Декабрь
            int n = 30; // 30 декабря
            string wait = "31.12"; // 31 декабря
            string res = ds.FindDateOfNextDay(m, n);
            Assert.Equal(wait, res);
        }

        [Fact]
        public void ValidFindDateOfNextDay6()
        {
            DataService ds = new DataService();
            int m = 6;  // Июнь
            int n = 15; // 15 июня
            string wait = "16.6"; // 16 июня
            string res = ds.FindDateOfNextDay(m, n);
            Assert.Equal(wait, res);
        }

        [Fact]
        public void InvalidDateTest()
        {
            DataService ds = new DataService();
            int m = 13; // Несуществующий месяц
            int n = 1;
            string res = ds.FindDateOfNextDay(m, n);
            Assert.Equal("Ошибка: некорректная дата", res);
        }
    }
}