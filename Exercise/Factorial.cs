using System;

namespace Exercise
{
    public class Factorial
    {
        public static void FactCount()
        {
            Console.WriteLine("Enter the number to find Factorial");
            int Num = Convert.ToInt32(Console.ReadLine());
            int Fact = 1;
            for (int i = 1; i <= Num; i++)
            {
                Fact = i * Fact;
            }
            Console.WriteLine($"the  Given number is {Num} And the Fact Count is {Fact}");
        }
    }
}
