using System.Threading;

//[assembly: ExceptionPolicyAttribute(AttributeTargetTypes = "TheOnlineOne.DataService.*", AspectPriority = 1)]
//[assembly: ValidateMethodArguments(AttributeTargetTypes = "TheOnlineOne.DataService.*", AspectPriority = 2)]
//[assembly: SecureMethodArgumentsAttribute(AttributeTargetTypes = "TheOnlineOne.DataService.*", AspectPriority = 3)]




namespace OnMethodBoundaryExample.After
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
