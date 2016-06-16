using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OnMethodBoundaryExample.Before
{
    class Program
    {
        static void Main(string[] args)
        {
            LongRunningMethod();
            LongRunningMethod2();
            Console.WriteLine("Press key to close");
            Console.Read();
        }

        public static void LongRunningMethod()
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            for (var i = 0; i < 1000; i++)
            {
                if (i % 3 == 0)
                    Thread.Sleep(10);
            }

            stopWatch.Stop();

            var stackTrace = new StackTrace();
            Console.WriteLine(stackTrace.GetFrame(0).GetMethod().Name + ": " + stopWatch.ElapsedMilliseconds);
        }

        public static void LongRunningMethod2()
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            
            for (var i = 0; i < 1000; i++)
            {
                if (i % 3 == 0)
                    Thread.Sleep(10);
            }

            stopWatch.Stop();

            var stackTrace = new StackTrace();
            Console.WriteLine(stackTrace.GetFrame(0).GetMethod().Name + ": " + stopWatch.ElapsedMilliseconds);
        }
    }
}
