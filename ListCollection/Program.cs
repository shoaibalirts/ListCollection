using System;
using System.Collections.Generic;


namespace ListCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>(10) { 10, 20, 30 };
            myList.Add(1);
            Console.WriteLine(myList.Capacity);
            foreach (int i in myList)
            {
                Console.WriteLine(i);
            }
            //for (int i = 0; i < myList.Count; i++)
            //{
            //    Console.WriteLine(myList[i]);
            //}


        }
    }
}
