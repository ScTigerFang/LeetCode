using System;
using System.Collections.Generic;

namespace AmazonInterviewNotes
{
    internal class DataTypes
    {
        Array _LcsTeamsArray;

        public static void ChooseSolution()
        {
            Console.WriteLine("Which Option do you want?");
            int choose = int.Parse(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    ListsAreEasy();
                    break;
                case 2:
                    HashSetsOhDear();
                    break;
                case 3:
                    SortSets();
                    break;
                case 4:
                    Stack();
                    break;
                case 5:
                    CheckListQueue();
                    break;
                case 6:
                    LinkyListies();
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

        //https://www.wikitechy.com/tutorials/csharp/csharp-list
        internal static void ListsAreEasy()
        {
            List<string> listOfLCSTeams = new List<string>();
            listOfLCSTeams.Add("TSM");
            Console.WriteLine(listOfLCSTeams);
            listOfLCSTeams.AddRange(new List<string>() { "TL", "C9" });
            Console.WriteLine(listOfLCSTeams);
        }

        //https://www.wikitechy.com/tutorials/csharp/csharp-hashset
        //https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1?view=net-5.0
        internal static void HashSetsOhDear()
        {
            //Main thing with hashsets is it only stores unique values/keys.
            var lcsTeams = new HashSet<string>();
            lcsTeams.Add("TSM");
            foreach (var team in lcsTeams)
            {
                Console.Write(" {0}", team);
            }
            lcsTeams.Add("TL");
            lcsTeams.Add("C9");
            lcsTeams.Add("TL");
            lcsTeams.Add("C9");
            lcsTeams.Add("TL");
            lcsTeams.Add("C9");
            Console.WriteLine("\n New Teams Added \n");
            foreach (var team in lcsTeams)
            {
                Console.Write(" {0}", team);
            }

        }

        //https://www.wikitechy.com/tutorials/csharp/csharp-sortedset
        //https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.sortedset-1?view=net-5.0
        internal static void SortSets()
        {
            SortedSet<string> lcsTeamsSorted = new SortedSet<string>();
            lcsTeamsSorted.Add("Team Liquid");
            lcsTeamsSorted.Add("Team Solo Mid");
            lcsTeamsSorted.Add("Evil Geniuses");
            lcsTeamsSorted.Add("100 Thieves");
            lcsTeamsSorted.Add("100 Thieves");
            lcsTeamsSorted.Add("100 Thieves");
            lcsTeamsSorted.Add("Cloud 9");
            lcsTeamsSorted.Add("Dignitas");
            lcsTeamsSorted.Add("Counter Logic Gaming");
            Console.WriteLine("Teams in order \n");
            foreach (var team in lcsTeamsSorted)
            {
                Console.Write("{0} \n", team);
            }

            SortedSet<double> lcsKDAs = new SortedSet<double>();
            lcsKDAs.Add(2.1);
            lcsKDAs.Add(12.1);
            lcsKDAs.Add(69.8);
            lcsKDAs.Add(0.0);
            lcsKDAs.Add(1.69);
            lcsKDAs.Add(14.2);
            lcsKDAs.Add(3.2);
            Console.WriteLine("Teams in order \n");
            foreach (var team in lcsKDAs)
            {
                Console.Write("{0} \n", team);
            }
        }

        //https://www.wikitechy.com/tutorials/csharp/csharp-stack
        //https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.stack-1?view=net-5.0
        internal static void Stack() {
            Stack<int> bunchOfNumbers = new Stack<int>();

            for (int i = 0; i < 1000; i++)
            {
                bunchOfNumbers.Push(i);
            }
            foreach (int number in bunchOfNumbers)
            {
                if (number%3 == 0)
                {
                    Console.WriteLine(" {0}", number);
                }
            }
        }

        //https://www.wikitechy.com/tutorials/csharp/csharp-queue
        //https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.queue-1?view=net-5.0
        private static void CheckListQueue()
        {
            Queue<String> checklist = new Queue<string>();
            checklist.Enqueue("Creating this checklist");
            checklist.Enqueue("Adding Values to this Checklist");
            checklist.Enqueue("Creating code that allows you to peek");
            checklist.Enqueue("Ask if you want to remove what you peeked");
            checklist.Enqueue("Dequeue item");

            while (checklist.Count > 0)
            {
                Console.WriteLine("Next item on the todo list: {0}", checklist.Peek());
                Console.WriteLine("Press enter if you have done it, and to remove it");
                Console.ReadLine();
                Console.WriteLine(checklist.Dequeue() + " - Has been removed");
            }
        }

        //https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.linkedlist-1?view=net-5.0
        //https://www.wikitechy.com/tutorials/csharp/csharp-linked-list
        internal static void LinkyListies() 
        {
            LinkedList<string> linkedListExample = new LinkedList<string>();
            for (int i = 0; i < 10; i++)
            {
                _ = i%2 == 0 ? linkedListExample.AddFirst("User{0}" + i) : linkedListExample.AddLast("User" + i);
            }
            foreach (var item in linkedListExample)
            {
                Console.WriteLine(item);

            }
            //Below doesnt reverse it how I would like 0 was missing, without using another data type - probably not worth digging into right now.
            LinkedListNode<string> linkedListNode1 = null;
            LinkedListNode<string> linkedListNode2 = null;
            LinkedList<string> linkedListExample2 = new LinkedList<string>();
            for (int i = -1; i < linkedListExample.Count ; i++)
            {
                linkedListNode1 = linkedListExample.First;
                linkedListNode2 = linkedListExample.Last;
                linkedListExample.RemoveFirst();
                linkedListExample.RemoveLast();
                linkedListExample2.AddLast(linkedListNode1);
                linkedListExample2.AddFirst(linkedListNode2);
            }
            foreach (var item in linkedListExample2)
            {
                Console.WriteLine(item);

            }
        }

        internal static void DictionaryVsHashTable() {
            Dictionary<int, LCSTeam> lcsTeamsDictionary = new Dictionary<int, LCSTeam>();
            for (int i = 0; i < 10000; i++)
            {
                LCSTeam dubbyLCsTeam = new LCSTeam
                {
                    teamID = Guid.NewGuid(),
                    name = "NotTSMv" + i,
                    place = i,
                    roaster = new List<Player>()
                };
                for (int playerNumber = 0; playerNumber <= 4; playerNumber++)
                {
                    dubbyLCsTeam.roaster.Add(new Player(Guid.NewGuid(),"PlayerNumber", (10D * playerNumber) / 3, playerNumber));
                };
                lcsTeamsDictionary.Add(i, dubbyLCsTeam);
            }
        }

    }
}