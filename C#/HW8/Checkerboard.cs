using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8
{
    internal class Checkerboard
    {
        //Make Checkerboard pattern
        //make a nested array, if both numbers are odd print +, and if 1 odd 1 even print -
        //maybe may it a method, and call it and say what size you want to array to be

        static void Main(string[] args)
        {
            Console.WriteLine("Type a size you want the checkerboard to be");

            int size = Convert.ToInt32(Console.ReadLine());

            //takes the input and puts it in a 2 dimensional array
            char[,] arraySize = new char [size, size];

            //runs the array through the method
            makeCheckerboard(arraySize);
            printBoard(arraySize);
        }

        static void makeCheckerboard(char[,] size)
        {
            //runs through the length of the first dimesion of the array (the rows)
            for (int i = 0; i < size.GetLength(0); i++)
            {
                //runs through the length of the first dimesion of the array (the columns)
                for (int j = 0; j < size.GetLength(0); j++)
                {
                    //checks whethere i and j are even or odd on the board, and places the corresponding marker
                    if (i % 2 == 0 && j % 2 == 0)
                    {
                        size[i, j] = '+';
                    }
                    else if ((i % 2 != 0) && j % 2 != 0)
                    {
                        size[i, j] = '+';
                    }
                    else if(i%2 == 0 && j % 2 != 0)
                    {
                        size[i, j] = '-';
                    }
                    else if (i % 2 != 0 && j % 2 == 0)
                    {
                        size[i, j] = '-';
                    }
                }
            }
        }

        static void printBoard(char[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    Console.Write(board[i,j] + " ");
                }
                //goes to the next row
                Console.WriteLine();
            }
        }
    }
}
