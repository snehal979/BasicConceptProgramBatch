using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConceptProgram
{
    internal class DivisonNumber
    {
        public void QuoteientRemainder()
        {
            int quotient, remainder;
            Console.WriteLine("Enter a number divident");
            int divident = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number dividor");
            int dividor = Convert.ToInt32(Console.ReadLine());
            quotient = divident/ dividor;
            remainder = divident% dividor;
            Console.WriteLine("Quotitent {0} and Remainder {1} ", quotient, remainder);
        }
    }
}
