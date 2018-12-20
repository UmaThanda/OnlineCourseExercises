using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unique5Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 5 unique numbers when prompted");
            int [] num = new int[5];
            for(int i = 1; i<=num.Length; i++)
            {
                Console.WriteLine("Please enter a number");
                var number = Console.ReadLine();
                for (int j= 0; j >=number.Length; j++)
                {
                    if (num[i] == number[j])
                    {
                        Console.WriteLine(" Not Valid, unique please");
                        break;
                    }
                    else
                    {
                        num[i] = Convert.ToInt32(number);
                    }
                }
            }
            Array.Sort(num);
            Console.WriteLine(num);

        }
           
            
            
            
           
          
        }
            
}


