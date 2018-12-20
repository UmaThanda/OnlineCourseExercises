using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFiveUniqueNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            Console.WriteLine("Please enter 5 unique numbers separated by -");
            string input = Console.ReadLine();
            string [] number =  input.Split('-');
            foreach(string num in number)
            {
                int item = int.Parse(num);
                numbers.Add(item);
            }

           foreach(int itemNumber in numbers)
            {
                Console.WriteLine(itemNumber);
            }
            Console.ReadKey();

        }
    }
}
