namespace AccountBalance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double sum = 0;
            while (input != "NoMoreMoney")
            {
                double balance = double.Parse(input);
                if (balance <= 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                sum += balance;
                Console.WriteLine($"Increase: {balance:F2}");
                input = Console.ReadLine();
            }

            Console.WriteLine($"Total: {sum:F2}");
        }
    }
}
