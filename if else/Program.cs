using System;

namespace if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;

            a = int.Parse(Console.ReadLine());

            if (a % 2==1)
            {
                Console.WriteLine("Число нечетное");
            }

            else

            {
                Console.WriteLine("Число четное");
            }
        }
    }
}
