using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphism
{
    //Inheritance
    class Developer : Person
    {
        public string Position;

        public Developer(string name, string surname, int age, string position, int weight) : base(name, surname, age, weight)
        {
            Position = position;
        }

        //Polymorphism
        public override string GetInfo()
        {
            return base.GetInfo() + " " + Position + " " + Weight;
        }
    }
}
