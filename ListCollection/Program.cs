using System;
using System.Collections.Generic;


namespace ListCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int> { 10, 20, 30 };
            List<int> newList = new List<int> { 40, 50, 60 };
            myList.AddRange(newList);
            foreach (int i in myList)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("capacity:" + myList.Capacity);
            Console.WriteLine("count:" + myList.Count);
            Console.WriteLine("-----------");

            //Console.WriteLine(myList[4]);

            /*
            List<int> otherList = new List<int>() { 50, 60, 70 };
            myList.AddRange(otherList);

            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }
            Console.WriteLine("-----------");
            Console.WriteLine("capacity:" + myList.Capacity);
            Console.WriteLine("count:" + myList.Count);
            Console.WriteLine("---------");

            myList.InsertRange(1, otherList);
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }
            */
            myList.Insert(1, 40);
            myList.Insert(6, 40);

            foreach (int i in myList)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("capacity:" + myList.Capacity);
            Console.WriteLine("count:" + myList.Count);
            Console.WriteLine("-----------");

            //int ind = 9;
            //if (ind < myList.Count)
            //{
            //    myList.RemoveAt(ind);

            //}
            //else
            //{
            //    Console.WriteLine("Can not be removed");
            //}
            /*
            myList.RemoveRange(1, 3);
            Console.WriteLine("---------");
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }
            myList.RemoveAll(item => item < 1);
            Console.WriteLine("-----------------");
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }
            */
            /*
            myList.Clear();
            Console.WriteLine("--------");
            Console.WriteLine("Count: " + myList.Count);
            */

            int n = myList.IndexOf(40);
            int n2 = myList.IndexOf(40, n + 1);
            Console.WriteLine("Next Index: " + n2);
            int n3 = myList.IndexOf(40, n2 + 1);
            Console.WriteLine("Next Index: " + n3);

            List<int> preSortedList = new List<int> { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            foreach (int i in preSortedList)
            {
                Console.WriteLine(i);
            }
            // Binary search is faster but it requires pre-sorted list 
            // Result is same for both linear and binary search
            int x = preSortedList.BinarySearch(80);
            Console.WriteLine("Item is found at : " + (x + 1) + "th position");

            // contains is better than IndexOf if we are not interested in index
            bool b = preSortedList.Contains(100);// returns True or False
            Console.WriteLine(b);



        }
    }
}
