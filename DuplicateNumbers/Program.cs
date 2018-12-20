using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicateNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var justNumbers = new List<int>();
            Console.WriteLine("Enter a unique numbers separated by hypen");
            var numberWithHypen = Console.ReadLine();
            if (String.IsNullOrEmpty(numberWithHypen))
            {
                Console.WriteLine("Entered duplicates. Invalid entry, Quitting");
            }
            else
            {
                foreach (var num in numberWithHypen.Split('-'))
                {
                    justNumbers.Add(Convert.ToInt32(num));

                   
                }
            }




            }
        }
    }

