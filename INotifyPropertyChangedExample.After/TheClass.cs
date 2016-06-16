using PostSharp.Patterns.Model;

namespace INotifyPropertyChangedExample.After
{
    [NotifyPropertyChanged(true)]
    public class TheClass
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}