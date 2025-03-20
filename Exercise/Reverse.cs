using System;
namespace Exercise
{
    class Reverse
    {
        public static void ReverseName()
        {
            Console.WriteLine("enter your name");
            String names = Console.ReadLine();
            char[] charArray = names.ToCharArray();
            Array.Reverse(charArray);
            string NewNames = new string(charArray);
            Console.WriteLine($"{NewNames}");
        }
    }
}

