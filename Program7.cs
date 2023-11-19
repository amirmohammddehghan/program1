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
            for (int i = 1; i <= 5; i++)
            {
                for (int J = 1; J <= 5; J++)
                {
                    Console.Write("{0,4}", i * J);

                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
