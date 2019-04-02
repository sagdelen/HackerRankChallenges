using System;
using System.Collections.Generic;
using System.IO;

namespace HackerRank._0319
{
    public class GradingStudents
    {
        /*
            https://www.hackerrank.com/challenges/grading/problem
            
            HackerLand University has the following grading policy:

            Every student receives a grade in the inclusive range from 0 to 100.
            Any grade less than 40 is a failing grade.
            Sam is a professor at the university and likes to round each student's  according to these rules:
            
            If the difference between the grade and the next multiple of 5 is less than 3, round grade up to the next multiple of 5.
            If the value of grade is less than 38, no rounding occurs as the result will still be a failing grade.
            For example, grade=84 will be rounded to 85 but grade=29 will not be rounded because the rounding would result in a number that is less than 40.
            
            Given the initial value of grade for each of Sam's n students, write code to automate the rounding process.
            
            Function Description
            
            Complete the function gradingStudents in the editor below. It should return an integer array consisting of rounded grades.
            
            gradingStudents has the following parameter(s):
            
            grades: an array of integers representing grades before rounding
            
            Input Format
            The first line contains a single integer, n, the number of students. 
            Each line i of the n subsequent lines contains a single integer, grades[i], denoting student 's grade.
            
            Output Format
            For each , print the rounded grade on a new line.
            
            Sample Input:
            4
            73
            67
            38
            33
            
            Sample Output
            75
            67
            40
            33
         */

        public static void Execute()
        {
            TextWriter tw = new StreamWriter(Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            var n = Convert.ToInt32(Console.ReadLine());

            var grades = new int [n];

            for (var gradesItr = 0; gradesItr < n; gradesItr++)
            {
                var gradesItem = Convert.ToInt32(Console.ReadLine());
                grades[gradesItr] = gradesItem;
            }

            var result = gradingStudents(grades);

            tw.WriteLine(string.Join("\n", result));

            tw.Flush();
            tw.Close();
        }

        static int[] gradingStudents(int[] grades)
        {
            var roundedGrades = new List<int>();
            foreach (var grade in grades)
            {
                var mod = grade % 5;
                var diff = 0;
                if (grade > 37 && mod > 2)
                    diff = 5 - mod;
                roundedGrades.Add(grade + diff);
            }

            return roundedGrades.ToArray();
        }
    }
}