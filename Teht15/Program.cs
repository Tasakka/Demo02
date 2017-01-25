using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht15
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumOfLines = 8;
            for (int i = 0; i < NumOfLines; i++)
            {
                for (int j = 0; j < NumOfLines - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k <= i; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
