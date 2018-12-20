using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentifyVowels
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word to find the number of vowels in that word");
            var words = Console.ReadLine();
            var wordsArray = words.ToCharArray();
            int vowelCount = 0;
            foreach(var wa in wordsArray)
            {
                if (wa.Equals('a') || wa.Equals('e') || wa.Equals('i')|| wa.Equals('o')|| wa.Equals('u'))
                    vowelCount++;
            }
            Console.WriteLine("Number of vowels in the word are {0}: ", vowelCount);

        }
    }
}
    
