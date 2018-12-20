using System;


using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseName
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your name");
            string input = Console.ReadLine();

            char[] reversedInput = input.ToCharArray();
            Array.Reverse(reversedInput);
            Console.WriteLine(reversedInput);
          //  String output = new string(reversedInput);
          //  Console.WriteLine(output);



        }
    }
    }

