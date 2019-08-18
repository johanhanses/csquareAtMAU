using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1A
{
    class Pet
    {
        //input vars
        private string name;
        private int age;
        private bool isFemale;

        //test fields
        public double[] listA = { 4.5, 88.0, 77.7, 99.9 };
        public double[] listB = { 11.1, 22.3, 33.4, 100.0, 11, 9, -5 };

        const int size = 10;

        public string[] names = new string[size];

        public double[,] rectArray = new double[5, 6];

        private int[,] results = {{81, 130, 97, 92}, {75, 84, 93, 80},
                                 {19, 95, 92, 94}, {91, 13, 90, 77}};

        public void Start()
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to the pet app!");
            Console.WriteLine();

            //testing
            Console.WriteLine(GetResults(1, 2));

            //end of testing

            ReadAndSaveInput();
            DisplayPetInfo();

            Console.WriteLine("Press any key to exit");
        }

        public int GetResults(int row, int col)

        {

            return results[row, col];

        }

        private void ReadAndSaveInput()
        {
            ReadName();
            ReadAge();
            ReadGender();
        }

        private void ReadName()
        {
            Console.WriteLine("What is the name of your pet?");
            name = Console.ReadLine();
        }

        private void ReadAge()
        {
            Console.WriteLine($"What is your the age of {name}?");
            string strAge = Console.ReadLine();
            age = int.Parse(strAge);
        }

        private void ReadGender()
        {
            Console.WriteLine("Is your pet female? (y/n)");
            char response = char.Parse(Console.ReadLine());

            if ((response == 'y') || (response == 'Y'))
                isFemale = true;
            else
                isFemale = false;
        }

        private void DisplayPetInfo()
        {
            string text = $"Name: {name} Age: {age}";
            Console.WriteLine(text);

            string gender;
            if (isFemale)
                gender = "girl";
            else
                gender = "boy";

            string text2 = $"{name} is a good {gender}";
            Console.WriteLine(text2);
            Console.WriteLine();
        }
    }
}
