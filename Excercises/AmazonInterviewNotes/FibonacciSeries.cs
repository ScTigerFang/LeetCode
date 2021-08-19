using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonInterviewNotes
{
    //https://dotnettutorials.net/lesson/fibonacci-series-in-csharp/
    class FibonacciSeries
    {
        public static void ChooseSolution()
        {
            Console.WriteLine("Which Option do you want?");
            int choose = int.Parse(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    FibonacciSeriesMethod1();
                    break;
                case 2:
                    FibonacciSeriesMethod2();
                    break;
                case 3:
                    FibonacciSeriesMethod3();
                    break;
                default:
                    break;
            }
            Console.WriteLine("\nDo you want to try again? Hit enter if you want to stop");
            string tryAgain = Console.ReadLine();
            if (tryAgain != "")
            {
                ChooseSolution();
            }
        }

        /// <summary>
        /// Returns the specific value at the nTh Value
        /// </summary>
        private static void FibonacciSeriesMethod3()
        {
            int firstNumber = 0, secondNumber = 1, nextNumber = 0, counter = 0;
            bool found = false;
            Console.WriteLine("Which nTh Value do you want?");

            int nthValue = int.Parse(Console.ReadLine());
            while (!found)
            {
                nextNumber = firstNumber + secondNumber;
                firstNumber = nextNumber + secondNumber;
                secondNumber = firstNumber - secondNumber;
                firstNumber = firstNumber - secondNumber;
                if (counter == nthValue)
                {
                    Console.WriteLine(nextNumber);
                    found = true;
                }
                else
                {
                    counter++;
                }
            }
        }


         public static void FibonacciSeriesMethod1()
         {
            int firstNumber= 0, secondNumber = 1, nextNumber , counter = 0, numberOfElements;

            Console.Write("Enter the number of elements to Print : ");
            numberOfElements = int.Parse(Console.ReadLine());

            while (counter <= numberOfElements )
            {
                nextNumber = firstNumber + secondNumber;
                firstNumber = nextNumber + secondNumber;
                secondNumber = firstNumber - secondNumber;
                firstNumber = firstNumber - secondNumber;
                Console.Write(" {0}", nextNumber);
                counter++;
            }
         }

        public static void FibonacciSeriesMethod2()
        {
            int firstNumber = 0, secondNumber = 1, nextNumber = 0, counter = 0, numberOfElements;

            Console.Write("Enter the number of elements to Print : ");
            numberOfElements = int.Parse(Console.ReadLine());
            FibonacciSeriesMethod(firstNumber, secondNumber, nextNumber, numberOfElements, counter);
        }

        private static void FibonacciSeriesMethod(int firstNumber, int secondNumber, int nextNumber, int numberOfElements, int counter)
        {
            Console.Write("{0} ", nextNumber);
            nextNumber = firstNumber + secondNumber;
            firstNumber = nextNumber + secondNumber;
            secondNumber = firstNumber - secondNumber;
            firstNumber = firstNumber - secondNumber;
            counter++;
            if (counter <= numberOfElements)
            {
                FibonacciSeriesMethod(firstNumber, secondNumber, nextNumber, numberOfElements, counter);
            }
        }
    }
}
