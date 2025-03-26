namespace Inheritance
{
    public class Animal
    {
        private string Name;
        private int Age;
        private string Eats;
        public void setAge(int Age)
        {
            this.Age = Age;
        }
        public void setName(string Name)
        {
            this.Name = Name;
        }
        public void setEats(string Eats)
        {
            this.Eats = Eats;

        }
        public string getName()
        {
            return Name;
        }
        //public string getEats()
        //{
        //    Console.WriteLine("thet eat grass");
        //}
        public int getAge()
        {
            return Age;
        }
        public virtual void Hello()
        {
            Console.WriteLine("base");
        }
    }
}
