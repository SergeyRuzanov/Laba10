namespace Laba10
{
    public class Engineer : Working
    {
        public Engineer(string firstname, string surname, Gender gender, Category category) : base(firstname, surname, gender, category) { }
        public override string ToString()
        {
            return $"{this.Surname} {this.Firstname}; {this.gender}; Specialty: Engineer; Category: {this.category}";
        }

        public Working BaseWorking
        {
            get
            {
                return new Working(Firstname, Surname, gender, category);
            }
        }
    }
}
