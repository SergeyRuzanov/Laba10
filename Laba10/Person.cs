using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba10
{
    enum Gender
    {
        Male,
        Female
    }

    enum Specialty
    {
        Engineer,
        Working,
        Administration
    }
    abstract class Person
    {
        public Person(string firstname, string surname, Gender _gender)
        {
            this.Firstname = firstname;
            this.Surname = surname;
            this.gender = _gender;
        }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public Gender gender { get; set; }
        public static List<Person> GetGender(Person[] people, Gender gender)
        {
            List<Person> Males = new List<Person>();
            foreach (Person person in people)
            {
                if (person.gender == gender)
                {
                    Males.Add(person);
                }
            }
            return Males;
        }

        public static List<Person> GetPeopleSpecialty(Person[] people, Specialty specialty)
        {
            List<Person> peopleSpec = new List<Person>();
            foreach (Person person in people)
            {
                if (person is Engineer & specialty == Specialty.Engineer)
                {
                    peopleSpec.Add(person);
                }
                else if (person is Working & specialty == Specialty.Working)
                {
                    peopleSpec.Add(person);
                }
                else if (person is Administration & specialty == Specialty.Administration)
                {
                    peopleSpec.Add(person);
                }
            }
            return peopleSpec;
        }

    }
}
