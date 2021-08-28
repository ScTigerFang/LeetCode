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
    //F:\Coding\Visual Studio\Repos\Excercises\HackerRank\QuestionsPDF\6__countingsort1-English.pdf
    class CountingSort1
    {
        //Over thought this issue.
        public static void CountingSort1Problem()
        {
            Console.WriteLine("Enter how many Intigers you are going to use");
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            Console.WriteLine("Enter Intigers");
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            List<int> result = CountingSort1Solution(arr);
            Console.WriteLine(String.Join(" ", result));
        }

        private static List<int> CountingSort1Solution(List<int> arr)
        {
            List<int> result = new List<int>(new int[100]);//this was also new to me
            for (int i = 0; i <= arr.Count()-1; i++)
            {
                int index = arr[i];
                result[index] = result[index] +1;
            }
            return result;
        }
    }
}