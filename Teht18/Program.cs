using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna jokin merkkijono > ");
            string mj = Console.ReadLine();
            char[] merkkijono = mj.ToCharArray();
            Array.Reverse(merkkijono);
            string käännös = new string(merkkijono);
            Console.WriteLine(käännös);
            if (käännös == mj)
            {
                Console.WriteLine("Tämähän on palindromi!");
            }
            else
            {
                Console.WriteLine("Sana on nyt väärinpäin!");
            }
        }
    }
}
