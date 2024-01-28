namespace Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double sum = 0;
            int poorNotsCount = 0;
            int grade = 1;

            while (grade <= 12)
            {
                double currentNote = double.Parse(Console.ReadLine());

                if (currentNote < 4)
                {
                    poorNotsCount++;

                    if (poorNotsCount > 1)
                    {
                        break;
                    }
                    grade--;
                }
                sum += currentNote;
                grade++;
            }

            if (poorNotsCount > 1)
            {
                Console.WriteLine($"{name} has been excluded at {grade} grade");
            }
            else
            {
                double average = sum / 12.0;
                Console.WriteLine($"{name} graduated. Average grade: {average:F2}");
            }
        }
    }
}
