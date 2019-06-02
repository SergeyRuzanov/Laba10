using System;
using System.Collections.Generic;

namespace Laba10
{
    public class Administration : Person
    {
        public Administration(string firstname, string surname, Gender gender, int experience) : base(firstname, surname, gender)
        {
            this.Experience = experience;
        }
        private int _experiance = 0;
        public int Experience {
            get
            {
                return _experiance;
            }
            set
            {
                if (value >= 0)
                {
                    _experiance = value;
                }
                else
                {
                    throw new ArgumentException("Experiance is wrong");
                }
            }
        }
        public static List<Administration> GetAdministrationsBetterOf(Person[] people, int experienceLight)
        {
            List<Administration> peopleExp = new List<Administration>();
            foreach (Person person in people)
            {
                Administration personAdministrator = person as Administration;
                if (personAdministrator?.Experience >= experienceLight)
                {
                    peopleExp.Add(personAdministrator);
                }
            }
            return peopleExp;
        }
        public override string ToString()
        {
            return $"{this.Surname} {this.Firstname}; {this.gender}; Specialty: Administrator; Experience: {this.Experience}";
        }
    }
}
