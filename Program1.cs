using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{
    class Program
    {
        static void Main(string[] args)
        {
             int sum = 0;
            int minute = 0;

            for (int i = 1; i<30; i++)
            {
                Console.WriteLine("please rate the day {0} enter in minutes=", i);
                minute = int.Parse(Console.ReadLine());
                sum = sum + minute;
            }
            int houre = minute / 60;
            int average = houre / 30;
            Console.WriteLine(average);
            Console.ReadLine();
        }
    }
}
