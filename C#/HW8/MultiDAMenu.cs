namespace HW8
{
    internal class MultiDAMenu
    {
        //Multidimensional array menu
        //Step 1 - have the menu and make it equal length
        //Step 2 - make a for loop choosing the outside of the array randomly
        //Step 3 make a for loop choosing the inside randomly
        //Print
      
        static Random rand = new Random();
        static void Main(string[] args)
        {

            string[,] menuItems = {
                { "fries", "wings", "sliders"  },
                { "chicken", "meat", "fish" },
                { "cake", "ices", "ice cream" }
            };

            generateMeal(menuItems);
            Console.WriteLine();
            generateMeal(menuItems);
            Console.WriteLine();
            generateMeal(menuItems);
        }

        static void generateMeal(string[,] course)
        {
            string[] courses = { "Appetizer", "Main", "Dessert" };

            //for every item in the courses array. The "0" is the length of the first dimension in the array
            for (int i = 0; i < course.GetLength(0); i++)
            {
                //The "1" in getlength returns the number of columns in the 2nd dimension of the array
                int randomIndex = rand.Next(course.GetLength(1));
                //selected items goes to the next row and chooses a random food item
                string selectedItem = course[i, randomIndex];
                //prints out each course from 0-2, then prints out the randomly selected menu item in the column
                Console.WriteLine((courses[i]) + ":" + selectedItem);

            }
        }
    }
}