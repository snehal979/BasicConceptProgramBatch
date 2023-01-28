using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConceptProgram
{
    internal class HarmonicNumber
    {
        public void HarmonicNumberSeries()
        {
            //Uc4 harmonic number
            //variable
            double harmonic_sum = 0.0;
            Console.WriteLine("Harmonic Number series for n th number");
            //harmonic number serie = (1/1 + 1/2 + ... + 1/n)
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 0)
            {
                for (double i = 1; i<=number; i++)
                {

                    harmonic_sum = harmonic_sum +(1/i);
                }
                Console.WriteLine("Harmonic series For {0} th number is = {1}", number, harmonic_sum);

            }
            else
            {
                Console.WriteLine("Ensure the number is positive");
            }

        }

    }
}
