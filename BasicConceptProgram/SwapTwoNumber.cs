using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConceptProgram
{
    internal class SwapTwoNumber
    {
        public void SwappingTwoNumber()
        {
            //Uc7 Swap two number
            Console.WriteLine("Enter First Number");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before Swapping number First number {0} and Second number {1}",first,second);
            Console.WriteLine("----------");
            int temp;
            temp = first;
            first=second;
            second=temp;
            Console.WriteLine("After Swapping number First number {0} and Second number {1}", first, second);

        }
    }
}
