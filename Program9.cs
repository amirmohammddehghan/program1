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
            Console.WriteLine("__________Console calculator_________");
            Console.Write("shomare  A :");
            int a = int.Parse(Console.ReadLine());
            Console.Write("shomare  B :");
            int b = int.Parse(Console.ReadLine());


            Console.WriteLine("________________________");
            Console.WriteLine("1.CALC A+B =");
            Console.WriteLine("2.CALC A*B =");
            Console.WriteLine("3.CALC A/B =");
            Console.WriteLine("4.CALC A-B =");
            Console.WriteLine("5.EXIT ");
            Console.WriteLine("6.CHANGE NUMBER ");
            Console.WriteLine("________________________");
            Console.WriteLine("A = {0}  ,  B = {1}", a, b);
            Console.WriteLine("________________________");
            Console.Write("Enter Number(1-6) :");
            Console.SetCursorPosition(20, 13);
            int num = int.Parse(Console.ReadLine());
            while (num >= 1 & num <= 6)
            {
                if (num == 1)
                {
                    Console.SetCursorPosition(13, 4);
                    Console.WriteLine(a + b + "                ");
                }

                if (num == 2)
                {
                    Console.SetCursorPosition(13, 5);
                    Console.WriteLine(a * b + "                ");
                }

                if (num == 3)
                {
                    Console.SetCursorPosition(13, 6);
                    Console.WriteLine(a / b + "                ");
                }

                if (num == 4)
                {
                    Console.SetCursorPosition(13, 7);
                    Console.WriteLine(a - b + "                ");
                }
                if (num == 5)
                {
                    break;
                }
                if (num == 6)
                {
                    Console.SetCursorPosition(11, 1);
                    a = int.Parse(Console.ReadLine());
                    Console.SetCursorPosition(11, 2);
                    b = int.Parse(Console.ReadLine());
                }
                Console.SetCursorPosition(20, 13);
                num = int.Parse(Console.ReadLine());
            }


            Console.ReadKey();
        }
    }
}
