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
    //F:\Coding\Visual Studio\Repos\Excercises\HackerRank\QuestionsPDF\8__TowerBreaker1.pdf
    class TowerBreakers1
    {
        //had to look it up, over thought it - remember anything that goes to 1 evenly divides. Evenly divides = no remainder aka 7/1 = 7 which is fine
        public static void TowerBreakers1Problem()
        {
            Console.WriteLine("Enter number of test cases");
            int t = Convert.ToInt32(Console.ReadLine().Trim());

            for (int tItr = 0; tItr < t; tItr++)
            {
                var random = new Random();
                Console.WriteLine("Enter Number of of Towers Followed by height of each;");
                string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

                int n = Convert.ToInt32(firstMultipleInput[0]);
                //n = random.Next(1, 100000);
                int m = Convert.ToInt32(firstMultipleInput[1]);
                //m = random.Next(1, 100000);

                int result = TowerBreakers1Solution(n, m);

                Console.WriteLine(result);
            }
        }
        //First player goes first
        //Given the values of n/m determine which player will win.
        //If the first player wins return 1, otherwise 2
        private static int TowerBreakers1Solution(int numberOfTowers, int heighOfEachTower)
        {
            //failed number 729771 591431 player one wins this
            //inputs = x(tower height) y(reduced to)
            //if ((7%6)%2 == 0)
            //{
            //    //valid move
            //}
            if (heighOfEachTower == 1)
            {
                return 2;//if all towers are already 1 = Player 1 defaults loss
            }
            if (numberOfTowers % 2 == 0)
            {
                return 2;//if number of towers is even, player 2 wins
            }
            return 1;//else player 1 wins

        }

        public static int determineLCM(int a, int b)
        {
            int num1, num2;
            if (a > b)
            {
                num1 = a; num2 = b;
            }
            else
            {
                num1 = b; num2 = a;
            }

            for (int i = 1; i < num2; i++)
            {
                int mult = num1 * i;
                if (mult % num2 == 0)
                {
                    return mult;
                }
            }
            return num1 * num2;
        }
    }
}