using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueNumbersOneAtATime
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            Console.WriteLine("Please enter 5 unique numbers when prompted and hit enter to quit");

            
            for (int i = 0; i< 5; i++){

                Console.WriteLine("Enter a unique number");
                int number = int.Parse(Console.ReadLine());
                //numbers.Add(number);
                for(int j = 0; j<i; j++)
                {

                }

            }
        }
    }
}
