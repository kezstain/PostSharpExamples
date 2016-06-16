using System;
using PostSharp;
using System.Threading;

namespace OnMethodBoundaryExample.After
{
    public class Program
    {
        static void Main(string[] args)
        {
            var cls = new LongRunningClass();
            cls.LongRunningMethod();
            cls.LongRunningMethod2();
            Console.WriteLine("Press key to close");
            Console.Read();
        }
    }
}
