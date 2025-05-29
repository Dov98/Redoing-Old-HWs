using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8
{
    internal class removeDuplicates
    {
        //replace the duplicate numbers with null values, and then return the non-duplicating data
        //Step 1 - run through the array
        //Step 2 - maybe assign a value to a number, and then see if it equals any others. If it does equal another,
        //then we turn that number into a null. After we went through the array we move onto the next number and see if its equal to others
        //Step 3 - After marking duplicates, collect the non-null values into a new "cleaned" array.
        static void Main(string[] args)
        {
            int?[] nums = { 20, 20, 30, 40, 50, 50, 50};

            removeDupes(nums);
        }

        static void removeDupes(int?[] array)
        {
            int uniqueCount = 0;


            //Goes through the array
            for (int i = 0; i < array.Length; i++)
            {
                //assigns an int to the array index
                int? currentVal = array[i];

                for (int j = 0; j < array.Length; j++)
                {
                    //if the array is equal to another number in the array, and is not null
                    if (i != j && array[j] != null && currentVal == array[j] )
                    {
                        //if the index is null (which means this was a duplicate) we skip it 
                        if (array[i] == null)
                        {
                            continue;
                        }
                        //makes the duplicate null
                        array[j] = null;
                    }
                   

                }
                //if currentVal is not null, it's a unique value and should be printed
                if (currentVal != null)
                {
                    uniqueCount++;
                    //just a printout of the array
                    Console.Write(currentVal);
                }
                else
                {
                    //if its not a number it will write null, to visualize the null value
                    Console.Write("null");
                }

                //as long as i is not at the last index in the array, it will  print a comma
                if (i < array.Length - 1)
                {
                    Console.Write(", ");
                }



            }

            //making a new array cleaned, whose array length is how many times we had non-null values in the original array
            int?[] cleaned = new int?[uniqueCount];

            int cleanedIndex = 0;

            //going through the length of the array that gets plugged into the method
            for (int h = 0; h < array.Length; h++)
            {
                //if the index is not null at this spot
                if (array[h] != null)
                {
                    //this new array equals the spot in the original array (again, only if its not null)
                    cleaned[cleanedIndex] = array[h];

                    //we move onto the next index in the array
                    cleanedIndex++;
                }

            }
            //goes to a new line after printing the original array
            Console.WriteLine();
            //prints out how many unique numbers there were
            Console.WriteLine("There are " + uniqueCount + " non-duplicate numbers in the array.");
            //starting to print out the non-duplicated array
            Console.Write("The new, cleaned up array is [");

            //goes through the new, cleaned array
            for (int k = 0; k < cleaned.Length; k++)
            {
                //writes what the number is in the index
                Console.Write(cleaned[k]);
                //as long as k isn't up to the last index in the array, it will print a comma
                if(k < cleaned.Length - 1)
                {
                    Console.Write(", ");
                }

            }
            //prints ']' for asthetic purposes
            Console.Write("]");
            //makes a new line to so it's less crowded
            Console.WriteLine();            
        }
    }
}
