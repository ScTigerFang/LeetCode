using System;
using System.Collections.Generic;

namespace AmazonInterviewNotes
{
    internal class DataTypes
    {
        //https://www.wikitechy.com/tutorials/csharp/csharp-list
        internal static void ListsAreEasy()
        {
            List<string> listOfLCSTeams = new List<string>();
            listOfLCSTeams.Add("TSM");
            Console.WriteLine(listOfLCSTeams);
            listOfLCSTeams.AddRange(new List<string>(){"TL","C9"});
            Console.WriteLine(listOfLCSTeams);
        }

        //https://www.wikitechy.com/tutorials/csharp/csharp-hashset
        internal static void HashSetsOhDear() 
        { 
        
        }
    }
}