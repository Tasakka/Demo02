using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht16
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randluku = random.Next(0, 100);
            int yritykset = 1;
            int x = -1;
            while (x != randluku) 
            {
                Console.Write("Arvaa luku sadan ja nollan väliltä > ");
                int luku = int.Parse(Console.ReadLine());
                if (luku > randluku)
                {
                    Console.WriteLine("Luku on pienempi!");
                    yritykset++;
                }
                else if (luku < randluku)
                {
                    Console.WriteLine("Luku on suurempi!");
                    yritykset++;
                }
                else
                {
                    Console.WriteLine("Oikein! " + "Sinulla meni " + yritykset + " yritystä arvata");
                    break;
                }

            }
        }
    }
}
