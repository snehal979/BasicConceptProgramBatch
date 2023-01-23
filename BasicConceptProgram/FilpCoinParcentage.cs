using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConceptProgram
{
    internal class FilpCoinParcentage
    {
        //Uc1 Flip Coin and print percentage of Heads and Tails
        public void CalculatePercentageOfFilpCoin()
        {
            // Variable
            int tailCount = 0;
            int headCount = 0 ;
            double tailPercentage;
            double headPercentage;
            Console.WriteLine("Enter the number for choice head or tail");
            int totalCount = Convert.ToInt32(Console.ReadLine());

            //Random Number for choice head or tail
            Random random = new Random();
            if(totalCount > 0)
            {
                for (int i = 1; i <= totalCount; i++)
                {
                    double flipCoin = random.NextDouble(); // 0.0 to 1.0
                    if (flipCoin < 0.5)
                    {
                        tailCount++;
                    }
                    else
                    {
                        headCount++;
                    }
                }
                Console.WriteLine("Total count of Tail {0}", tailCount);
                Console.WriteLine("Total count of Head {0}", headCount);
                // Total percentage of Heads and Tails
                tailPercentage = (tailCount *100)/ totalCount;
                Console.WriteLine("Tail Percentage of coin {0} %",tailPercentage);
                headPercentage = (headCount*100)/totalCount;
                Console.WriteLine("Head Percentage of coin {0} %",headPercentage);
            }
            else
            {
                Console.WriteLine("Enter the Positive value");
            }
           
        }
    }
}
