using System;

namespace Exercise
{
    class Image
    {
        public static void CheckingImage()
        {
            try
            {
                Console.WriteLine("Enter the height of img");
                int Height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the width of img");
                int Width = Convert.ToInt32(Console.ReadLine());

                if (Height <= 0 || 0 >= Width)
                {

                    Console.WriteLine("plz write positive input");
                }
                else
                {
                    if (Height > Width)
                    {
                        Console.WriteLine("the given img is protrait");
                    }
                    else if (Width > Height)
                    {
                        Console.WriteLine("the given img is landscape");
                    }
                    else { Console.WriteLine("the given img is square"); }

                }

            }
            catch (Exception ex) {
                Console.WriteLine($"Error:{ex.Message}");
            
            } }
            
    }
}
