using System;
using System.Collections.Generic;


namespace ListCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>(10) { 10, 20, 30 };

            myList.Add(40);
            foreach (int i in myList)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-----------");
            Console.WriteLine("capacity:" + myList.Capacity);
            Console.WriteLine("count:" + myList.Count);
            //Console.WriteLine(myList[4]);


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
            //int ind = 9;
            //if (ind < myList.Count)
            //{
            //    myList.RemoveAt(ind);

            //}
            //else
            //{
            //    Console.WriteLine("Can not be removed");
            //}
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
            myList.Clear();
            Console.WriteLine("--------");
            Console.WriteLine("Count: " + myList.Count);

        }
    }
}
