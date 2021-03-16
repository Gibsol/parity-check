using System;

namespace Parity_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = int.Parse(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine(a + " это четное число");
            }else
            {
                Console.WriteLine(a + " это нечетное число");
            }
            Console.ReadLine();
        }
    }
}
