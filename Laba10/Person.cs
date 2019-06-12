using System;
using System.Collections.Generic;

namespace Laba10
{
    public enum Gender
    {
        Male,
        Female
    }

    public enum Specialty
    {
        Engineer,
        Working,
        Administration
    }
    public abstract class Person : IComparable<Person>
    {
        public Person(string firstname, string surname, Gender _gender)
        {
            this.Firstname = firstname;
            this.Surname = surname;
            this.gender = _gender;
        }

        private string _firstname;
        private string _surname;
        public string Firstname
        {
            get
            {
                return _firstname;
            }
            set
            {
                if (value != "")
                {
                    _firstname = value;
                }
                else
                {
                    throw new ArgumentException("Firstname is empty");
                }
            }
        }

        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                if (value != "")
                {
                    _surname = value;
                }
                else
                {
                    throw new ArgumentException("Surname is empty");
                }
            }
        }
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

        public int CompareTo(Person other)
        {
            return Surname.CompareTo(other.Surname);
        }
        public override int GetHashCode()
        {
            return Surname.GetHashCode() + Firstname.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if (!(obj is Person))
            {
                return false;
            }
            else
            {
                Person person = (Person)obj;
                return this.Firstname == person.Firstname && this.Surname == person.Surname;
            }
        }
    }
}
