using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht14
{
    class Program
    {
        static void Main(string[] args)
        {
            int zeros = 0, ones = 0, twos = 0, threes = 0, fours = 0, fives = 0, grade = 0;
            while (grade >= 0 && grade <= 5)
            {
                Console.Write("Anna numero > ");
                grade = int.Parse(Console.ReadLine());
                switch (grade)
                {
                    case 0:
                        zeros++;
                        continue;
                    case 1:
                        ones++;
                        continue;
                    case 2:
                        twos++;
                        continue;
                    case 3:
                        threes++;
                        continue;
                    case 4:
                        fours++;
                        continue;
                    case 5:
                        fives++;
                        continue;  
                }
                Console.WriteLine("Arvosanat: ");
                Console.WriteLine("0: " + String.Concat(Enumerable.Repeat("*", zeros)));
                Console.WriteLine("1: " + String.Concat(Enumerable.Repeat("*", ones)));
                Console.WriteLine("2: " + String.Concat(Enumerable.Repeat("*", twos)));
                Console.WriteLine("3: " + String.Concat(Enumerable.Repeat("*", threes)));
                Console.WriteLine("4: " + String.Concat(Enumerable.Repeat("*", fours)));
                Console.WriteLine("5: " + String.Concat(Enumerable.Repeat("*", fives)));
            }
        }
    }
}
