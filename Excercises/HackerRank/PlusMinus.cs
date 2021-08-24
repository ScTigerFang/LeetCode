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
    //F:\Coding\Visual Studio\Repos\Excercises\HackerRank\QuestionsPDF\1__plus-minus-English.pdf
    class PlusMinus
    {
        //First Attempt took me about 30mins but everything passed.
        public static void PlusMinusProblem()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            PlusMinusSolution(arr);
        }

        /*
         * Complete the 'plusMinus' function below.
         *
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        private static void PlusMinusSolution(List<int> arr)
        {
            //Hashtable hashtable = new Hashtable();
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
            keyValuePairs.Add(0, 0);//>0
            keyValuePairs.Add(1, 0);//<0
            keyValuePairs.Add(2, 0);//== 0
            foreach (var number in arr)
            {
                //switch (number)//Newer version to do this
                //{
                //    case var expression when number > 0 :
                //        keyValuePairs[0]++;
                //            break;
                //    case var expression when number < 0:
                //        keyValuePairs[1]++;
                //        break;
                //    case var expression when number == 0:
                //        keyValuePairs[2]++;
                //        break;
                //    default:
                //        break;
                //}
                if (number > 0)
                {
                    keyValuePairs[0]++;
                }
                else if (number < 0)
                {
                    keyValuePairs[1]++;
                }
                else
                {
                    keyValuePairs[2]++;
                }
            }

            foreach (var item in keyValuePairs)
            {
                Console.WriteLine(((float)item.Value/arr.Count).ToString("N6"));
            }
        }
    }
}
