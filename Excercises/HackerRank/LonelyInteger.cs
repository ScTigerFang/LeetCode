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
    //F:\Coding\Visual Studio\Repos\Excercises\HackerRank\QuestionsPDF\4__lonely-integer-English.pdf
    class LonelyInteger
    {
        public static void LonelyIntegerProblem()
        {

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            int result = LonelyIntegerSolution(a);

            Console.WriteLine(result);
        }

        private static int LonelyIntegerSolution(List<int> arr)
        {
            foreach (var item in arr)
            {
                if (arr.IndexOf(item) == arr.LastIndexOf(item))
                {
                    return item;
                }                
            }
            return -1;
        }
    }
}