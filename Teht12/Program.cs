using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht12
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku;
            int [] luvut = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Anna luku > ");
                luku = int.Parse(Console.ReadLine());
                luvut[i] = luku;
            }
            Array.Reverse(luvut);
            Console.WriteLine(luvut[0]);
            Console.WriteLine(luvut[1]);
            Console.WriteLine(luvut[2]);
            Console.WriteLine(luvut[3]);
            Console.WriteLine(luvut[4]);
        }
    }
}
