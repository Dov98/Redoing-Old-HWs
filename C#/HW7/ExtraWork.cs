using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    internal class ExtraWork
    {
        static void Main(string[] args)
        {
            //returnString();
            returnMaxAndMin();
        }

        //Write a method to return the index (slot number) of a specific element from an array (if it is an
        //array of strings[“hello”, “world”,”bye”], if I pass you “world”, return its index which is 1.
        //Step 1 - make a string array
        //Step 2 - make a for loop that goes through the array
        //Step 3 - if the word does not equal it, then moves onto next index

        static void returnString()
        {
            string[] words = {"hello", "world", "bye" };
            Console.WriteLine("Write either hello, world, or bye.");

            string input = Console.ReadLine(); //"input" = typed word

            for (int i = 0; i < words.Length; i++) //goes through array
            {
                if(words[i] == input) //if typed word equals array word
                {
                    Console.WriteLine("The word you typed is at index " + i); //prints out array place
                    break;
                }
            }
        }


        //Write a method to return the maximum and minimum value of an array of numbers
        //make an array of nums
        //loop through the array
        //save an int as highest/lowest num
        //if another number is higher/lower, then that becomes the new number
        //loops throgh whole array to find answer and then finishes
        static void returnMaxAndMin()
        {
            int[] nums = { 4, 66, 34, 1, 99, 46, 36, 18 };
            int large = nums[0];
            int small = nums[0];

            for (int i = 0; i < nums.Length; i++)
            {

                if (nums[i]> large)
                {
                    large = nums[i];
                }
                if(nums[i]< small)
                {
                    small = nums[i];
                }
            }
            Console.WriteLine("The largest number in the array is: " + large);
            Console.WriteLine("The smallest number in the array is: " + small);
        }
    }
}
