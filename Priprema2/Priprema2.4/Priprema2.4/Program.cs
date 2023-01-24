using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priprema2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double sP, bP;

            Console.WriteLine("Unesite cijenu bez PDV-a:");
            bP = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Unesite cijenu s PDV-om:");
            sP = Convert.ToDouble(Console.ReadLine());
            if (sP < bP)
                Console.WriteLine("Cijene nisu ispravno unešene");
            else
                Console.WriteLine("PDV iznosi: " +(sP - bP) / bP * 100);
        }
    }
}
