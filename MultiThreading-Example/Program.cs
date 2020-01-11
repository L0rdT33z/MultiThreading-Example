using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread Started");
            //Creating Threads
            Thread t1 = new Thread(Method1)
            {
                Name = "Thread1"
            };
            Thread t2 = new Thread(Method2)
            {
                Name = "Thread2"
            };
            Thread t3 = new Thread(Method3)
            {
                Name = "Thread3"
            };
            //Executing the methods
            t1.Start();
            t2.Start();
            t3.Start();
            Console.WriteLine("Main Thread Ended");
            Console.Read();
        }
        static void Method1()
        {
            while (true)
            {
                Console.WriteLine("Msg from Thread1");
                Thread.Sleep(100);
            }
        }
        static void Method2()
        {
            while (true)
            {
                Console.WriteLine("Msg from Thread2");
                Thread.Sleep(100);
            }
        }
        static void Method3()
        {
            while (true)
            {
                Console.WriteLine("Msg from Thread3");
                Thread.Sleep(100);
            }
        }


    }
}
