using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    class Student:Human, System.IComparable
    {
        int mark;

        public Student(string firstName, string lastName) : base(firstName, lastName)
        {

        }

        public int Mark { get; set; }

        public int CompareTo(object obj)
        {
            return mark.CompareTo(obj);
        }
    }

    
}
