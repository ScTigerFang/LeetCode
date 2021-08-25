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
    //F:\Coding\Visual Studio\Repos\Excercises\HackerRank\QuestionsPDF\3__time-conversion-English.pdf
    class TimeConversion
    {
        //
        public static void TimeConversionProblem()
        {
            //TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string s = Console.ReadLine();

            string result = TimeConversionSolution(s);

            Console.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close(); ;
        }

        private static string TimeConversionSolution(string s)
        {
            var date = DateTime.ParseExact(s, "hh:mm:sstt", CultureInfo.InvariantCulture);
            return date.ToString("HH:mm:ss");
        }
    }
}
