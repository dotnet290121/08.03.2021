using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadsTasks
{
    class Program
    {
        static int[] counter = new int[1];
        static void MyWork()
        {
            for (int i = 0; i < 1000; i++)
            {
                int j = i * 5;
            }
            counter[0]++;
        }
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            // ignite - block

            List<Thread> threads = new List<Thread>();
            int max = 1200;

            // penalty time

            for (int i = 0; i < max; i++)
            {
                //Thread t = new Thread(MyWork);
                //t.Start();
                //threads.Add(t);
                ThreadPool.QueueUserWorkItem((o) => { MyWork(); });
            }

            while (counter[0] < 1000)
            {
                Thread.Sleep(1);
            }

            Console.WriteLine($"It took {sw.ElapsedMilliseconds}");
            sw.Stop();
        }
    }
}
