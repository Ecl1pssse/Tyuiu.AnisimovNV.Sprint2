using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AnisimovNV.Sprint2.Task0.V12.Lib
{
    public class DataService : ISprint2Task0V12
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] results = new bool[6];

            // Последовательность операций сравнения
            results[0] = x == y + 620;        // True: 1095 == 475 + 620
            results[1] = x != y * 2 + 145;    // False: 1095 != 475*2 + 145
            results[2] = x > y * 2 + 100;     // True: 1095 > 475*2 + 100
            results[3] = x < y * 3 - 300;     // False: 1095 < 475*3 - 300
            results[4] = x >= y * 2 + 145;    // True: 1095 >= 475*2 + 145
            results[5] = x <= y + 620;        // False: 1095 <= 475 + 620

            return results;
        }
    }
}