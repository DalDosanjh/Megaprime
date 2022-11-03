using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaPrime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint max = uint.Parse(Console.ReadLine());

            List<uint> megaPrimeNumbers = new List<uint>();
            megaPrimeNumbers = MegaPrimeDeterminator.GetMegaPrimes(max);

            if (megaPrimeNumbers.Count>0)
            {
                Console.WriteLine("The Megaprime Numbers for " + max + " are " + string.Join(",", megaPrimeNumbers));

            }
            else
            {
                Console.WriteLine("There are no Mega Prime numbers for " + max);
            }
            Console.ReadLine();
        }
    }
}
