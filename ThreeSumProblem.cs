using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeRepo
{
    // Leet code url - https://leetcode.com/problems/3sum/
    internal class ThreeSumProblem
    {
        public static void Tests()
        {
            //TestCase1();
            TestCase2();
        }

        public static void TestCase1()
        {
            var nums = new int[] { -1, 0, 1, 2, -1, -4 };
            var expected = new List<List<int>>
            {
                new List<int> { -1, 0, 1 },
                new List<int>{ -1, -1, 2 }
            };
            var obj = new ThreeSumProblem();
            var actual = obj.ThreeSum(nums);
            if (actual.Count() == expected.Count() &&
                actual.All(x => actual.Any(a => a.Contains(x[0]) && a.Contains(x[1]) && a.Contains(x[1]))))
            {
                Console.WriteLine($"Success.");
            }
            else
            {
                Console.WriteLine($"Failed.");
                foreach (var a in actual)
                {
                    var data = a.ToArray();
                    Array.Sort(data);
                    Console.WriteLine($"{string.Join(",", data)}");
                }
            }

        }


        public static void TestCase2()
        {
            var nums = new int[] { -4,-2,1,-5,-4,-4,4,-2,0,4,0,-2,3,1,-5,0
            };
            var expected = new List<List<int>>
            {
                new List<int>{-5,1,4},
                new List<int>{-4,0,4},
                new List<int>{-4,1,3},
                new List<int>{-2,-2,4},
                new List<int>{-2,1,1},
                new List<int>{0,0,0}
            };
            var obj = new ThreeSumProblem();
            var actual = obj.ThreeSum(nums);
            if (actual.Count() == expected.Count() &&
                actual.All(x => actual.Any(a => a.Contains(x[0]) && a.Contains(x[1]) && a.Contains(x[1]))))
            {
                Console.WriteLine($"Success.");
            }
            else
            {
                Console.WriteLine($"Failed.");
                foreach (var a in actual)
                {
                    var data = a.ToArray();
                    Array.Sort(data);
                    Console.WriteLine($"{string.Join(",", data)}");
                }
            }

        }

        public IList<IList<int>> ThreeSum(int[] nums)
        {
            if (nums == null || nums.Length < 3)
            {
                return new List<IList<int>>();
            }

            Array.Sort(nums);
            var resultSet = new List<IList<int>>();
            for (int i = 0; i < nums.Length - 2; i++)
            {
                var istrue = i > 0;
                if ((istrue && nums[i] == nums[i - 1])) continue;
                int j = i + 1;
                int k = nums.Length - 1;
                while (j < k)
                {

                    if (nums[i] + nums[j] + nums[k] == 0)
                    {
                        var result = new List<int> { nums[i], nums[j], nums[k] };
                        resultSet.Add(result);
                        while (j < k && nums[j] == nums[j + 1])
                        {
                            j++;
                        }
                        while (j < k && nums[k] == nums[k - 1])
                        {
                            k--;
                        }
                        j++;
                        k--;
                    }
                    else if (nums[i] + nums[j] + nums[k] < 0)
                    {
                        j++;
                    }
                    else
                    {
                        k--;
                    }
                }
            }
            return resultSet;
        }


    }
}
