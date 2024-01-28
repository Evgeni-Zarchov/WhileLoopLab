namespace Sequence2K_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int step = 1;

            while (step <= n)
            {
                Console.WriteLine(step);
                step = step * 2 + 1;
            }
        }
    }
}
