using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoggingProgram
{
    class JoggingApp
    {
        static void Main(string[] args)
        {
            //Create an object of the speedometer, and call a method

            Speedometer obj = new Speedometer();
            obj.Start();
            Console.ReadLine();
        }
    }
}
