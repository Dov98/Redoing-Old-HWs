namespace HW4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //////////Grandfather clock
            ///outer loop is hours
            ///inner loop is minutes
            ///every hour add a "Ding Dong"



            for(int i = 1; i <= 12; i++)
            {
                Console.WriteLine();///If I put the CW after the nested for loop, then I have a full empty line
                                    //before the ding dong. But with this placement I have an empty line at the top, but it's still better than having an empty line after each hour.
                for (int j = 0; j < 60; j++)
                {
                    Console.Write(i + ":");
                    if (j < 10)
                    {
                        Console.Write("0");
                    }
                    Console.Write(j);
                    Console.WriteLine();
                }
                

                for (int dd = 0; dd < i; dd++)
                {
                    Console.Write("Ding, Dong! ");
                }
                
            }

            /////////If-else statement that prints out how many letters are in a certain day that you enter.
            ///Case sensitive

            Console.WriteLine("Pick a day of the week and I will tell you how many letters are in that day.");
            String letters = Console.ReadLine();

            if(letters == "Sunday")
            {
                Console.WriteLine("There are 6 letters in Sunday");
            } else if (letters == "Monday")
            {
                Console.WriteLine("There are 6 letters in Monday");
            } else if (letters == "Tuesday")
            {
                Console.WriteLine("There are 7 letters in Tuesday");
            } else if (letters == "Wednesday")
            {
                Console.WriteLine("There are 9 letters in Wednesday");
            } else if (letters == "Thursday")
            {
                Console.WriteLine("There are 8 letters in Thursday");
            } else if (letters == "Friday")
            {
                Console.WriteLine("There are 6 letters in Friday");
            } else if (letters == "Saturday")
            {
                Console.WriteLine("There are 8 letters in Saturday");
            }
            else
            {
                Console.WriteLine("What you have entered is not a day of the week.");
            }
        }
    }
}