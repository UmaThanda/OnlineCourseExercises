using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    class Worker:Human, IComparable<Worker>
    {
        private int worker;

        int wage;
        int hoursWorked;
        int salary;
        int result;


        public Worker(string firstName, string lastName) : base(firstName, lastName)
        {

        }

        
        
        public int Wage { get; set; }

        public int CalculateHourlyWage(int wage, int hoursWorked)
        {
            int salary = wage * hoursWorked;
            return salary;
        }

        public int CompareTo(Worker other)
        {
            int result = this.salary.CompareTo(other.salary);
            return result;

        }

        
    }
}
