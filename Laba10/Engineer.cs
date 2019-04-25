using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba10
{
    class Engineer : Working
    {
        public Engineer(string firstname, string surname, Gender gender, Category category) : base(firstname, surname, gender, category) { }
        public override string ToString()
        {
            return $"{this.Surname} {this.Firstname}; {this.gender}; Specialty: Engineer; Category: {this.category}";
        }
    }
}
