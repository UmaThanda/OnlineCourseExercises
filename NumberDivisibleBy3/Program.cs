using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberDivisibleBy3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, here are the numbers divisible by 3 from 1 to 100");
            int count = 0;
            for(int i = 1; i<=100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                    count++;
                    
                }
               
            }
            Console.WriteLine("Total numbers divisible by 3 from 1 to 100 are  " + count);

        }
    }
}
