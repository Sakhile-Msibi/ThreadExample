using System;
using System.Threading;

namespace ThreadExample
{
    class Program
    {
        public static void Thread1()
        {
            Console.WriteLine("Thread 1");
            Thread.Sleep(1000);
        }

        public static void Thread2()
        {
            Console.WriteLine("Thread 2");
            Thread.Sleep(1000);
        }

        public static void Thread3()
        {
            Console.WriteLine("Thread 3");
            Thread.Sleep(1000);
        }

        static void Main(string[] args)
        {
            Thread THR1 = new Thread(Thread1);
            Thread THR2 = new Thread(Thread2);
            Thread THR3 = new Thread(Thread3);

            //THR2.Priority = ThreadPriority.Lowest;
            //THR3.Priority = ThreadPriority.AboveNormal;
            THR1.Start();
            THR1.Join();
            THR3.Start();
            THR3.Join();
            THR2.Start();
            

            //Console.WriteLine("The priority of Thread 1 is: {0}",
            //                                  THR1.Priority);

            //Console.WriteLine("The priority of Thread 2 is: {0}",
            //                                      THR2.Priority);

            //Console.WriteLine("The priority of Thread 3 is: {0}",
            //                                      THR3.Priority);
        }
    }
}
