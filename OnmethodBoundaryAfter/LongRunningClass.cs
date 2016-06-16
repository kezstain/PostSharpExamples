using System.Threading;

namespace OnmethodBoundaryAfter
{
    public class LongRunningClass
    {

        [Stopwatcher]
        public void LongRunningMethod()
        {
            for (var i = 0; i < 1000; i++)
            {
                if (i % 3 == 0)
                    Thread.Sleep(10);
            }
        }

        [Stopwatcher]
        public void LongRunningMethod2()
        {
            for (var i = 0; i < 1000; i++)
            {
                if (i % 3 == 0)
                    Thread.Sleep(10);
            }
        }
    }
}
