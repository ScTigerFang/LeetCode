using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace HackerRank
{
    //F:\Coding\Visual Studio\Repos\Excercises\HackerRank\QuestionsPDF\5__diagonal-difference-English.pdf
    class DiagonalDifference
    {
        //3 -- inputs
        //11 2 4
        //4 5 6
        //10 8 -12
        //this one was a little rough haha
        public static void DiagonalDifferenceProblem()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = DiagonalDifferenceSolution(arr);
            Console.WriteLine(result);
        }

        /*
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */
        private static int DiagonalDifferenceSolution(List<List<int>> arr)
        {
            List<int> PrimaryDiagonal = new List<int>();
            List<int> SecondaryDiagonal = new List<int>();
            for (int row = 0; row < arr.Count; row++)
            {
                PrimaryDiagonal.Add(arr[row][row]);
                SecondaryDiagonal.Add(arr[row][(arr[row].Count() - row)-1]);
            };

            int difference = Math.Abs(PrimaryDiagonal.Sum() - SecondaryDiagonal.Sum());
            return difference;
        }
    }
}