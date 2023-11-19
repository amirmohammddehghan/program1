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
            for (int t = 1; t <=10; t++)
            {
                for (int v = 0; v<=8; v++)
                {
                    Console.Write(t*v);
                }
            }
            Console.ReadLine();
        }
    }
}
