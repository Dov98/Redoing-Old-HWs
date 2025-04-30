namespace HW3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///////////////////////////////// Steps 1 and 2
             Random rand = new Random();
             int theNum = rand.Next(0, 10) + 1;
             int guessNum = 0;

             while (true)
             {
                 Console.WriteLine("Guess the number between 1-10");
                 int theGuess = Convert.ToInt32(Console.ReadLine());

                 guessNum++;

                 if (theGuess > theNum)
                 {
                     Console.WriteLine("Too high");
                 }
                 else if (theGuess < theNum)
                 {
                     Console.WriteLine("Too low");
                 }
                 else
                 {
                     Console.WriteLine("You win!!!");

                     Console.WriteLine("It took " + guessNum + " guesses to win");

                     Console.WriteLine("Do you want to play again?\nPress y to play again, and any other key to exit.");
                     string s = Console.ReadLine();
                     if (s == "y")
                     {
                         Console.WriteLine("play again");
                         theNum = rand.Next(0, 10) + 1;
                         guessNum = 0;
                     }
                     else
                     {
                         break;
                     }
                 }
             }

            ///////////////////////////Step 3

            //Flip coin 100 times
            //if 0, heads++
            //if 1, tails++
            //print result

            int flips = 0, heads = 0, tails = 0;
            while(flips < 100)
            {
                Random rand2 = new Random();
                int coinToss = rand2.Next(0, 2);

                if(coinToss == 0)
                {
                    heads++;
                }else if(coinToss == 1)
                {
                    tails++;
                }
                flips++;
            }
            Console.WriteLine("Heads was tossed " + heads + " times.");
            Console.WriteLine("Tails was tossed " + tails + " times.");


            /////////////////// Problem 4
            for(int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= i; j++) //if j is equal to i, then it will print the same number of asterics as i because i cant go throgh another loop until j loops around fully.
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}