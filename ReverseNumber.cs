using System;
using System.Collections.Generic;

namespace LeetCodeRepo
{
    public class ReverseNumber
    {
        public static void Tests()
        {
            var cases = new Dictionary<int, int>();
            cases.Add(123, 321);
            cases.Add(-123, -321);
            cases.Add(120, 21);
            var obj = new ReverseNumber();
            foreach (var testCase in cases)
            {
                int actual = obj.Reverse(testCase.Key);
                Console.WriteLine($"input [{testCase.Key}], output = {actual} - {actual == testCase.Value}");
            }
        }

        /*
    1. check if x is negative 
    2. extract digit 
    3. 2^31 − 1 = 2147483647
    result >  int.MaxValue /10 => return 0 
    result == int.MaxValue /10 && digit > 7 => return 0; 
    */
        public int Reverse(int x)
        {
            bool isNeg = x < 0;
            x = isNeg ? -1 * x : x;
            int result = 0;
            while (x > 0)
            {
                var d = x % 10;
                x = x / 10;
                if (result > int.MaxValue / 10 || (result == int.MaxValue / 10 && d == 7))
                {
                    return 0;
                }

                result = result * 10 + d;
            }
            return isNeg ? -1 * result : result;
        }
    }
}