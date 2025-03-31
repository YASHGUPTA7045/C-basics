namespace logic
{


    class SecondMax
    {
        public static void MaxNumber()
        {
            int[] Arr = { 1, 2, 3, 4, 5, 634, 64342, 64342, 45, 64, 232, 4, 5, 5, 625, 5, 52, 9000 };
            int Largest = 0;
            int SecLargest = 0;
            for (int i = 0; i < Arr.Length; i++)
            {
                if (Largest < Arr[i])
                {
                    SecLargest = Largest;

                    Largest = Arr[i];
                }
                else if (Arr[i] != Largest && SecLargest < Arr[i])
                {
                    SecLargest = Arr[i];
                }


            }
            Console.WriteLine($"largets Number is {Largest} And Seclargest is {SecLargest}");
        }
    }
}



