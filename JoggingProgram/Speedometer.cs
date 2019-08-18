using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoggingProgram
{
    class Speedometer
    {
        // input variables
        private double distance; //unit less
        private double time; //unit less
        private string name;
        private int age;

        //output variables
        private double speed;
        //private bool isChild; // age > 18



        public void Start()
        {
            for (int i = 1; i < 10; i += 2)
            {
                Console.Write(i);
            }

            ReadInput();
            Calculate();
            DisplayResults();
        }



        private void ReadInput()
        {
            ReadName();
            ReadAge();
            ReadDistance();
            ReadTime();
        }

        private void ReadName()
        {
            Console.WriteLine("What's your name?");
            name = Console.ReadLine();
        }

        private void ReadAge()
        {
            Console.WriteLine("What's your age?");
            string strAge = Console.ReadLine();
            age = int.Parse(strAge);
        }

        private void ReadTime()
        {
            Console.WriteLine("What's your time? (Any unit)");
            string strTime = Console.ReadLine();
            time = double.Parse(strTime);
        }

        private void ReadDistance()
        {
            Console.WriteLine("How long a distance did you jogg/walk? (Any unit)");
            string strDistance = Console.ReadLine();
            distance = double.Parse(strDistance);
        }



        private void Calculate()
        {
            if (time != 0.000)
                speed = distance / time;
            else
            {
                Console.WriteLine("Time cannot be zero!");
                speed = -1.00;
            }
        }

        private void CalculateKMPerH()
        {
            distance = distance / 1000.0; // m to km
            time = time / 60; // minutes to h

            speed = distance / time;
        }



        private void DisplayResults()
        {
            Console.WriteLine(); //blank space
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++");
            Console.WriteLine($"Your speed is {speed, 10:f2}!");
            Console.WriteLine(); //blank space
            CalculateKMPerH(); // speed value is changed
            Console.WriteLine($"Your speed is {speed, 4:f2} km/hr based on distance {distance, 4:f2} km and {time, 4:f2} hours.");

            bool isChild = (age <= 18);
            if (isChild)
                Console.WriteLine($"For a child, that is a good one!");
        }

    }
}
