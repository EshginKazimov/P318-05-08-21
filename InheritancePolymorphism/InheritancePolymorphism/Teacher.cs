using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphism
{
    class Teacher : Person
    {
        public int Salary;

        public Teacher(string name, string surname, int age, int salary, int weight) : base(name, surname, age, weight)
        {
            Salary = salary;
        }

        public override string GetInfo()
        {
            return "Salam";
        }
    }
}
