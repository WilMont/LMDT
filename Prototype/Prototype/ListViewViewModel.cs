using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Prototype
{
    class ListViewViewModel
    {
        public ObservableCollection<Person> PersonList { get; set; }
        public ListViewViewModel()
        {
            PersonList = new ObservableCollection<Person>
            {
                new Person(){ Name = "John", City = "Los Angeles" },
                new Person(){ Name = "Jannet", City = "London" },
                new Person(){ Name = "Jipal", City = "New Delhi" },
                new Person(){ Name = "Jean", City = "Paris" },
            };
        }
    }
    public class Person
    {
        public string Name { get; set; }
        public string City { get; set; }
    }
}
