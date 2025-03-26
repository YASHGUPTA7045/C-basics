namespace Inheritance
{
    class Const
    {
        private string Name;
        private int Roll;
        private int Age;
        public Const(string Name, int Roll, int Age)
        {
            this.Roll = Roll;
            this.Name = Name;
            this.Age = Age;
        }
        public void Display()
        {
            Console.WriteLine($"Name: {Name}, Roll: {Roll}, Age: {Age}");
        }

    }
}
