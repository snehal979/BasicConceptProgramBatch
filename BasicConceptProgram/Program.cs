namespace BasicConceptProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Basic Concept Program");
                Console.WriteLine("Hint 1.FlipCoin");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        FilpCoinParcentage filpCoinParcentage = new FilpCoinParcentage();
                        filpCoinParcentage.CalculatePercentageOfFilpCoin();
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