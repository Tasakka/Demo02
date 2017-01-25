using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht17
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] taulukko = { 10, 20, 30, 40, 50 };
            int[] taulukko2 = { 5, 15, 25, 35, 45 };
            int[] taulukot = taulukko.ToList().Concat(taulukko2.ToList()).ToArray();
            Array.Sort(taulukot);
            for (int i = 0; i < taulukot.Length ; i++)
            {
                Console.WriteLine(taulukot[i]);
            }
        }
    }
}
