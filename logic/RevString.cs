using System.Text;

namespace logic
{
    class RevString
    {
        public static void Rev()
        {
            StringBuilder rev1 = new StringBuilder();
            string str = "ABCDEF";
            Char[] rev = str.ToCharArray();
            for (int i = rev.Length - 1; i >= 0; i--)
            {
                rev1.Append(rev[i]);
            }
            Console.WriteLine(rev1.ToString());

        }
    }



}

