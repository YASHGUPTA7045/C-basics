using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Test
    {
        public static void Main()
        {
            //Banking acc = new Banking();
            //acc.Deposit(-1);
            //acc.Deposit(200);
            //acc.withdraw(50);
            //Console.WriteLine($"Final Balance: {acc.GetBalance()}");
            //Const sc = new Const("ram",12,14 );
            //sc.Display();
            ////Inherit tx = new Inherit();
            Inherit myAnimal = new Inherit();
          
            myAnimal.Hello();

        }
    }
}
