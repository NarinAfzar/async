using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thread
{
    class Program
    {
        static void Main(string[] args)
        {
            Function1();
            Function2();
            Console.ReadKey();
        }
        static private void Function1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Function1 i={i}");
            }
        }

        static private void Function2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Function2 i={i}");
            }
        }

    }
}
