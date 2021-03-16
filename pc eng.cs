using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pc_eng
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = int.Parse(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine(a + " this is an even number");
            }
            else
            {
                Console.WriteLine(a + " this is an odd number");
            }
        }
    }
}
