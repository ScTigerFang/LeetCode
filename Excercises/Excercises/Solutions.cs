using System.Collections.Generic;

namespace Excercises
{
    public class Solutions
    {
        /// <summary>
        /// Given a binary array nums, return the maximum number of consecutive 1's in the array.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int FindMaxConsecutiveOnes(int[] nums)
        {
            int max = 0, current = 0;
            foreach (int number in nums)
            {
                if (number == 1)
                {
                    current++;
                }
                else
                {
                    max = (current > max) ? current : max;
                    current = 0;
                }
                
            }
            return max = (current > max) ? current : max;
            //test result = top 3.5%
        }

        /// <summary>
        /// Given an array nums of integers, return how many of them contain an even number of digits.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int FindNumbers(int[] nums)
        {
            int oddNumbers = 0;
            List<int> vs = new List<int>();
            return 0;
        }
    }
}