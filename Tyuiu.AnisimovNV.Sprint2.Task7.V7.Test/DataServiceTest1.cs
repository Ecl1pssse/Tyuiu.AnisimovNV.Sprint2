using Xunit;
using Tyuiu.AnisimovNV.Sprint2.Task7.V7.Lib;

namespace Tyuiu.AnisimovNV.Sprint2.Task7.V7.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void ValidCheckDotInShadedArea1()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = 1;
            // Для x=0: y = 2 - 0 = 2, значит точка (0,1) под параболой
            bool wait = true;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.Equal(wait, res);
        }

        [Fact]
        public void ValidCheckDotInShadedArea2()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 1;
            // Для x=1: y = 2 - 1 = 1, значит точка (1,1) НА параболе
            bool wait = true;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.Equal(wait, res);
        }

        [Fact]
        public void ValidCheckDotInShadedArea3()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = -1;
            // Для x=2: y = 2 - 4 = -2, точка (2,-1) выше параболы (-1 > -2)
            bool wait = false;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.Equal(wait, res);
        }

        [Fact]
        public void ValidCheckDotInShadedArea4()
        {
            DataService ds = new DataService();
            double x = -1;
            double y = 0.5;
            // Для x=-1: y = 2 - 1 = 1, точка (-1,0.5) под параболой
            bool wait = true;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.Equal(wait, res);
        }

        [Fact]
        public void ValidCheckDotInShadedArea5()
        {
            DataService ds = new DataService();
            double x = 0.5;
            double y = 2;
            // Для x=0.5: y = 2 - 0.25 = 1.75, точка (0.5,2) выше параболы
            bool wait = false;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.Equal(wait, res);
        }

        [Fact]
        public void ValidCheckDotInShadedArea6()
        {
            DataService ds = new DataService();
            double x = 1.5;
            double y = -1;
            // Для x=1.5: y = 2 - 2.25 = -0.25, точка (1.5,-1) под параболой
            bool wait = true;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.Equal(wait, res);
        }
    }
}