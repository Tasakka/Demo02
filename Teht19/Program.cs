using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht19
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = System.IO.File.ReadAllLines(@"E:\koulu\Olio-ohjelmointi\sanat.txt.txt");
            int LengthOfArray = words.Length;
            Random rnd = new Random();
            int random = rnd.Next(1, 3);
            char[] letters = words[random].ToCharArray();
            bool WordIsHidden = true;
            char hiddenChar = '_';
            char GuessedLetter = hiddenChar;

            var retry = true;
            while (retry == true)
            {
                Console.WriteLine(letters);
                letters = GuessedLetter.ToString().ToCharArray();
                for (int i = 0; i <= LengthOfArray; i++)
                {
                    Console.Write("{0} ", GuessedLetter);
                }
                Console.WriteLine("Enter a letter!");
                char letter = char.Parse(Console.ReadLine());
                if (words[random].Contains<char>(letter))
                {
                    WordIsHidden = false;
                    GuessedLetter = letter;
                    Console.Write(letters);
                }
                else
                {
                    if (WordIsHidden == true)
                    {
                        Console.Write("You guessed wrong!");

                    }
                }

            }
        }
    }
}