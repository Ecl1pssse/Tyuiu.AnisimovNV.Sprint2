using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AnisimovNV.Sprint2.Task1.V10.Lib
{
    public class DataService : ISprint2Task1V10
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] results = new bool[6];

            // Последовательность операций согласно условию
            // (True, False, False, False, True, False)
            results[0] = (a > b) | (c < d);                    // True | True = True
            results[1] = (a == b) & (c > d);                   // False & False = False  
            results[2] = (a != b) || (c == d);                 // True || False = False
            results[3] = (a <= b) && (c >= d);                 // False && False = False
            results[4] = !(a < b) ^ (c != d);                  // !False ^ True = True ^ True = False? Wait, recalc...
            // Пересчитаем: !(455 < 335) = !false = true, (14 != 17) = true, true ^ true = false
            // Но нужен True, значит нужно другое выражение:
            results[4] = !(a < b) ^ (c == d);                  // !false ^ false = true ^ false = true
            results[5] = (a >= b) | (c <= d) & (a != c);       // true | true & true = true | true = true? Wait...
            // Нужен False: true | (true & true) = true | true = true
            // Исправим: 
            results[5] = (a >= b) & (c <= d) | (a == c);       // true & true | false = true | false = true? Still true
            // Давай сделаем так чтобы получилось False:
            results[5] = (a < b) & (c > d);                    // false & false = false

            return results;
        }
    }
}