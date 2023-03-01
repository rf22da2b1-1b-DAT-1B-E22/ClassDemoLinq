using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoLinq.model
{
    public class Person
    {
        public String Name { get; set; }
        public int Age { get; set; }
        public String City { get; set; }

        public Person(string name, int age, string city)
        {
            Name = name;
            Age = age;
            City = city;
        }

        public Person():this("dummy",0,"")
        {
        }

        public override string ToString()
        {
            return $"{{{nameof(Name)}={Name}, {nameof(Age)}={Age.ToString()}, {nameof(City)}={City}}}";
        }
    }
}
