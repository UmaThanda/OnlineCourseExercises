using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandscapeOrPortrait
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the width");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the height");
            int height = Convert.ToInt32(Console.ReadLine());

            if(height > width)
            {
                Console.WriteLine("It is a portrait");
            }
            else
            {
                Console.WriteLine("It is a Landscape");
            }

        }
    }
}
