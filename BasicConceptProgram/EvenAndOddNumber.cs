using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConceptProgram
{
    internal class EvenAndOddNumber
    {
        public void Check_NumIsEvenOrOdd()
        {
            Console.WriteLine("Enter the number is even or odd");
            int number = Convert.ToInt32(Console.ReadLine());
            if(number > 0)
            {
                if (number % 2 == 0)
                    Console.WriteLine("{0} This is Even Number", number);
                else
                    Console.WriteLine("{0} This is odd Number", number);
            }
            else
            {
                Console.WriteLine("Enter the positive Number");
            }
            
        }
    }
}
