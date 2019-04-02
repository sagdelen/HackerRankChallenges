using System;
using System.Linq;

namespace HackerRank._0319
{
    public class MiniMaxSumExecutor
    {
        public static void Execute()
        {
            var arr = Array.ConvertAll(Console.ReadLine()?.Split(' '), Convert.ToInt32);
            MiniMaxSum(arr);
        }

        static void MiniMaxSum(int[] arr)
        {
            var min = arr.Min();
            var max = arr.Max();
            var arraySum = arr.Aggregate(0L, (sum, i) => sum + i);

            var minSum = arraySum - max;
            var maxSum = arraySum - min;

            Console.WriteLine($"{minSum} {maxSum}");
        }
    }
}