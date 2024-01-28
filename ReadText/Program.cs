namespace ReadText
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // So i have to write a program to print something like country civilization.... but the task is hard if i hardcode some console readline so im gonna use while loop and the given task is while user write command stop this is a break of the loop

            string text = Console.ReadLine();

            while (text != "Stop")
            {
                Console.WriteLine(text);
                text = Console.ReadLine();
            }
            
        }
    }
}
