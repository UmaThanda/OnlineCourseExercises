using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedLimit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the speed limit");
            int speedLimit = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter your car speed");
            int carSpeed = Convert.ToInt16(Console.ReadLine());
            
            if(carSpeed < speedLimit)
            {
                Console.WriteLine("Speed is OK");
            }
            else if(carSpeed > speedLimit)
            {
               int limit = ((carSpeed - speedLimit)/5);
                if (limit >= 12)
                {
                    Console.WriteLine("Licence - Pay attention");
                }else if(limit < 12)
                {
                    Console.WriteLine("you gained " + limit + "point(s)");
                }
            }
        }
    }
}
