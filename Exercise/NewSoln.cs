using System;

namespace Exercise
{
    class NewSoln
    {
        public static void TryParse() { 
    
        Console.WriteLine("Enter a any number from 0 to 10 ");
            string user = Console.ReadLine();
            bool valid = int.TryParse(user,out int number);
            if(valid&&number>=1&& number <= 10)
            {
                Console.WriteLine($"Valid number: {number}");
            }
            else {
                Console.WriteLine($"InValid number: {number}");
            }
        }

    }
}
