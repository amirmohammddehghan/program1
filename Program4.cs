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
            float sum = 0, average;
            int count = 0;

            Console.Write("Enter mark {0} =",count+1);
            float mark = float.Parse(Console.ReadLine());
            while (mark >= 0)
            {
                sum = sum + mark;
                count++;
                Console.Write("Enter mark {0} =",count+1);
                mark = float.Parse(Console.ReadLine());
            }
            average = sum / count;
            Console.Write(average);
            Console.ReadLine();
        }
    }
}
