using System;

namespace Laba10
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[] {
                new Working("Petya", "Meteliv", Gender.Male, Category.Middle),
                new Engineer("Alena", "Ivina", Gender.Female, Category.God),
                new Administration("Genadiy", "Agafonov", Gender.Male, 10),
                new Working("Anastasia", "Teplova", Gender.Female, Category.Beginner),
                new Administration("Lena", "Sizova", Gender.Female, 2)
            };

            foreach (Person person in people)
            {
                Console.WriteLine(person.ToString());
            }

            Console.WriteLine();
            Console.WriteLine("Gender of Male:");
            foreach (Person person in Person.GetGender(people, Gender.Male))
            {
                Console.WriteLine(person);
            }

            Console.WriteLine();
            Console.WriteLine("Specialty of Working:");
            foreach (Person person in Person.GetPeopleSpecialty(people, Specialty.Working))
            {
                Console.WriteLine(person);
            }

            Console.WriteLine();
            Console.WriteLine("Experience 4:");
            foreach (Person person in Administration.GetAdministrationsBetterOf(people, 4))
            {
                Console.WriteLine(person);
            }

            Console.WriteLine();
            Console.WriteLine("IComparable:");
            Array.Sort<Person>(people);
            foreach (Person person in people)
            {
                Console.WriteLine(person);
            }

            Console.WriteLine();
            Console.WriteLine("IComparer:");
            Array.Sort<Person>(people, new ComparerPerson());
            foreach (Person person in people)
            {
                Console.WriteLine(person);
            }

            Console.WriteLine();
            Console.WriteLine("IClonable:");
            Working w1 = new Working("Natalya", "Egorova", Gender.Female, Category.Middle);
            Working w2 = (Working)w1.Clone();
            Console.WriteLine("w1:");
            Console.WriteLine(w1);
            Console.WriteLine("w2:");
            Console.WriteLine(w2);
            Console.WriteLine();
            w1.Firstname = "Anya";
            Console.WriteLine("w1:");
            Console.WriteLine(w1);
            Console.WriteLine("w2:");
            Console.WriteLine(w2);

            Console.ReadKey();
        }
    }
}
