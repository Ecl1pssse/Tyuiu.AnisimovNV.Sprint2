using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AnisimovNV.Sprint2.Task1.V10.Lib
{
    public class DataService : ISprint2Task1V10
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] results = new bool[6];

            // a = 455, b = 335, c = 14, d = 17
            // Нужна последовательность: (True, False, False, False, True, False)

            results[0] = (a > b) | (c < d);                    // True | True = True
            results[1] = (a == b) & (c > d);                   // False & False = False
            results[2] = (a == b) || (c == d);                 // False || False = False (ИСПРАВЛЕНО)
            results[3] = (a <= b) && (c >= d);                 // False && False = False
            results[4] = !(a < b) ^ (c == d);                  // true ^ false = True
            results[5] = (a < b) | (c > d) & (a == c);         // false | false & false = false

            return results;
        }
    }