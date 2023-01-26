using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConceptProgram
{
    internal class Factor
    {
        public void Primefactornumber()
        {
            //Uc5 Prime Factor 2,3,5,7,11,13
            Console.WriteLine("Enter the Number For PrimeFactor");
            int number = Convert.ToInt32(Console.ReadLine()); // 42

            while (number % 2 == 0) // even number /Only for 2 //42
            {
                Console.WriteLine(2); // print
                number /= 2;   // 42/2=21 break;
            }
            for (int j = 3; j < number; j+=2) // j = j+2 odd number
            {
                while (number % j == 0) // 21 true
                {
                    Console.WriteLine(j); //3
                    number /= j;  //21/3=7;
                }
            }
            //prime number is always greater than 2 // not for 1
            if (number > 2)
            {
                Console.WriteLine(number);
            }
        }
    }
}
