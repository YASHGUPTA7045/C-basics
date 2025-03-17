using System;

namespace Exercise
{
    class UserInputSum
    {
        public static void Sum()
        {
            Console.WriteLine("Enter numbers to add and type 'ok'to calculate:");

            int sum = 0;

            while (true)
            {
                string userInput = Console.ReadLine();

                if (userInput.ToUpper() == "OK")
                {
                    break;
                }

                else if (int.TryParse(userInput, out int num))
                {
                    sum = sum + num;
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter a number or 'OK' to finish.");
                }
            }

            Console.WriteLine($"The sum of entered numbers is {sum}");
        }
    }
}
