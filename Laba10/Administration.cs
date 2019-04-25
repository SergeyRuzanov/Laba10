using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba10
{
    class Administration : Person
    {
        public Administration(string firstname, string surname, Gender gender, int experience) : base(firstname, surname, gender)
        {
            this.Experience = experience;
        }
        public int Experience { get; set; }
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
