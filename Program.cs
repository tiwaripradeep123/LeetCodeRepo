using System;

namespace LeetCodeRepo
{
    class Program
    {
        // ToDo - Implement execution of all tests after build/check-in and reject the pull if build is failing.
        static void Main(string[] args)
        {
            Console.WriteLine("Hello ! \n This is repo for leet code practice in c#");
            Console.WriteLine("Each problem is solved and submitted to Leet code before it gets included in this repo.");
            Console.WriteLine("Each problem has video explainations too.");
            Console.WriteLine("Select case to execute perticular problem.");
            Console.WriteLine("1. Reverse integer");
            Console.WriteLine("2. Two sum problem");
            var input = Console.ReadLine();
            int.TryParse(input, out int choise);
            switch (choise)
            {
                case 1:
                    ReverseNumber.Tests();
                    break;
                case 2:
                    TwoSumProblem.Tests();
                    break;
                default:
                    break;
            }

            Console.WriteLine("Execution completed.");
            Console.ReadLine();
        }
    }
}
