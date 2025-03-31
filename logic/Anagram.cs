namespace logic
{
    class Anagram
    {
        public static void String()
        {
            string str1 = "tea";
            string str2 = "eat";
            char[] s1 = str1.ToCharArray();
            char[] s2 = str2.ToCharArray();
            if (str1.Length != str2.Length)
            {
                Console.WriteLine("not anagaram");
                return;
            }
            Array.Sort(s2);
            Array.Sort(s1);

            for (int i = 0; i < s1.Length; i++)
            {
                if (s2[i] != s1[i])
                {
                    Console.WriteLine("It is not a anagram");
                }

            }


            Console.WriteLine("anagram");
        }

    }



}

