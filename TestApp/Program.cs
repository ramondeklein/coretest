using System;
using System.Configuration;
using System.ComponentModel;
using PropertyChanged;

namespace CoreTest
{
    public class Person : INotifyPropertyChanged
    {
        public string Name { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var initialName = ConfigurationManager.AppSettings["initialName"];

            var person = new Person { Name = initialName };
            Console.WriteLine($"Person: {person.Name}");
            person.PropertyChanged += (s, e) => Console.WriteLine($"Name changed to '{person.Name}'");
            person.Name = "Frank";
        }
    }
}
