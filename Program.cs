using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicijalno_ponavljanje1
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            int x = 4, y = 5;
            double z = 2.5;
            if(x.GetType() == typeof(int) && x>0)
            {
                Console.WriteLine("x je int");
            }
            else
            {
                Console.WriteLine("x nije int ili je 0");
            }
            if (y.GetType() == typeof(int) && y > 0)
            {
                Console.WriteLine("y je int");
            }
            else
            {
                Console.WriteLine("y nije int ili je 0");
            }
            if (z.GetType() == typeof(int) && z > 0)
            {
                Console.WriteLine(" z je int");
            }
            else
            {
                Console.WriteLine("z nije int ili je 0");
            }
            Console.ReadKey();
        }
    }
}
