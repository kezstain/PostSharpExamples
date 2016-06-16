using System;
using System.Diagnostics;
using PostSharp.Aspects;

namespace OnmethodBoundaryAfter
{
    [Serializable]
    public sealed class StopwatcherAttribute : OnMethodBoundaryAspect
    {
        // These fields are initialized at runtime. They do not need to be serialized.
        [NonSerialized] private string _methodName;

        [NonSerialized]
        private Stopwatch stopWatch;

        public StopwatcherAttribute()
        {
        }

        public StopwatcherAttribute(string something)
        {
        }

        // Invoked at runtime before that target method is invoked.
        public override void OnEntry(MethodExecutionArgs args)
        {
            _methodName = args.Method.ToString();

            stopWatch = new Stopwatch();
            stopWatch.Start();
        }

        // Invoked at runtime after the target method is invoked (in a finally block).
        public override void OnExit(MethodExecutionArgs args)
        {
            stopWatch.Stop();

            Console.WriteLine(_methodName + ": " + stopWatch.ElapsedMilliseconds);
        }
    }
}
