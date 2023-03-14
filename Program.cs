namespace TeReoMaoriQuiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // I am welcoming the user and asking for their name.
            String name;
            Console.Write("\tWelcome To My Te Reo Maori Quiz!\n\t\tI Hope You Enjoy\n\nPlease enter your name: ");
            name = Console.ReadLine();

            Console.WriteLine("\nHello " + name + ", this is a te reo maori quiz with 3 levels and 10 questions on each level.");
        }
    }
}