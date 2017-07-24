using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread obj1 =new Thread(Function1);
            Thread obj2 = new Thread(Function2);

            obj1.Start();
            obj2.Start();

            Console.ReadKey();
        }
        static private void Function1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Function1 i={i}");
                Thread.Sleep(4000);
            }
        }

        static private void Function2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Function2 i={i}");
                Thread.Sleep(4000);
            }
        }

    }
}
