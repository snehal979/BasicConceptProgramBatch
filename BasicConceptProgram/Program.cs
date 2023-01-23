namespace BasicConceptProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Basic Concept Program");
                Console.WriteLine("Hint 1.FlipCoin 2.Leap Year 3.Power the Number");
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
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}