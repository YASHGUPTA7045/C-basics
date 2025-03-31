namespace logic
{
    class WordCount
    {

        public static void WordC()
        {
            string Text = "hello my name is yash is name ";
            string[] Word = Text.Split(' ');
            Dictionary<string, int> Abc = new Dictionary<string, int>();

            foreach (string Words in Word)
            {
                if (Abc.ContainsKey(Words))
                {
                    Abc[Words]++;
                }
                else
                {
                    Abc[Words] = 1;
                }
            }

            foreach (var sd in Abc)
            {
                Console.WriteLine($"{sd.Key} : {sd.Value}");
            }
        }

    }
}
