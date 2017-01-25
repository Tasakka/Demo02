using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arvot = { 1, 2, 33, 44, 55, 68, 77, 96, 100 };
            int n = 0;
            while (n < arvot.Length)
            {
                if (n % 2 ==0)
                {
                    Console.Write("HEP!!! \n");
                    n++;
                    continue;
                }
                else
                {
                    n++;
                    continue;
                }
            }

        }
    }
}
