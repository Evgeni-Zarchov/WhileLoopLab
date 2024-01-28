namespace Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // I have to write a program for password if the password equals the input pass print welcome 

            string username = Console.ReadLine();
            string password = Console.ReadLine();

            string inputPassword = Console.ReadLine();

            while (inputPassword != password)
            {
                inputPassword = Console.ReadLine();
            }
            Console.WriteLine($"Welcome {username}!");
        }
    }
}
