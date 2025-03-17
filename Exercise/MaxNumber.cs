using System;

namespace Exercise
{
    class MaxNumber
{
    public static void Maxcheck() {
            try
            {
                Console.WriteLine("Enter the first number");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Second number");
                int num2 = Convert.ToInt32(Console.ReadLine());
                int MaxNumber;
                if (num1 > num2)
                {
                    MaxNumber = num1;
                }
                else { MaxNumber = num2; }
                Console.WriteLine($"the max num betn {num1} and {num2} is {MaxNumber}");
            } catch(Exception ex)
            {
                Console.WriteLine("not enter the valid number");
                Console.WriteLine($"Error:{ex.Message}");
            }
           
        }
}
}
