using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateSum
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int total = 0;
            int result = 0;
           
                
           while(true)
              
            {
                Console.WriteLine("Please enter a number to add or OK to quit");
                var num = Console.ReadLine();
                if (num.Equals("ok"))
                {
                    Console.WriteLine("Thank You");
                    break;
                }
                else
                {
                    result = Convert.ToInt32(num);
                    total += result;
                }
                    
            }
            Console.WriteLine("Sum of entered numbers are " + total);
        }
    }
}
