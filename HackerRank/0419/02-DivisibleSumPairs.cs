using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HackerRank._0419
{
    public class DivisibleSumPairs
    {
        public static void Execute()
        {
            TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            var nk = Console.ReadLine().Split(' ');

            var n = Convert.ToInt32(nk[0]);

            var k = Convert.ToInt32(nk[1]);

            var ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            var result = divisibleSumPairs(n, k, ar);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }

        static int divisibleSumPairs(int n, int k, int[] ar)
        {
            var set = new HashSet<string>();

            for (var x = 0; x < ar.Length; x++)
            {
                for (var y = 0; y < ar.Length; y++)
                {
                    if (x != y && (ar[x] + ar[y]) % k == 0 && (!set.Contains($"{x}{y}") || !set.Contains($"{y}{x}")))
                    {
                        var _ = x < y ? set.Add($"{x}{y}") : set.Add($"{y}{x}");
                    }
                }
            }

            foreach (var s in set)
                Console.WriteLine(s);

            return set.Count;
        }
    }
}