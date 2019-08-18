using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class TemperatureConverter
    {
        public void Start()
        {
            int choice = 0;

            do
            {
                DisplayMenu();
                choice = Input.ReadIntegerConsole("Your choice: ");

                switch (choice)
                {
                    case 1:
                        CalculateFahrenheitToCelsius();
                        break;
                    case 2:
                        CalculateCelsiusToFahrenheit();
                        break;
                    case 0: // exit loop and exit app
                        break;

                    default:
                        Console.WriteLine("Invalid option, choose between 0 and 2.");
                        break;
                }


            } while (choice != 0);
        }



        private void DisplayMenu()
        {
            Console.WriteLine("***************************************");
            Console.WriteLine("              MAIN MENU                ");
            Console.WriteLine("***************************************");
            Console.WriteLine("   Convert Fahrenheit to Celsius : 1   ");
            Console.WriteLine("   Convert Celsius to Fahrenheit : 2   ");
            Console.WriteLine("   Exit program                  : 0   ");
            Console.WriteLine("***************************************");
        }


 
        private void CalculateCelsiusToFahrenheit()
        {
            double convertedValue = 0;
            string outgoingText = string.Empty;
            //string outgoingText = ""; // test

            for (int i = 0; i <= 100; i += 5)
            {
                convertedValue = CelsiusToFahrenheit(i);

                outgoingText = string.Format("{0,16:f2} C = {1,6:f2} F", i, convertedValue);
                Console.WriteLine(outgoingText);
            }
            Console.WriteLine();
        }



        private double CelsiusToFahrenheit(double celsius)
        {
            double fahrenheit = (9.0 / 5.0) * celsius + 32.0;
            return fahrenheit;
        }



        private void CalculateFahrenheitToCelsius()
        {
            double convertedValue = 0;
            string outgoingText = string.Empty;
            //string outgoingText = ""; // test

            for (int i = 0; i <= 212; i += 4)
            {
                convertedValue = FahrenheitToCelsius(i);

                outgoingText = string.Format("{0,16:f2} C = {1,16:f2} F", i, convertedValue);
                Console.WriteLine(outgoingText);
            }
            Console.WriteLine();
        }



        private double FahrenheitToCelsius(double fahrenheit)
        {
            double celsius = 5.0 / 9.0 * (fahrenheit - 32.0);
            return celsius;
        }
    }
}
