using System;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence: ");
            string sentence = Console.ReadLine();

            Program program = new Program();
            program.wordCount(sentence);
        }

        void wordCount(string sentence) {
            int wordCount = sentence.Split(" ").Length;
            Console.WriteLine("There are " + wordCount + " words in that sentences");
        }
    }
}