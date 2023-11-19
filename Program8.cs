using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication20
{
    class Program
    {
        static void Main(string[] args)
        {
               for (int i = 0; i<=25; i++)
            {
                for (int J = 0; J<=50; J++)
                {
                    if ((i * 2000) + (J * 5000) == 50000) ;
                }
                    Console.WriteLine("x={0},y={1}", i,J);
            }
        }
    }
}
