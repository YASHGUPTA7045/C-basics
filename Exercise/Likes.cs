using System;
using System.Collections.Generic;

namespace Exercise
{
    class Likes
    {
        public static void LikesCount()
        {
            List<string> Numbers = new List<string>();
            string input;
            while (!string.IsNullOrEmpty(input = Console.ReadLine()))
            {
                Numbers.Add(input);
            }
            if (Numbers.Count == 1)
            {
                Console.WriteLine($" {Numbers[0]} likes your post");
            }
            else if (Numbers.Count == 2)
            {
                Console.WriteLine($"{Numbers[0]} and {Numbers[1]} like your post.");
            }
            else if (Numbers.Count > 2)
                Console.WriteLine($"{Numbers[0]}, {Numbers[1]} and {Numbers.Count - 2} others like your post.");
        }


    }
}

