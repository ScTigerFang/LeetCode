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
    //F:\Coding\Visual Studio\Repos\Excercises\HackerRank\QuestionsPDF\Test2flipping-the-matrix-English.pdf
    class Test2
    {
        //First Attempt did not get it in time limit of 23mins
        public static void Test2Problem()
        {
            Console.WriteLine("Enter Amount of times you want to loop");
            int q = Convert.ToInt32(Console.ReadLine().Trim());

            for (int qItr = 0; qItr < q; qItr++)
            {

                Console.WriteLine("QuadArea");
                int n = Convert.ToInt32(Console.ReadLine().Trim());
                List<List<int>> matrix = new List<List<int>>();

                for (int i = 0; i < 2 * n; i++)
                {
                    matrix.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(matrixTemp => Convert.ToInt32(matrixTemp)).ToList());
                }

                int result = flippingMatrix(matrix);

                Console.WriteLine(result);
            }
        }
        //this took over 2hrs first attempt, need to go back on it.
        //i looked it up after 2hrs and i had the logic worked out, just forgot to changes these*
        private static int flippingMatrix(List<List<int>> matrix)
        {
            //1 2 3 4 
            //5 6 7 8 
            //9 10 11 12 
            //13 14 15 16
            List<int> maxAmounts = new List<int>(); 
            var radiusOfQuad = (matrix.Count / 2);

            
            for (int row = 0; row < radiusOfQuad; row++)
            {
                //1
                for (int column = 0; column < radiusOfQuad; column++)
                {
                    var maxAmount = 0;
                    var v1 = matrix[row][column];//these were used for debugging
                    var v2 = matrix[row][matrix.Count - column - 1];
                    var v3 = matrix[matrix.Count - row - 1][column];
                    var v4 = matrix[matrix.Count - row - 1][matrix.Count - column - 1];
                    if (v1 > maxAmount)
                    {
                        maxAmount = matrix[row][column];
                    }
                    if (v2 > maxAmount)
                    {
                        maxAmount = matrix[row][matrix.Count - column - 1];
                    }
                    if (v3 > maxAmount)
                    {
                        maxAmount = matrix[matrix.Count - row - 1][column];//*
                    }
                    if (v4 > maxAmount)
                    {
                        maxAmount = matrix[matrix.Count - row - 1][matrix.Count - column - 1];//*
                    }
                    maxAmounts.Add(maxAmount);
                }
            };
            return maxAmounts.Sum();
        }
    }
}



////1 1
////2 4
////1
//var radiusOfQuad = (matrix.Count / 2);

//int maxSum = -1;
////                      1
//for (int row = 0; row < radiusOfQuad; row++)
//{
//    //1
//    for (int column = 0; column < radiusOfQuad; column++)
//    {
//        //       0 1                              2-0 - 1= 1, 2 - 1 -1 = 0
//        if (matrix[row][column] > matrix[matrix.Count - row - 1][matrix.Count - column - 1])
//        {
//            maxSum = maxSum + matrix[row][column];
//        }
//        else
//        {
//            maxSum = maxSum + matrix[matrix.Count - row - 1][matrix.Count - column - 1];
//        }
//    }
//}
//return maxSum;