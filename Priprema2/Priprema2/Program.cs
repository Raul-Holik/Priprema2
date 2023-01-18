using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priprema2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string unos;

            Console.WriteLine("Unesite riječ.");
            unos=Console.ReadLine();

            string ispis = unos.Substring(2, unos.Length - 4);
            
            if(unos.Length<5)
            {
                Console.WriteLine(unos);
            }

            Console.WriteLine(ispis);

            Console.ReadKey();
        }
    }
}
