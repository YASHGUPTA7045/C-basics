using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise
{
    class Duplicate
    {
        public static void DuplicateNum()
        {
            List<int> Numbers = new List<int>();

            Console.WriteLine("Enter numbers to sort (Type 'Quit' to exit):");

            while (true)
            {
                Console.Write("Enter a number: ");
                string userInput = Console.ReadLine();

                if (userInput.ToUpper() == "QUIT")
                {
                    break;
                }

                if (int.TryParse(userInput, out int number))
                {
                    Numbers.Add(number);
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter a valid number.");
                }
            }

            Numbers.Sort();
            Console.WriteLine("Sorted Numbers:");

            foreach (int num in Numbers.Distinct())
            {
                Console.Write(num + " ");
            }

        }
    }
}
