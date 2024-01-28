namespace MaxNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int maxNumber = int.MinValue;

            while(input != "Stop")
            {
                int nextNumber = int.Parse(input);

                if (nextNumber > maxNumber)
                {
                    maxNumber = nextNumber;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(maxNumber);
        }
    }
}
