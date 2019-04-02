using System;
using System.IO;

namespace HackerRank._0319
{
    public class Kangaroo
    {
        //https://www.hackerrank.com/challenges/kangaroo/problem

        public static void Execute()
        {
            TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            var x1V1X2V2 = Console.ReadLine().Split(' ');

            var x1 = Convert.ToInt32(x1V1X2V2[0]);

            var v1 = Convert.ToInt32(x1V1X2V2[1]);

            var x2 = Convert.ToInt32(x1V1X2V2[2]);

            var v2 = Convert.ToInt32(x1V1X2V2[3]);

            var result = kangaroo(x1, v1, x2, v2);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }

        static string kangaroo(int x1, int v1, int x2, int v2)
        {
            if (v1 <= v2)
                return "NO";

            float c = x1 - x2;
            var v = v2 - v1;

            if (v < 0)
            {
                c *= -1;
                v *= -1;
            }

            if (c < 0)
                return "NO";

            if (v > 1)
                c /= v;

            return c - (int) c == 0F ? "YES" : "NO";
        }
    }
}