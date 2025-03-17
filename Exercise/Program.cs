using System;

namespace Exercise
{

    class Program
    {
        public class Sort
        {
            public static void SortNum()
            {

                Console.WriteLine("Enter number separated by commas (e.g., 5,3,8,1,4):");
                string input = Console.ReadLine();
                string[] numberStrings = input.Split(',');

                int[] numbers = new int[numberStrings.Length];

                for (int i = 0; i < numberStrings.Length; i++)
                {
                    numbers[i] = Convert.ToInt32(numberStrings[i].Trim());
                }

                Array.Sort(numbers);

                Console.WriteLine($"The maximum number is: {numbers[numbers.Length - 1]}");
            }

        }
        static void Main(string[] args)
        {
            Sort.SortNum();
            //UserInputSum.Sum();
            //NewSoln.TryParse();
            //Validnum.check();
            //MaxNumber.Maxcheck();
            //Image.CheckingImage();
            //Speed.SpeedCheck();
            //Divisibility.DivisCheck();
            //Factorial.FactCount();
            //Guess.GuessNum();
        }
    }
}
