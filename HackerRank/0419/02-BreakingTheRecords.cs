using System;
using System.IO;

namespace HackerRank._0419
{
    //https://www.hackerrank.com/challenges/breaking-best-and-worst-records/problem
    public class BreakingTheRecords
    {
        public static void Execute()
        {
            TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            var n = Convert.ToInt32(Console.ReadLine());

            var scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp))
                ;
            var result = breakingRecords(scores);

            textWriter.WriteLine(string.Join(" ", result));

            textWriter.Flush();
            textWriter.Close();
        }

        static int[] breakingRecords(int[] scores)
        {
            if (scores.Length == 1)
                return new[] {0, 0};

            var mostPointsRecordCounter = 0;
            var leastPointsRecordCounter = 0;
            var highest = scores[0];
            var lowest = scores[0];

            for (var i = 1; i < scores.Length; i++)
            {
                if (scores[i] > highest)
                {
                    mostPointsRecordCounter++;
                    highest = scores[i];
                }
                else if (scores[i] < lowest)
                {
                    leastPointsRecordCounter++;
                    lowest = scores[i];
                }
            }

            return new[] {mostPointsRecordCounter, leastPointsRecordCounter};
        }
    }
}