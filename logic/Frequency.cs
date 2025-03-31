namespace logic
{
    class Frequency
    {
        public static void Count()
        {
            int[] arr = { 1, 2, 3, 456, 21, 7, 6, 4, 54, 32, 4, 4, 3, 5, 3, 22, 4 };
            Array.Sort(arr);
            Dictionary<int, int> Num = new Dictionary<int, int>();
            foreach (int fre in arr)
            {
                if (Num.ContainsKey(fre))
                {
                    Num[fre]++;
                }
                else
                {
                    Num[fre] = 1;
                }
            }
            foreach (var item in Num)
            {
                Console.WriteLine($"{item.Key}:{item.Value}");
            }
        }
    }



}

