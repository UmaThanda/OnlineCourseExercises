using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalCase
{
    class Program
    {
        static void Main(string[] args)
        {
            TextInfo myWords = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo;
            Console.WriteLine("Please enter few words");
            string words = Console.ReadLine();
            string smallCase = words.ToLower();
            string pascalCase = myWords.ToTitleCase(smallCase);
            //Console.WriteLine(pascalCase);
            string splitWords = pascalCase.Replace(" ", "");
            Console.WriteLine();
            Console.WriteLine("Pascal Case: " + splitWords);

            }
        }
    }

