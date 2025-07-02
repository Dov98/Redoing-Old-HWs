namespace HW11
{
    internal class Bingo
    {
        //Creating the bingo card 2-D array
        static int[,] BingoCard = new int[5, 5];
        static Random rand = new Random();
        public string name;
        //static void Main(string[] args)
        //{
        //    //Filling the board
        //    fillBoard();
        //    //Making the middle spot free
        //    BingoCard[2, 2] = 0;
        //    //Printing the board
        //    printBoard();
        //}

        public void fillBoard()
        {
            //Setting the range of the first row
            int maxnum = 16;
            int minNum = 1;

            for (int col = 0; col < BingoCard.GetLength(1); col++)
            {
                //Creates an array to store the used numbers
                int[] usedNums = new int[5];

                for (int row = 0; row < BingoCard.GetLength(0); row++)
                {
                    int randNum;
                    bool isDuplicate;

                    do
                    {
                        //randNUm is a random number
                        randNum = rand.Next(minNum, maxnum);
                        isDuplicate = false;

                        for (int i = 0; i < row; i++)
                        {
                            //If any nuber in usedNums array is equal to the newly generated randomNum
                            if (usedNums[i] == randNum)
                            {
                                //isDuplicate is set to true, and it breaks out of the for loop to start again at the top of the do/while loop
                                isDuplicate = true;
                                break;
                            }
                        }

                    } while (isDuplicate);

                    //The new random num is placed in the usedNus array
                    usedNums[row] = randNum;

                    //The new randomNum is put on the bingo card
                    BingoCard[row, col] = randNum;

                }
                //Adds 15 for the next columns on the bingo card since they go up by 15
                maxnum += 15;
                minNum += 15;
            }
        }

        //Just goes through the 2-D array board and prints it
        public void printBoard()
        {
            for (int row = 0; row < BingoCard.GetLength(0); row++)
            {
                for (int col = 0; col < BingoCard.GetLength(1); col++)
                {

                    Console.Write(BingoCard[row, col]);

                    Console.Write(" ");

                    if (BingoCard[row, col] < 10)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}