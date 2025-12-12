using System;
using Xunit;
using Tyuiu.AnisimovNV.Sprint2.Task3.V4.Lib;

namespace Tyuiu.AnisimovNV.Sprint2.Task3.V4.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void ValidCalculateXGreaterThan1()
        {
            DataService ds = new DataService();
            double x = 2;
            double wait = 11; // 2 + ((2+1)/(2-1))^2 = 2 + 3^2 = 2 + 9 = 11
            double res = ds.Calculate(x);
            Assert.Equal(wait, res);
        }

        [Fact]
        public void ValidCalculateXEquals0()
        {
            DataService ds = new DataService();
            double x = 0;
            double wait = 1; // 0^2 + cos(0^2) = 0 + cos(0) = 0 + 1 = 1
            double res = ds.Calculate(x);
            Assert.Equal(wait, res);
        }

        [Fact]
        public void ValidCalculateXBetweenMinus8And0()
        {
            DataService ds = new DataService();
            double x = -1;
            double wait = 0.5; // (-1 - 1/(-1)^2)^(-1) = (-1 - 1)^(-1) = (-2)^(-1) = -0.5
            double res = ds.Calculate(x);
            Assert.Equal(wait, res);
        }

        [Fact]
        public void ValidCalculateXLessThanMinus8()
        {
            DataService ds = new DataService();
            double x = -10;
            double wait = -109.9; // -10 + 10*(-10) - (1/(-10)) = -10 - 100 + 0.1 = -109.9
            double res = ds.Calculate(x);
            Assert.Equal(wait, res);
        }

        [Fact]
        public void ValidCalculateXBetween0And1()
        {
            DataService ds = new DataService();
            double x = 0.5;
            double wait = 11.77; // 0.25 - sin(0.25) + 12 = 0.25 - 0.2474 + 12 ? 12.0026
            double res = ds.Calculate(x);
            Assert.Equal(wait, res);
        }
    }
}