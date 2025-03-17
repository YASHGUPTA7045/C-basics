using System;

namespace Exercise
{
    class Speed
    {
        public static void SpeedCheck()
        {
            try
            {
                Console.WriteLine("enter the speed limit");
                int Limit = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter the speed of car");
                int CarSpeed = Convert.ToInt32(Console.ReadLine());
                int Demerit = 0;
                int Calculation;
                if (CarSpeed <= Limit)
                {
                    Console.WriteLine("OK");
                }
                else
                {
                    if (CarSpeed > Limit)
                    {
                        Calculation = CarSpeed - Limit;
                        Demerit = Calculation / 5;
                        Console.WriteLine($"the demerit points is {Demerit}");
                        if (Demerit > 12)
                        {
                            Console.WriteLine($"the demerit points is {Demerit} hence your licence has been suspended");
                        }
                    }

                }

            }

            catch (Exception ex)
            {
                Console.WriteLine($"Error {ex.Message}");
            }

        }
    }
}
