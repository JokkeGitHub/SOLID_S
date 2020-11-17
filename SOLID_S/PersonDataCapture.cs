using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_S
{
    public class PersonDataCapture
    {
        public static Person Capture()
        {
            // Ask the user for information
            Person output = new Person();

            Console.Write("What is your first name? : ");
            output.FirstName = Console.ReadLine();

            Console.Write("What is your lastname? : ");
            output.LastName = Console.ReadLine();

            return output;
        }
    }
}
