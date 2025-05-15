namespace HW7
{
    internal class Menu
    {
        static Random rand = new Random();
        static void Main(string[] args)
        {
            //generates the meal
            generateMeal();
        }

        static string getAppetizer(/*string[] app*/)
        {
            string[] apps = { "fries", "wings", "sliders" };

            //printing out a random slot number in the apps array.
            //Console.WriteLine(apps[rand.Next(apps.Length)]);

            //returns random item from the menu section
            return apps[rand.Next(apps.Length)];
        }

        static string getMain(/*string[] main*/)
        {
            string[] mains = { "chicken", "meat", "fish" };

            //Console.WriteLine(mains[rand.Next(mains.Length)]);

            return mains[rand.Next(mains.Length)];
        }

        static string getDessert(/*string[] des*/)
        {
            string[] dess = { "cake", "ices", "ice cream" };

            //Console.WriteLine(dess[rand.Next(dess.Length)]);

            return dess[rand.Next(dess.Length)];
        }

        static void generateMeal()
        {
            //calls on the 3 menu categories as writes one out from each
            Console.WriteLine(getAppetizer());
            Console.WriteLine(getMain());
            Console.WriteLine(getDessert());
        }
    }
}