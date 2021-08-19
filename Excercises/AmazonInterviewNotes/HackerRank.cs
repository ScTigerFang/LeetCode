using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonInterviewNotes
{
    class HackerRank
    {
        /*
        * Complete the 'findNumber' function below.
        * Say yes or no if number exists in a list
        * The function is expected to return a STRING - Yes or No.
        * The function accepts following parameters:
        *  1. INTEGER_ARRAY arr
        *  2. INTEGER k
        */
        public static string findNumber(List<int> arr, int k)
        {
            foreach (int num in arr)
            {
                if (num == k) return "YES";
            }
            return "NO";
        }

        /*
         * Complete the 'oddNumbers' function below.
         * return a list of intergers that exist between 2 values
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts following parameters:
         *  1. INTEGER l
         *  2. INTEGER r
         */
        public static List<int> oddNumbers(int l, int r)
        {
            List<int> oddNumbers = new List<int>();

            while (l <= r)
            {
                if (l % 2 != 0) { oddNumbers.Add(l); }
                l++;
            }
            return oddNumbers;
        }

        //Best algorithms for asymptotic runtime complexity????
        //Bubble Sort/ Heap Sort/ Selection Sort/ Insertion ???
    }
}
