using System;

namespace Exercise
{
    public class Guess
    {
        public static void GuessNum()
        {
            Console.WriteLine("Enter the TO guess Secret Number you Have 4 attempt");
            Random sc = new Random();
            int Number = sc.Next(1, 11);
            Console.WriteLine($"the Random generated number is {Number}");
            for (int i = 0; i < 4; i++)
            {
                int userinput = Convert.ToInt32(Console.ReadLine());
                if (Number == userinput)
                {
                    Console.WriteLine("you won");
                    break;
                }
                Console.WriteLine($"You guess wrong Number try again! And your attempt left is {3 - i}");
            }
            Console.WriteLine($"You had made the Maximum number of attempt and the Secret number is  {Number} ");
        }
    }
}
