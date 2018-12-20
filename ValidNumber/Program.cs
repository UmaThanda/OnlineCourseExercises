using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number between 1 and 10");
            int enteredNumber = Convert.ToInt16(Console.ReadLine());
            if(enteredNumber <1 || enteredNumber > 10)
            {
                Console.WriteLine("Invalid Number");
            }
            else
            {
                Console.WriteLine("Valid Number");
            }
        }
    }
}
