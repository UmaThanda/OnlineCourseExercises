using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayMaximumNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter second number");
            int b = Convert.ToInt32(Console.ReadLine());

            if(a > b)
            {
                Console.WriteLine("The greater number is " + a);
            }
            else
            {
                Console.WriteLine("The greater number is " + b);
            }



        }

    }
}
