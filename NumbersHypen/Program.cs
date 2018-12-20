using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersHypen
{
    class Program
    {
        static void Main(string[] args)
        {
            var justNumbers = new List<int>();
            Console.WriteLine("Enter a few numbers separated by hypen");
            var numberWithHypen = Console.ReadLine();
                       
            foreach (var num in numberWithHypen.Split('-'))
                justNumbers.Add(Convert.ToInt32(num));

            justNumbers.Sort();

            var a = true;
            for (var i = 1; i < justNumbers.Count; i++)
            {
                if (justNumbers[i] != justNumbers[i - 1] + 1)
                {
                    a = false;
                    break;
                }
                else
                {
                    a = true;
                }
            }

            if (a = false){
                Console.WriteLine("Numbers are not consecutive");
                           }
            else
            {
                Console.WriteLine("Numbers are consecutive");
            }
           
            


        }

    }
}


