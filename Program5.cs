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
            int hour;
            int max;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nEnter hour");
            int mark = 0;
            hour = int.Parse(Console.ReadLine());
            max = hour;

            while (hour > 0)
            {
                if (hour > max)
                    max = hour;
                Console.WriteLine("\nEnter 0 for Exit");
                Console.Write("Enter hour");
                hour = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("max= {0}", max);

            Console.ReadLine();

        }
    }
}
