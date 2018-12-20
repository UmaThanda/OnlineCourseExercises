using System;
using DateTimeFormat;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Enter 24-hour time format - eg. 18:00");
            DateTime input = Convert.ToDateTime(Console.ReadLine());
            int format = Convert.ToInt32(input);
            format = (input.CompareTo(DateTimeFormat("HH:mm")));
            if(format == 1)
            {
                Console.WriteLine("valid input");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }




        }

        private static object DateTimeFormat(string v)
        {
            throw new NotImplementedException();
        }
    }
}