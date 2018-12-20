using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int factorial = 1;
            Console.WriteLine("Welcome to Factorial Finder. Enter a number");
            int n = Convert.ToInt16(Console.ReadLine());
            for(int i = 0; i<=n-1; i++) { 
            factorial = factorial* (i+1);
               
            }
            Console.WriteLine(n + "!" + " is " + factorial);
        }
    }
}
