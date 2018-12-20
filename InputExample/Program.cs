using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // ReadLineByLine();
            ReadOneLine();
        }

        private static void ReadOneLine()
        {
            Console.WriteLine("Enter numbers on one line separate by -");
            string input = Console.ReadLine();
            string[] inputs = input.Split('-');
            List<int> integers = new List<int>();

            foreach (string number in inputs)
            {
                int item = int.Parse(number);
                integers.Add(item);
                
            }

            foreach (int item in integers)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

        }

        public static void ReadLineByLine()
        {
            List<int> integers = new List<int>();
            Console.WriteLine("Please enter numbers then enter nothing to end the program.");
            string response = Console.ReadLine();
            while (response != "")
            {
                int item = int.Parse(response);
                integers.Add(item);
                response = Console.ReadLine();
            }

            foreach (int item in integers)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

    }
}
