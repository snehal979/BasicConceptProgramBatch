using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConceptProgram
{
    internal class LeapYear
    {
        public void CheckTheLeapYear()
        {
            Console.WriteLine("Enter the Year");
            int year = Convert.ToInt32(Console.ReadLine());
            //Ensure that the year is Four Digit
            if (year.ToString().Length == 4)
            {
                if (year % 4 == 0)
                {
                    Console.WriteLine("{0} is the Leap Year", year);
                }
                else
                {
                    Console.WriteLine("{0} is not Leap Year", year);
                }
            }
            else
            {
                Console.WriteLine("Ensure that the year is Four digit");
            }
        }
                 
    }
}
