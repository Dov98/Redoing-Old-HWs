using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11
{
    internal class BingoTester
    {
        static void Main(string[] args)
        {
            Bingo b1 = new Bingo();
            b1.name = "John";
            Console.WriteLine($"My name is {b1.name} and this is my Bingo Card:");
            b1.fillBoard();
            b1.makeMiddleZero();
            b1.printBoard();

            Bingo b2 = new Bingo();
            b1.name = "Jeanette";
            Console.WriteLine($"My name is {b1.name} and this is my Bingo Card:");
            b1.fillBoard();
            b2.makeMiddleZero();
            b1.printBoard();
        }
    }
}
