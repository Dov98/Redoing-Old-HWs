using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12
{
    internal class StudentTester
    {
        static void Main(string[] args)
        {
            //Creates a new instance of student and adds name, age, and grade
            Student s1 = new Student();
            s1.name = "John";
            s1.age = 17;
            s1.TheGrade = 'C';

            //Prints out the student variables
            s1.Print();

            //Creates a new instance of the address class and assigns values to the variables
            Address a1 = new Address();
            a1.Thestreet = "Main st";
            a1.Thecity = "Metropolis";
            a1.Thestate = "NY";
            a1.Thezip = "10001";

            //Prints out the address class
            a1.Print();

        }
    }
}
