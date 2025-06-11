namespace HW9
{
    //Roll 2 dice 36,000 times and keep track of how many times you got each result
    //I should make a method that you call and enter how many times you want the dice to roll
    //Step 1 - Make the method and a console.readline to ask how many rolls
    //Step 2 - make a roll dice method that is a random variable from 1-6
    //Step 3 - make variables for each result and add them
    //Step 4 - print the results

    internal class DiceRoller
    {
        static void Main(string[] args)
        {
            //Asks how many rolls you want
            Console.WriteLine("How many rolls would you like?");

            //Catched what you typed and makes it an int
            int rollAmount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("These are the amount of times each number was rolled:\n");

            //Makes the array for the rolls
            int[] possibilityIndex = new int[11];

            //For every roll that you want rolled
            for (int i = 0; i < rollAmount; i++)
            {
                //SCalls on the function to roll the dice
                int roll = rollDice();

                //Adds another value in the index to the spot that pertains to that roll number. It's -2 because the array starts at 0, and the 2 dice cant roll 1
                possibilityIndex[roll - 2]++;
            }

            //For every index in the roll count array
            for (int j = 0; j < possibilityIndex.Length; j++)
            {
                //Print the number pertaining to the roll number
                Console.Write((j+2) + ": ");

                //Adds a space to the numbers under 10 to keep them aligned with numbers over 10 since they have 1 less digit
                if (j + 2 < 10)
                {
                    Console.Write(" ");
                }

                //Prints the indexes in the array, which is the amount of times each number was rolled
                Console.WriteLine(possibilityIndex[j]);
            }



        }

        //Simulates a dice roll
        static int rollDie()
        {
            Random random = new Random();
            int roll = random.Next(1, 7);

            return roll;
        }

        //Calls the diceroller twice and returns their sum
        static int rollDice()
        {
            int die1 = rollDie();
            int die2 = rollDie();

            return die1 + die2;

        }


    }
}