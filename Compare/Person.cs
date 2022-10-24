using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare
{
    class Person : IComparable<Person>
    {
        public string personName;
        public int personAge;
        int result;

        public Person(string name, int age)
        {
            this.personName = name;
            this.personAge = age;
        }
        
        public string GetInfo()
        {
            return $"Person: {personName}";
        }

        public int CompareTo(Person other)
        {
            if (other is Person personToCompare)
            {
                if (personToCompare.personName == this.personName || personToCompare.personAge == this.personAge)
                {
                    return 0;
                }
                else if (this.personAge < personToCompare.personAge)
                {
                    return -1;
                }
                else
                {
                    return 1;
                }
            }
            throw new ArgumentException("obj is not person class");
        }

        public static bool operator < (Person person1, Person person2)
        {
            return person1.CompareTo(person2) < 0;
        }
        public static bool operator >(Person person1, Person person2)
        {
            return person1.CompareTo(person2) > 0;
        }
        public static bool operator ==(Person person1, Person person2)
        {
            return person1.CompareTo(person2) == 0;
        }
        public static bool operator !=(Person person1, Person person2)
        {
            return person1.CompareTo(person2) != 0;
        }

    }
}
