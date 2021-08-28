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
            var choose = Console.ReadLine();
            switch (choose)
            {
                case "1":
                    PlusMinus.PlusMinusProblem();
                    break;
                case "2":
                    MiniMaxSum.MiniMaxSumProblem();
                    break;
                case "3":
                    TimeConversion.TimeConversionProblem();
                    break;
                case "test1":
                    Test1.Test1Problem();
                    break;
                case "4":
                    LonelyInteger.LonelyIntegerProblem();
                    break; 
                case "5":
                    DiagonalDifference.DiagonalDifferenceProblem();
                    break;
                case "6":
                    CountingSort1.CountingSort1Problem();
                    break;
                case "test2":
                    Test2.Test2Problem();
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
