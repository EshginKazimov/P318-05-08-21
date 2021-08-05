using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphism
{
    class Person : Alive
    {
        public string Name;
        public string Surname;
        public int Age;

        public Person(string name, string surname, int age, int weight) : base(weight)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        //Polymorphism
        public virtual string GetInfo()
        {
            return $"{Name} {Surname} {Age}";
        }
    }
}
