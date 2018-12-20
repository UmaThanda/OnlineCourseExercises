using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumberInSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sortedArray;
            int[] num = new int[10];
            Console.WriteLine("Enter a series of numbers seperated by comma");
            string userInput = Console.ReadLine();
            string [] split = userInput.Split(',');
            num = Array.ConvertAll(split, int.Parse);

         /* Array.Sort(num);
            for (int i = 0; i<=num.Length; i++)
            {
                Console.WriteLine(num.Length-1);
            }
            */
          
            
            }
        }
    }

