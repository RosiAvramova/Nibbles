using System;
using System.Collections.Generic;

namespace Rosi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int testCases = int.Parse(Console.ReadLine());
            for (int i = 0; i < testCases; i++)
            {
                int bytes = int.Parse(Console.ReadLine());
                if (bytes % 4 == 0)
                {
                    Console.WriteLine("Good");
                }
                else
                {
                    Console.WriteLine("Not Good");
                }
            }






        }
    }
}
