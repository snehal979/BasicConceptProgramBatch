namespace BasicConceptProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Basic Concept Program");
                Console.WriteLine("Hint 1.FlipCoin \n 2.Leap Year \n 3.Power the Number \n 4.PrimeFactor \n 5.Even or Odd " +
                    "\n 6.Swap two number");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        FilpCoinParcentage filpCoinParcentage = new FilpCoinParcentage();
                        filpCoinParcentage.CalculatePercentageOfFilpCoin();
                        break;
                    case 2:
                        LeapYear leapYear = new LeapYear();
                        leapYear.CheckTheLeapYear();
                        break;
                    case 3:
                        PowerOfNumber powerOfNumber = new PowerOfNumber();
                        powerOfNumber.CalculatePowerOfNumber();
                        break;
                    case 4:
                        Factor factor = new Factor();
                        factor.Primefactornumber();
                        break;
                    case 5:
                        EvenAndOddNumber evenAndOddNumber = new EvenAndOddNumber();
                        evenAndOddNumber.Check_NumIsEvenOrOdd();
                        break;
                    case 6:
                        SwapTwoNumber swapTwoNumber = new SwapTwoNumber();
                        swapTwoNumber.SwappingTwoNumber();
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}