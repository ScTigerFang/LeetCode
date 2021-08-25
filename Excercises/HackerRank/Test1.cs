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
    //PDFHere
    class Test1
    {
        public static void Test1Problem()
        {
            //CopyAndPasteSolution(arr);
            throw new NotImplementedException();
        }

        private static void Test1Solution(List<int> arr)
        {
            arr.Sort();
            Console.WriteLine(arr[(arr.Count/2)]);
        }
    }
}