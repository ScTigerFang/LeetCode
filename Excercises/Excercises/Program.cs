using System;

namespace Excercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] nums = { 1, 1, 0, 1, 1, 1 };
            //Console.WriteLine( Solutions.FindMaxConsecutiveOnes(nums));

            int[] nums = { 555, 901, 482, 1771 };
            Console.WriteLine(Solutions.FindNumbers(nums));
        }
    }
}
