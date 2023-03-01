using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoLinq.model
{
    public class PersonRepository 
    {
        private readonly List<Person> _personer;

        public PersonRepository(List<Person> personer)
        {
            _personer = personer;
        }

        /*
         * Metoder
         */


        public int MaxAge()
        {
            int maxage = 0;
            foreach (Person person in _personer)
            {
                if (person.Age > maxage)
                {
                    maxage = person.Age;
                }
            }
            return maxage;
        }

        public int MinAge()
        {
            int minage = int.MaxValue;
            foreach (Person person in _personer)
            {
                if (person.Age < minage)
                {
                    minage = person.Age;
                }
            }
            return minage;
        }

        public double GnsAge()
        {
            if (_personer is null || _personer.Count == 0)
            {
                return -1;
            }

            int sum = 0;
            foreach (Person person in _personer)
            {
                sum += person.Age;
            }

            return (sum * 1.0) / _personer.Count;
        }

        public List<Person> GetAllFrom(String city)
        {
            List<Person> list = new List<Person>();

            foreach (Person person in _personer)
            {
                if (person.City == city)
                {
                    list.Add(person);
                }
            }
            return list;
        }

        public List<Person> GetAllName(String name)
        {
            List<Person> list = new List<Person>();

            foreach (Person person in _personer)
            {
                if (person.Name == name)
                {
                    list.Add(person);
                }
            }
            return list;
        }

        public List<Person> GetAllFromAndOlderThan(String city, int age)
        {
            List<Person> list = new List<Person>();

            foreach (Person person in _personer)
            {
                if (person.City == city && person.Age >= age)
                {
                    list.Add(person);
                }
            }
            return list;
        }

    }
}
