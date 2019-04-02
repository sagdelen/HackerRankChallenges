using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank._0319
{
    public class WidestLengthExecutor
    {
        public static void Execute()
        {
            var start = new List<int> {1, 2, 6, 6};
            var end = new List<int> {3, 3, 9, 8};
            WidestLength(10, start, end);
        }

        public static int WidestLength(int n, List<int> start, List<int> end)
        {
            var answer = new HashSet<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            var walks = new HashSet<int>();

            for (var i = 0; i < start.Count; i++)
            {
                var s = start[i];
                var e = end[i];

                for (var j = s; j <= e; j++)
                    walks.Add(j);
            }

            answer.ExceptWith(walks);

            foreach (var l in answer)
                Console.WriteLine(l);
            Console.WriteLine();

            var answers = answer.ToArray();

            var diff = MaxDiff(answers, answers.Length);
            Console.WriteLine(diff);

            return 0;
        }

        private static int MaxDiff(IReadOnlyList<int> arr, int arrSize)
        {
            var maxDiff = arr[1] - arr[0];
            var minElement = arr[0];
            int i;
            for (i = 1; i < arrSize; i++)
            {
                if (arr[i] - minElement > maxDiff)
                    maxDiff = arr[i] - minElement;
                if (arr[i] < minElement)
                    minElement = arr[i];
            }

            return maxDiff;
        }
    }
}