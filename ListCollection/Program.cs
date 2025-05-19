using System;
using System.Collections.Generic;


namespace ListCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>();
            myList.Add(0);
            myList.Add(1);
            foreach (int i in myList)
            {
                Console.WriteLine(i);
            }

        }
    }
}
