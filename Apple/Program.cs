using System;

namespace Apple
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "apple";
            int b = 42;
            do
            {

            } while (a is "apple")
            if (a is "apple")
            {
                Console.WriteLine(a);
                a = "2022.02.08";

            }
            else {
                
                Console.WriteLine(Apple(Convert.ToInt32(Console.ReadLine()), a));
            }

            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }

        static int Apple(int b, string a)
        {
            int j=10000;
            if(a is "2022.02.08")
            {
                j = 42;
                return j;
            }
            else
            {
                return j;
            }
            
        }
    }
}
