using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConceptProgram
{
    internal class PowerOfNumber
    {
        public void CalculatePowerOfNumber()
        {
            int base_Num = 2;
            int product = 1;
            Console.WriteLine("Enter the Power of Number");
            int power_Num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= power_Num; i++)
            {
                product = product * base_Num;
                //// Math Method for Power of Number
                ////Console.WriteLine("base {0} and power of is {1}", base_Num, i);
               ////Console.WriteLine(Math.Pow(base_Num, i));
            }
            Console.WriteLine("{0}^{1} = {2} ",base_Num,power_Num ,product);
        }
    }
}
