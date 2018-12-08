using System;
using System.Configuration;
using System.ComponentModel;
using CoreLib;

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

            var dog = new Dog { Name = "Bello" };
            Console.WriteLine($"Dog: {dog.Name}");
            dog.PropertyChanged += (s, e) => Console.WriteLine($"Dog's name changed to '{dog.Name}'");
            dog.Name = "Samson";
        }
    }
}
