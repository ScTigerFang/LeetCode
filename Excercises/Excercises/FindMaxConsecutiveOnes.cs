namespace Excercises
{
    public class Solution
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
        }
    }
}