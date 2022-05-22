using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace CrackCodeInterviewPg61
{
    /// <summary>
    /// Need to make sure I am super confident in the following Main sections
    /// 
    /// Data Structures
    ///     LinkedList*, Trees, Tries, and Graphs*,Stacks & Queues*,Heaps*,Vectors/ArrayLists*,HashTables*
    ///     
    /// Algorithms
    ///     Breadth-First Search,Depth-First Search,Binary Search,Merge Sort,Quick Sort
    ///     
    /// Concepts
    ///     Bit Manipuluation, Memory (Stack Vs. Heap), Recursion, Dynamic Programming, Big O Time & Space
    ///     
    /// </summary>
    class Program
    {

        static void Main(string[] args)
        {
            List<int> bigList = new List<int>();
            Random r = new Random();
            int oneMil = 1000000;
            double oneMilPow = Math.Pow(2, 32);
            Stopwatch stopwatch = new Stopwatch();

            for (int i = 0; i < oneMil; i++)
            {
                bigList.Add(r.Next(0, 100));
            }
            int choice = 0;
            switch (choice)
            {
                case 0:
                    DataStructure(bigList, stopwatch);
                    break;
                default:
                    break;
            }
            Console.Read();
        }

        /// <summary>
        /// LinkedList*, Trees, Tries, and Graphs*,Stacks & Queues*,Heaps*,Vectors/ArrayLists*,HashTables*
        /// </summary>
        /// <param name="bigList"></param>
        /// <param name="stopwatch"></param>
        static public void DataStructure(List<int> bigList, Stopwatch stopwatch)
        {
            int sum = 0;
            #region NormalList
            Console.WriteLine("\n Normal List \n");
            List<int> normalList = new List<int>();
            stopwatch.Start();
            foreach (var item in bigList)
            {
                normalList.Add(item);
            }
            Console.WriteLine("Time to Fill normalList: " + stopWatchToString(stopwatch));
            stopwatch.Restart();
            normalList.Sort();
            Console.WriteLine("Time to Sort normalList: " + stopWatchToString(stopwatch));
            stopwatch.Restart();
            normalList.ForEach(item => sum = +item);
            Console.WriteLine("Time to Sum different way " + stopWatchToString(stopwatch));
            sum = 0;
            stopwatch.Restart();
            foreach (var item in normalList)
            {
                sum = +item;
            }
            Console.WriteLine("Time to Sum Normal way " + stopWatchToString(stopwatch));
            stopwatch.Stop();
            sum = 0;
            #endregion NormalList

            #region LinkedList
            //Normal list is always faster it seems. C#/.net has built in indexes for List
            Console.WriteLine("\n Linked List \n");
            LinkedList<int> linkedList = new LinkedList<int>();
            stopwatch.Restart();
            foreach (var item in bigList)
            {
                linkedList.AddFirst(item);
            }
            Console.WriteLine("Time to Fill linkedList: " + stopWatchToString(stopwatch));
            stopwatch.Restart();
            foreach (var item in linkedList)
            {
                sum = +item;
            }
            Console.WriteLine("Time to Sum normal way " + stopWatchToString(stopwatch));
            stopwatch.Stop();
            sum = 0;
            #endregion LinkedList

            #region Trees
            //TODO: Need to come back to this
            BinarySearchTree root;
            //https://www.c-sharpcorner.com/article/tree-data-structure/

            #endregion Trees

            #region Trie
            //TODO: Need to come back to this
            #endregion Trie

            #region Graph
            //TODO: Need to come back to this
            #endregion Graph
        }

        static public string stopWatchToString(Stopwatch stopwatch) {
            stopwatch.Stop();
            TimeSpan timeSpan = new TimeSpan();
            timeSpan = stopwatch.Elapsed;
            string tsString = string.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds,
            timeSpan.Milliseconds / 10);
            return tsString;
        }
    }

    public class linkedList {
        node head = null;
        public class node {
            public int val;
            public node next;

            public node(int val)
            {
                this.val = val;
            }
        }
        node sortedMerge(node a, node b)
        {
            node result = null;
            /* Base cases */
            if (a == null)
                return b;
            if (b == null)
                return a;

            /* Pick either a or b, and recur */
            if (a.val <= b.val)
            {
                result = a;
                result.next = sortedMerge(a.next, b);
            }
            else
            {
                result = b;
                result.next = sortedMerge(a, b.next);
            }
            return result;
        }

        node mergeSort(node h)
        {
            // Base case : if head is null
            if (h == null || h.next == null)
            {
                return h;
            }

            // get the middle of the list
            node middle = getMiddle(h);
            node nextofmiddle = middle.next;

            // set the next of middle node to null
            middle.next = null;

            // Apply mergeSort on left list
            node left = mergeSort(h);

            // Apply mergeSort on right list
            node right = mergeSort(nextofmiddle);

            // Merge the left and right lists
            node sortedlist = sortedMerge(left, right);
            return sortedlist;
        }

        // Utility function to get the
        // middle of the linked list
        node getMiddle(node h)
        {
            // Base case
            if (h == null)
                return h;
            node fastptr = h.next;
            node slowptr = h;

            // Move fastptr by two and slow ptr by one
            // Finally slowptr will point to middle node
            while (fastptr != null)
            {
                fastptr = fastptr.next;
                if (fastptr != null)
                {
                    slowptr = slowptr.next;
                    fastptr = fastptr.next;
                }
            }
            return slowptr;
        }

        void push(int new_data)
        {
            /* allocate node */
            node new_node = new node(new_data);

            /* link the old list off the new node */
            new_node.next = head;

            /* move the head to point to the new node */
            head = new_node;
        }

        // Utility function to print the linked list
        void printList(node headref)
        {
            while (headref != null)
            {
                Console.Write(headref.val + " ");
                headref = headref.next;
            }
        }
    }
}
