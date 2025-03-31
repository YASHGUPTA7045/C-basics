namespace logic
{
    class ReverseNum
    {
        public static void Reverse()
        {
            int Rev = 0;
            int Lastdigit;
            int Num = 12345;
            while (Num > 0)
            {
                Lastdigit = Num % 10;
                Rev = Rev * 10 + Lastdigit;
                Num = Num / 10;
            }
            Console.WriteLine(Rev);
        }
    }



}

