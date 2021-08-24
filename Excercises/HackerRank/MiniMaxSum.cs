using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank
{
    //F:\Coding\Visual Studio\Repos\Excercises\HackerRank\QuestionsPDF\2__mini-max-sum-English.pdf
    class MiniMaxSum
    {
        //Took me 12mins7 seconds to solve
        //ended up having an error for super long numbers as .Sum() adds to the original list so it needed to be Int64 prior
        public static void MiniMaxSumProblem()
        {
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
            miniMaxSumSolution(arr);
        }

        /*
         * Complete the 'miniMaxSum' function below.
         *
         * The function accepts INTEGER_ARRAY arr as parameter.
         */
        private static void miniMaxSumSolution(List<int> arr)
        {
            arr.Sort();
            List<Int64> sortedArray = arr.ConvertAll( i => (Int64)i);
            Int64 lowestValue = sortedArray.First();
            Int64 highestvalue = sortedArray.Last();
            Int64 totalValue = sortedArray.Sum();
            Console.WriteLine((totalValue - highestvalue).ToString() + " " + (totalValue - lowestValue).ToString());
        }
    }
}
