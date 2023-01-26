using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConceptProgram
{
    internal class LargestNumber
    {
        public void LargestNumber_Three()
        {
            Console.WriteLine("Enter the First Number");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number");
            int second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third Number");
            int third = Convert.ToInt32(Console.ReadLine());
            if(first>second && first>third)
                Console.WriteLine("{0} first number is greater than second and third",first);
            else if(second>third && second>first)
                Console.WriteLine("{0} second number is greater than first and third",second);
            else Console.WriteLine("{0} third number is greater than second and first",third);
        }
    }
}
