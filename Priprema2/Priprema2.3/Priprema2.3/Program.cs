using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priprema2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int broj;

            Console.WriteLine("Upiši broj. ");
            broj=Convert.ToInt32(Console.ReadLine());

            if ( broj % 4 == 0 )
            {
                Console.WriteLine("Broj je djeljiv sa 4. ");
            }
            if (broj % 6 == 0)
            {
                Console.WriteLine("Broj je djeljiv sa 6. ");
            }
            if (broj % 4 == 0 || broj % 6 ==0)
            {
                Console.WriteLine("Broj je djeljiv sa 4 i sa 6. ");
            }
            if (broj % 4 != 0 ˛&& broj % 6 != 0)
            {
                Console.WriteLine("Broj nije djeljiv sa 4 i sa 6. ");
            }

            Console.ReadKey();
        }
    }
}
