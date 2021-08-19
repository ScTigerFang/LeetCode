using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace AmazonInterviewNotes
{
    class Swapping
    {
        //https://dotnettutorials.net/lesson/swapping-program-in-csharp/
        public static void swappingMethods()
        {
            Stopwatch stopwatch = new Stopwatch();

            string name1 = "Dotnet", name2 = "Tutorials";
            int number1 = 10, number2 = 20, temp = 0, problemNumber = 0;
            List<TimeSpan> timesToSolveProblem = new List<TimeSpan>();

            stopwatch.Start();

            Console.WriteLine($"Before SWapping number1= {number1}, number2 = {number2}");
            temp = number1; //temp=10
            number1 = number2; //number1=20      
            number2 = temp; //number2=10        
            stopwatch.Stop();
            timesToSolveProblem.Add(stopwatch.Elapsed);
            Console.WriteLine($"After swapping number1= {number1}, number2 = {number2} " + timesToSolveProblem[problemNumber]);
            problemNumber++;

            stopwatch.Restart();

            number1 = 10;
            number2 = 20;
            Console.WriteLine($"Before SWapping number1= {number1}, number2 = {number2}");
            number1 = number1* number2; //number1=200 (10*20)      
            number2 = number1 / number2; //number2=10 (200/20)      
            number1 = number1 / number2; //number1=20 (200/10)
            stopwatch.Stop();
            timesToSolveProblem.Add(stopwatch.Elapsed);
            Console.WriteLine($"After swapping number1= {number1}, number2 = {number2} " + timesToSolveProblem[problemNumber]);
            problemNumber++;

            stopwatch.Restart();

            Console.WriteLine($"Before SWapping name1= {name1}, name2 = {name2}");
            // Step1: append 2nd string with the 1st string 
            name1 = name1 + name2;
            //Step2: store intial string name1 in string name2 
            name2 = name1.Substring(0, name1.Length - name2.Length);
            //Step3:  store initial string name2 in string name1 
            name1 = name1.Substring(name2.Length);
            stopwatch.Stop();
            timesToSolveProblem.Add(stopwatch.Elapsed);
            Console.WriteLine($"After swapping name1= {name1}, name2 = {name2} " + +timesToSolveProblem[problemNumber]);
            problemNumber++;
            Console.ReadKey();
        }
    }
}
