using System;
using System.Linq;

namespace HackerRank._0319
{
    public class AppleAndOrange
    {
        //https://www.hackerrank.com/challenges/apple-and-orange

        public static void Execute()
        {
            var st = Console.ReadLine().Split(' ');

            var s = Convert.ToInt32(st[0]);

            var t = Convert.ToInt32(st[1]);

            var ab = Console.ReadLine().Split(' ');

            var a = Convert.ToInt32(ab[0]);

            var b = Convert.ToInt32(ab[1]);

            var mn = Console.ReadLine().Split(' ');

            var m = Convert.ToInt32(mn[0]);

            var n = Convert.ToInt32(mn[1]);

            var apples = Array.ConvertAll(Console.ReadLine().Split(' '), applesTemp => Convert.ToInt32(applesTemp));

            var oranges = Array.ConvertAll(Console.ReadLine().Split(' '), orangesTemp => Convert.ToInt32(orangesTemp));

            countApplesAndOranges(s, t, a, b, apples, oranges);
        }

        static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            var insideApples = apples.Select(x => x + a).Where(x => x >= s && x <= t).Count();
            var insideOranges = oranges.Select(x => x + b).Where(x => x >= s && x <= t).Count();

            Console.WriteLine(insideApples);
            Console.WriteLine(insideOranges);
        }
    }
}