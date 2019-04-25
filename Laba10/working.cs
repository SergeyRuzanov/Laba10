using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba10
{
    enum Category
    {
        Beginner,
        Middle,
        God
    }
    class Working : Person
    {
        public Working(string firstname, string surname, Gender _gender, Category _category) : base(firstname, surname, _gender)
        {
            this.category = _category;
        }
        public Category category { get; set; }
        public override string ToString()
        {
            return $"{this.Surname} {this.Firstname}; {this.gender}; Specialty: Working; Category: {this.category}";
        }
    }
}
