using System;
using System.Collections.Generic;
namespace Exercise
{
    class Unique
    {
        public static void UniqueNum()
        {
            List<int> Number = new List<int>();
            Console.WriteLine("enter the 5 unique Number");
            while (Number.Count < 5)
            {
                Console.WriteLine($"enter a unique number {(Number.Count + 1)}");
                int num;
                if (!int.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("Invalid input! Please enter a number.");
                    continue;
                }

                if (Number.Contains(num))
                {
                    Console.WriteLine("Duplicate number! Try again.");
                }
                else
                {
                    Number.Add(num);
                }
            }
            Number.Sort();
            foreach (int num in Number)
            {
                Console.Write(num + " ");
            }
        }
    }
}

