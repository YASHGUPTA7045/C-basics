using System;

namespace Exercise
{
    class Divisibility
    {
        public static void DivisCheck()
        {
            int count = 0;
            for (int n = 0; n <= 100; n++)
            {
                if (n % 3 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"the total number divisible by 3 from 1 to 100 is:{count}");

        }
    }
}
