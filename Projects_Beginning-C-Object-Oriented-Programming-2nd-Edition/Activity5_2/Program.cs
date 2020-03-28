using System;
using System.Collections.Generic;   // this is necessary to include all the data structures such as List, etc.

namespace Activity5_2
{
    class Program
    {
        public static List<string> items = new List<string>();
        static List<int> numList = new List<int>();
        static void Main(string[] args)
        {
            LoadList(10);
            foreach (int i in numList)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
        static void LoadList(int imax)
        {
            for (int i = 1; i <= imax; i ++)
            {
                numList.Add(i);
            }
        }
    }
}
