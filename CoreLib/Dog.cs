using System.ComponentModel;

namespace CoreLib
{
    public class Dog : INotifyPropertyChanged
    {
        public string Name { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }

}
