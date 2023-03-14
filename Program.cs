namespace TeReoMaoriQuiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // I am welcoming the user and asking for their name.
            String name;
            Console.WriteLine("\tWelcome To My Te Reo Maori Quiz!\n\t\tI Hope You Enjoy");
            Console.WriteLine("Please Enter Your Name:");
            name = Console.ReadLine();
            Console.WriteLine("Hello " + name + ", this is a quiz with 3 levels with 10 questions on each level.");
        }
    }
}