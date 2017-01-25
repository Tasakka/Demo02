using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Leiki mäkihyppytuomaria ja anna viidet pisteet hypystä \n");
            int pist;
            int[] pisteet = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Anna pisteitä (max 20) > ");
                pist = int.Parse(Console.ReadLine());
                pisteet[i] = pist;
            }
            int max = pisteet.Max();
            int min = pisteet.Min();
            int summa = pisteet.Sum();
            int loppupisteet = summa - max - min;
            Console.WriteLine("Loppupisteet ovat > " + loppupisteet);
        }
    }
}
