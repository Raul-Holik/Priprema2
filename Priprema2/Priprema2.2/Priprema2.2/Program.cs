using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priprema2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            int y = 2;
            int z = 0;

            if(z==(x*x)+(y*y))
            {
                Console.WriteLine("Stranice su dio pravokutnog trokuta");
            }
            if(z!= (x*x)+(y*y))
            {
                Console.WriteLine("Stranice nisu dio pravokutnog trokuta");
            }
            if(z==0||x==0||y==0)
            {
                Console.WriteLine("Pogrešan unos. ");
            }

            Console.ReadKey();
          
            
        }
    }
}
