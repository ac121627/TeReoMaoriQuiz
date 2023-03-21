namespace TeReoMaoriQuiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
             /*questions for easy level. 
               question 1. what is the word for the colour red in te reo maori?
                            a. whero 
                            b. kowhai 
                            c. kikorangi

            question 2. what is the word for canoe in te reo maori?
            a. kia ora b. whanau c. waka

            question 3. what is the word for family in te reo maori?
            a. ma b. pango c. whanau

            question 4. what is the word for the colour blue in te reo maori?(ans:kahurangi)
            a. kahurangi b. kakariki c. mawhero

            question 5: what is the word for hello in te reo maori?
            a. parauri b. papura c. kia ora

            QUESTIONS FOR HARD LEVEL.

            question 1. what is the word for lieutenant in te reo maori?(ans:rutene)
            a. ringa b. waewae c. rutene

            question 2. what is 'waewae' in english?(ans:leg)
            a. stomach b. arm c. leg

            question 3. what is the word for read in te reo maori? (ans:panui)
            a. puku b. whanau c. panui

            question 4. what is 'tuhi' in english? (ans:write)
            a. pencil b. write c. stomach 

            question 5. what is the word for canoe in te reo maori?
            a. kia ora b. whanau c. waka*/
            
            quiz();
        }// End of Main method.
        static void quiz()
        { Console.WriteLine();
            // I am welcoming the user and asking for their name.
            String name;
            Console.Write("\tWelcome To My Te Reo Maori Quiz!\n\t\tI Hope You Enjoy\n\nPlease enter your name to begin: ");
            name = Console.ReadLine();
            Console.WriteLine("\nHello " + name + ", this is a te reo maori quiz with 3 levels (Easy, Normal, Hard) and 5 questions on each level.\nPlease pick which level you want to do: ");
            Easy();
        }
        static void Easy()
        {
            string question = "What is the word for 'red' in Te Reo Maori?";
            string[] answers = { "Kowhai", "Whero", "Pango", "Ma" };
            int correctAnswerIndex = 1;
            int userAnswerIndex;

            Console.WriteLine(question);

            for (int i = 0; i < answers.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {answers[i]}");
            }

            Console.WriteLine("Enter your answer (1-4): ");
            userAnswerIndex = int.Parse(Console.ReadLine()) - 1;

            if (userAnswerIndex == correctAnswerIndex)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Incorrect. The correct answer is " + answers[correctAnswerIndex] + ".");
            }

            Console.ReadKey();
        }
    }
}
