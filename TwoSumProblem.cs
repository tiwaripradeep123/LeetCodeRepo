using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeRepo
{
    // Leet code url - https://leetcode.com/problems/two-sum/
    internal class TwoSumProblem
    {
        public static void Tests()
        {
            TestCase1();
            TestCase2();
            TestCase3();
        }

        public static void TestCase1()
        {
            var nums = new int[] { 2, 7, 11, 15 };
            var target = 9;
            var expected = new int[] { 0, 1 };
            var obj = new TwoSumProblem();
            var actual = obj.TwoSum(nums, target);
            var result = actual.Length == expected.Length &&
            expected.ToList().All(x => actual.ToList().Any(y => x == y));

            Console.WriteLine($"Success : {result}");
        }

        public static void TestCase2()
        {
            var nums = new int[] { 2, 7, 11, 15 };
            var target = 18;
            var expected = new int[] { 1, 2 };
            var obj = new TwoSumProblem();
            var actual = obj.TwoSum(nums, target);
            var result = actual.Length == expected.Length &&
            expected.ToList().All(x => actual.ToList().Any(y => x == y));

            Console.WriteLine($"Success : {result}");
        }

        public static void TestCase3()
        {
            var nums = new int[] { 2, 7, 11, 15 };
            var target = 118;
            var expected = new int[0];
            var obj = new TwoSumProblem();
            var actual = obj.TwoSum(nums, target);
            var result = actual.Length == expected.Length &&
            expected.ToList().All(x => actual.ToList().Any(y => x == y));

            Console.WriteLine($"Success : {result}");
        }

        // there are two solutions 
        // 1. Brute force - nest iterations 1. for 0 -n-1 2. i -> n -1 = N*N O(n2)
        // 2. Hashtable - Dictionary C# it helps reduce O(n) loopup time to o(1).
        public int[] TwoSum(int[] nums, int target)
        {
            if (nums == null || nums.Length <= 1)
            {
                return new int[0];
            }

            var lookup = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!lookup.ContainsKey(nums[i]))
                {
                    lookup.Add(nums[i], i);
                }

            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (lookup.ContainsKey(target - nums[i]))
                {
                    int index = lookup[target - nums[i]];
                    if (index != i)
                    {
                        return new int[] { i, index };
                    }
                }

            }
            return new int[0];
        }
    }
}
