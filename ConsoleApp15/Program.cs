

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Program
    {
        static void cerceve(int x1, int y1, int x2, int y2)
        {
            for (int i = y1; i <= y2; i++)
            {
                Console.SetCursorPosition(i, x1); Console.WriteLine("*");
                Console.SetCursorPosition(i, x2); Console.WriteLine("*");

            }

            for (int i = x1 + 1; i <= x2 - 1; i++)
            {
                Console.SetCursorPosition(y1, i); Console.WriteLine("*");
                Console.SetCursorPosition(y2, i); Console.WriteLine("*");

            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {

            cerceve(4, 10,7, 60);


            {
            }
        }
    }
}
