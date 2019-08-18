using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Temperature converter";

            TemperatureConverter obj = new TemperatureConverter();
            obj.Start();
        }
    }
}
