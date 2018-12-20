using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            var entry = new List<string>();
                        
            while (true) { 
            Console.WriteLine("Please enter a name OR press Enter to exit");
                var userEntry = Console.ReadLine();
               
            if (String.IsNullOrEmpty(userEntry))
            {
                Console.WriteLine("Thank you");
                    break;
            }
            else
            {
                    entry.Add(userEntry);
                    //Console.WriteLine(entry.Count);
            }

            }

            var userEntries = entry.Count();
            //Console.WriteLine(userEntries);
            
            var targetedUsers = entry.Count() - 2;
            
            if (userEntries == 0)
                {
                    Console.WriteLine("Hi!...");
                }
                else if (userEntries == 1)
                {
                    Console.WriteLine("Hi! " + entry[0] + " likes your post");
                }
                else if (userEntries == 2)
                {
                    Console.WriteLine("Hi! " + entry[0] + " , " + entry[1] + " like your post");
                }
                else if (userEntries >= 3)
                {
                    Console.WriteLine(entry[0] + " , " + entry[1] + " and " + targetedUsers + " others like your post");
                }

            }

        }
        }
    
