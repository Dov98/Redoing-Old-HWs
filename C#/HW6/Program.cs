using System.Runtime.Intrinsics.X86;
using static System.Formats.Asn1.AsnWriter;

namespace HW6
{
    internal class Program
    {
        static void Main(string[] args){

            string[] names = new string[3];
            //names[] = { "Danny", "Luke", "Michael" };
            names[0] = "Danny";
            names[1] = "Luke";
            names[2] = "Michael";

            for (int i = 0; i < names.Length; i++)
            {
                //grades(names[i]);
                Console.Write(names[i] + " - ");
                grades(names);
                //letterGrade();
            }
        }

        static void grades(string[] name) { 

            int[] scores = new int[8];
            Random rand = new Random();

            //puts score in each array index
            for (int i = 0; i < scores.Length; i++)
            {

                scores[i] = rand.Next(60, 100);
            }

            //prints scores
            for (int j = 0; j < scores.Length; j++)
            {
                Console.Write(scores[j] + " ");
            }

            int avg = CalculateAverage(scores);
            Console.Write("Avg: " + avg);

            //Prints out the score
            Console.Write(" Grade: ");
            if (avg > 90)
            {
                Console.Write('A');
            }
            else if (avg > 80)
            {
                Console.Write('B');
            }
            else if (avg > 70)
            {
                Console.Write('C');
            }
            else if (avg > 60)
            {
                Console.Write('D');
            }

            Console.WriteLine();

        }

        //calculates average of the scores
        static int CalculateAverage(int[] avg)
        {

            int total = 0;

            for(int i =0; i < avg.Length; i++)
            {
                total += avg[i];
            }            

            return total/ avg.Length;
        }

        //defines the lettergrade based off the average
        /*static void letterGrade(int avg)
        {
            if(avg > 90)
            {
                Console.WriteLine('A');
            }else if (avg > 80)
            {
                Console.WriteLine('B');
            }else if (avg > 70)
            {
                Console.WriteLine('C');
            }else if(avg > 60)
            {
                Console.WriteLine('D');
            }
        }*/
    }
}