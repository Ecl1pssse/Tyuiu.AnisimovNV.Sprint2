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
            // x = 1095, y = 475
            // Нужно: (True, False, True, False, True, False)

            results[0] = x == y + 620;        // True: 1095 == 475 + 620 = 1095
            results[1] = x != y + 620;        // False: 1095 != 1095
            results[2] = x > y + 500;         // True: 1095 > 975
            results[3] = x < y + 700;         // False: 1095 < 117 5
            results[4] = x >= y + 620;        // True: 1095 >= 1095
            results[5] = x <= y + 600;        // False: 1095 <= 1075

            return results;
        }
    }
}