namespace logic
{
    class Swapping
    {
        public static void Swap1()
        {
            int a = 10, b = 25;
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"the value of a:{a} and b:{b}");
        }
    }



}
