namespace HW12
{
    //Creates a student class
    internal class Student
    {
        public string name;
        public int age;
        private char grade;


        public char TheGrade
        {
            get { return grade; }
            set { grade = value; }
        }

        //Method to print the student
        public void Print()
        {
            Console.WriteLine($"My name is {name} and I am {age} years old. My class grade is {TheGrade}");
        }
    }

    //Creates an address class
    internal class Address
    {
        private string street;
        private string city;
        private string state;
        private string zip;

        //Makes getters/setters to provide controlled accesss to the original code 
        public string Thestreet
        {
            get { return street; }
            set { street = value; }
        }
        public string Thecity
        {
            get { return city; }
            set { city = value; }
        }
        public string Thestate
        {
            get { return state; }
            set { state = value; }
        }
        public string Thezip
        {
            get { return zip; }
            set { zip = value; }
        }

        //Method to print the adress
        public void Print()
        {
            Console.WriteLine($"My address is {Thestreet}, {Thecity}, {Thestate}, {Thezip}");
        }

    }
}