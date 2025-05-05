namespace HW5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            printCharacters('B', 2);
            Console.WriteLine(isEven(8));
            Console.WriteLine(calculateAverage(4, 2, 6, 8));
            Console.WriteLine(getDaysInMonth(2, 2008));
        }

        //You enter what character you want printed and how many times, and it prints it.
        static void printCharacters(char c, int t)
        {
            for (int i = 0; i < t; i++)
            {
                Console.WriteLine(c);
            }
        }

        //Sees if number is even or not and returns true/false
        static bool isEven(int num)
        {
            if(num % 2== 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //calculates the average of the inputted numbers
        static int calculateAverage(int a, int b, int c, int d)
        {
            return (a + b + c + d) / 4;
        }

        //returns how many days there are in an inputted month (only February changes)
        static int getDaysInMonth(int month, int year)
        {
            switch (month)
            {
                //checks if February is a leap year
                case 2:
                    if (((year % 4 == 0) && !(year % 100 == 0) ) || (year % 400 == 0)){
                        return 29;
                    }
                    else
                    {
                        return 28;
                    }

                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                    //default is because something has to be returned. -1 usually means something is wrong.
                default:
                    return -1;

            }
        }
    }
}