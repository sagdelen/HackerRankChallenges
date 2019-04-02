using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HackerRank._0319
{
    public class BetweenTwoSets
    {
        //https://www.hackerrank.com/challenges/between-two-sets/problem

        public static void Execute()
        {
            TextWriter tw = new StreamWriter(Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            var nm = Console.ReadLine().Split(' ');

            var n = Convert.ToInt32(nm[0]);

            var m = Convert.ToInt32(nm[1]);

            var a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));

            var b = Array.ConvertAll(Console.ReadLine().Split(' '), bTemp => Convert.ToInt32(bTemp));

            var total = getTotalX(a, b);

            tw.WriteLine(total);

            tw.Flush();
            tw.Close();
        }

        static int getTotalX(int[] a, int[] b)
        {
            //sample 1 input
            //2 2
            //2 6    =>
            //24 36    => 2'3x3'1 --- 2'2x3'2 => 2'2x3'1 = 12

            //sample 1 output
            //2
            //6 12 

            //sample input
            //2 3
            //2(2'1) 4(2'2) => 
            //16(2'4) 32(2'5) 96(2'5x3'1) => gcd
            //(2'4) gcd

            //sample output
            //3
            //4 (2'2), 8(2'3) and 16(2'4) are the only three numbers for which each element of a is a factor
            //and each is a factor of all elements of b.

            var start = a.Max();
            var end = b.Min();

            var results = new List<int>();

            for (var i = start; i <= end; i++)
                if (a.All(x => i % x == 0) && b.All(x => x % i == 0))
                    results.Add(i);

            foreach (var i in results)
                Console.WriteLine(i);
            
            return results.Count;
        }
    }
}