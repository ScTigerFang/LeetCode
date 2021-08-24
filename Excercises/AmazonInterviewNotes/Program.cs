using System;
using System.Collections.Generic;
using System.Diagnostics;

/*Helpfull Links
 * https://www.freecodecamp.org/news/coding-interviews-for-dummies-5e048933b82b/
 * https://www.hackerrank.com/test/sample
 * 
 * https://projecteuler.net/sign_in havnt done
 * 
 * 
 * 
 * https://dotnettutorials.net/course/csharp-dot-net-programs/
 * 
 * 
 * 
 * Some Youtube Links that I want to try
 * https://www.youtube.com/watch?v=5co5Gvp_-S0  First non repeating Character
 * https://www.youtube.com/watch?v=XSdr_O-XVRQ  first duplicate
 * https://www.youtube.com/watch?v=sfuZzBLPcx4  Sum of 2 from arrays
 * https://www.youtube.com/watch?v=s8YcbwVl-HI  hashTables c#
 */

namespace AmazonInterviewNotes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Swapping.swappingMethods();//1 of 31
            //FibonacciSeries.ChooseSolution();//2 of 31

            DataTypes.ChooseSolution();

        }


        static void BasicDataTypes() {
            //https://stackoverflow.com/questions/618535/difference-between-decimal-float-and-double-in-net
            float flt = 1F / 3;//Fastest
            double dbl = 1D / 3;//Middle
            decimal dcm = 1M / 3;//Most Precise
            Console.WriteLine("float: {0} double: {1} decimal: {2}", flt, dbl, dcm);
            //float:    0.3333333
            //double:   0.333333333333333
            //decimal:  0.3333333333333333333333333333
        }
    }
}
