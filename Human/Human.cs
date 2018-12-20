using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    class Human : IComparable<Human>
    {
       

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public int CompareTo(Human other)
        {
            int result = this.LastName.CompareTo(other.LastName);
            return result;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
