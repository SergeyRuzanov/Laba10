using System.Collections.Generic;

namespace Laba10
{
    class ComparerPerson : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            if (x.gender > y.gender)
            {
                return 1;
            }
            else if (x.gender < y.gender)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
