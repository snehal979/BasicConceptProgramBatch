namespace BasicConceptProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                try
                {
                    Console.WriteLine("Basic Concept Program");
                    Console.WriteLine("Hint 1.FlipCoin \n 2.Leap Year \n 3.Power the Number \n 4.PrimeFactor \n 5.Even or Odd " +
                        "\n 6.Swap two number \n 7.Alphabet Vowel or Consonat \n 8.Largest Number between 3 number \n 9.Divison number \n 10.Harmonic Number \n 11.Exit");
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
                        case 7:
                            Alphabet alphabet = new Alphabet();
                            alphabet.CheckVowelOrConsonat();
                            break;
                        case 8:
                            LargestNumber largestNumber = new LargestNumber();
                            largestNumber.LargestNumber_Three();
                            break;
                        case 9:
                            DivisonNumber divisonNumber = new DivisonNumber();
                            divisonNumber.QuoteientRemainder();
                            break;
                        case 10:
                            HarmonicNumber harmonicNumber = new HarmonicNumber();
                            harmonicNumber.HarmonicNumberSeries();
                            break;
                        case 11:
                            flag = false;
                            Console.WriteLine("Exit");
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
}