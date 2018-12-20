using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
namespace FileNew
{
    class Program
    {
        static void Main(string[] args)
        {
            string content = null; ;
            string file = "TestText";
            StreamReader reader = new StreamReader(file);
            int longestWord = 0;

            while (reader.EndOfStream == false)
            {
                 content = reader.ReadLine();
                Console.WriteLine(content);
            }
            reader.Close();

            char [] separator = {' '};
            int totalWords = content.Split(separator, StringSplitOptions.RemoveEmptyEntries).Length;
            Console.WriteLine(totalWords);

            int numberOfWords = content.Split(' ').Length;
            Console.WriteLine("Number of words is " + numberOfWords);

            // Find the longest word
            string [] word = content.Split(' ');
            for(int i = 0; i <= word.Length; i++)
            {
                if(word[i].Length> longestWord)
                {
                    Console.WriteLine(word[i]);
                }
            }

            
            /*
             * File.CreateText(@"C:\Users\User\source\repos\OnlineCourseExercises\File\bin\Debug");
            File.WriteAllText(@"C:\Users\User\source\repos\OnlineCourseExercises\File\bin\Debug", "One, Two, Three");
            string testText = File.ReadAllText(@"C:\Users\User\source\repos\OnlineCourseExercises\File\bin\Debug");

            StreamReader reader = new StreamReader(testText);
            while (reader.EndOfStream == false)
            {
                string context = reader.ReadLine();
                Console.WriteLine(context);
            }
            Console.ReadLine();
            testText.Clone();
             */

            
        }
    }
}
