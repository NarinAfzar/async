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
            obj1.IsBackground = true;
            obj1.Start();
            Console.WriteLine("This is End");
        }
        static private void Function1()
        {
            Console.WriteLine("First");
            Console.ReadKey();
            Console.WriteLine("Second");
        }

     

    }
}
