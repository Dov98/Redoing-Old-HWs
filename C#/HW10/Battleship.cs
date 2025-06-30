namespace HW10
{
    internal class Battleship
    {
        //setting up the board array and boat array
        static int[,] board = new int[10, 10];
        static int[] boats = { 2, 3, 3, 4, 5 };
        static Random rand = new Random();

        static void Main(string[] args)
        {
            //printBoard();
            //populateBoard(boats);

            //board[0, 0] = boats[0];
            //board[1, 0] = boats[1];
            //board[2, 0] = boats[2];
            //board[3, 0] = boats[3];
            //board[4, 0] = boats[4];

            //Calling boats array in the populateBoard array
            populateBoard(boats);
            printBoard();


        }

        //Pringting the board itself
        static void printBoard()
        {
            //Looping through array D-1
            for (int i = 0; i < board.GetLength(0); i++)
            {
                //Looping through array D-2
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    //If there was no value (boat) assigned to this specific space then print 0
                    if (board[i, j] == 0)
                    {
                        Console.Write("0 ");
                    }
                    // Else print the boat
                    else
                    {
                       
                        Console.Write(board[i, j] + " ");
                    }


                }
                //Printing the board
                Console.WriteLine();
            }
        }

        //putting boats on the board
        static void populateBoard(int[] boats)
        {
            int row = 0;
            //foreach boat in the boats array
            foreach(int boat in boats)
            {

                //the first column in the i area should equal the boat in the array
                for(int col = 0; col < boat; col++)
                {
                    board[row, col] = boat;
                    
                }
                row++;

            }
        }
    }
}