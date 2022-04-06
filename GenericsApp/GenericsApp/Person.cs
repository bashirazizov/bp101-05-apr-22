using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsApp
{
    public class Person : Object
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public Person()
        {

        }
        public Person(string Name, string Surname, int Age)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Age = Age;
        }
        public override string ToString()
        {
            return $"{Name} - {Surname}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Person)
            {
                Person personToCompare = (Person)obj;
                if (personToCompare.Name == Name && personToCompare.Surname == Surname && personToCompare.Age == Age)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
