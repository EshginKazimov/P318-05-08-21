using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphism
{
    class Student : Person
    {
        public string Group;

        public Student(string name, string surname, int age, string group, int weight) : base(name, surname, age, weight)
        {
            Group = group;
        }

        public override string GetInfo()
        {
            //return $"{base.GetInfo()} {Group}";
            return base.GetInfo() + " " + Group;
        }
    }
}
