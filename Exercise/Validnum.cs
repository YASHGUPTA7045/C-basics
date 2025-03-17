using System;

namespace Exercise
{
    class Validnum
    {
        public static void check()
        {
            Console.WriteLine("enter a number from 1 to 10");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 1 && number <= 10)
            {
                Console.WriteLine("VALID");
            }
            else
            {
                Console.WriteLine("INVALID");
            }

        }
    }
}
