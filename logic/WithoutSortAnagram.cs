namespace logic
{
    class WithoutSortAnagram
    {
        public static void Anagram()
        {
            Console.WriteLine("enter the first String");
            string str1 = Console.ReadLine();
            Console.WriteLine("enter the second string");
            string str2 = Console.ReadLine();
            string input1 = str1.ToLower();
            string input2 = str2.ToLower();
            if (input1.Length != input2.Length)
            {
                Console.WriteLine("not a anagram");
                return;
            }
            int[] chararr = new int[256];
            for (int i = 0; i < input2.Length; i++)
            {
                chararr[input1[i]]++;
                chararr[input2[i]]--;

            }
            foreach (int count in chararr)
            {
                if (count != 0)
                {
                    Console.WriteLine("not aani");
                    return;
                }


            }
            Console.WriteLine("ANgram");
        }

    }



}

