using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace Inicijalno_ponavljanje1
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            int x = 2, y = 3;
            int z =Convert.ToInt32(Sqrt(Pow(x, 2) + Pow(y, 2)));

            if(Sqrt((Pow(x, 2) + Pow(y, 2))) == z || Sqrt((Pow(z, 2) + Pow(y, 2))) == x || Sqrt((Pow(x, 2) + Pow(z, 2))) == y && x > 0 && y > 0 && z > 0 )
            {
                Console.WriteLine("Stranice trokuta prave pravokutni trokut i cijeli s projevi");
            }
            else
            {
                if( x > 0 && y > 0 && z > 0)
                {
                    Console.WriteLine("Stranice trokuta nisu cijeli brojevi ili ne prave trokut");
                }
                else
                {
                    Console.WriteLine("Jedna ili više od stranica su manje ili jednake 0");
                }
                
            }
            Console.ReadKey();
        }
    }
}
