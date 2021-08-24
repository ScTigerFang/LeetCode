using System;

namespace HackerRank
{
    class Program
    {

        //https://www.hackerrank.com/interview/preparation-kits/one-month-preparation-kit/one-month-week-one/challenges
        //https://www.hackerrank.com/interview/preparation-kits/one-week-preparation-kit/one-week-day-one/challenges
        static void Main(string[] args)
        {
            ChooseProblem();
        }

        public static void ChooseProblem()
        {
            Console.WriteLine("Which Option do you want?");
            int choose = int.Parse(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    PlusMinus.PlusMinusProblem();
                    break;
                case 2:
                    MiniMaxSum.MiniMaxSumProblem();
                    break;
                default:
                    break;
            }
            Console.WriteLine("\nDo you want to try again? Hit enter if you want to stop");
            string tryAgain = Console.ReadLine();
            if (tryAgain != "")
            {
                ChooseProblem();
            }
        }
    }
}
