using System;

namespace Laba10
{
    public enum Category
    {
        Beginner,
        Middle,
        God
    }
    public class Working : Person, ICloneable
    {
        public Working(string firstname, string surname, Gender _gender, Category _category) : base(firstname, surname, _gender)
        {
            this.category = _category;
        }

        public Category category { get; set; }

        public object Clone()
        {
            return new Working(this.Firstname, this.Surname, this.gender, this.category);
        }

        public override string ToString()
        {
            return $"{this.Surname} {this.Firstname}; {this.gender}; Specialty: Working; Category: {this.category}";
        }
    }
}
