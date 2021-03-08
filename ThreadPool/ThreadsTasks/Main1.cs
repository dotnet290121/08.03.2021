using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadsTasks
{
    class Main_
    {
        public static void Main1()
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            Thread t1 = new Thread(() =>
            {
                // 0.05
                Thread t2 = new Thread(() =>
                {
                    Thread.Sleep(5000);
                    Console.WriteLine("I am background thread ...");
                });
                Thread.Sleep(500);
                Console.WriteLine("I am background thread ...");
                t2.Join(); // t1 is waiting for t2
            });
            t1.IsBackground = false; // default
            t1.IsBackground = true;
            t1.Start(); // 0.001
            //Thread.Sleep(200);
            //t1.Abort

            //t1.Suspend
            //t1.Resume

            // 0.002
            t1.Join(); // main thread will not wait for t1 
        }

    }
}
