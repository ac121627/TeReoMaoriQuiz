using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Sources;
using static System.Formats.Asn1.AsnWriter;

namespace TeReoMaoriQuiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            quiz();
        }// End of Main method.
        static void quiz()
        {
            // Greet the user and ask for their name
            Console.WriteLine("\t\tWelcome to my Te Reo Māori Quiz!");
            Console.Write("\nPlease enter your name to begin: ");
            string userName = Console.ReadLine();

            // Validate the user's name
            while (string.IsNullOrEmpty(userName))
            {
                Console.Write("Please enter a name with at least 1 character: ");
                userName = Console.ReadLine();
            }

            // Ask the user which level they want to play
            Console.WriteLine($"\nHello {userName}! This quiz has 3 levels:\n");
            Console.WriteLine("Press E for Easy level");
            Console.WriteLine("Press N for Normal level");
            Console.WriteLine("Press H for Hard level");
            Console.Write("\nEnter your choice here: ");
            string level = Console.ReadLine().ToLower();

            // Validate the user's level choice
            while (level != "e" && level != "n" && level != "h")
            {
                Console.Write("Please enter a valid choice (E, N, or H): ");
                level = Console.ReadLine().ToLower();
            }

            // Launch the selected level
            Console.Clear();
            if (level == "e")
            {
                Easy(userName);
            }
            else if (level == "n")
            {
                Normal(userName);
            }
            else if (level == "h")
            {
                Hard(userName);
            }

        }// End of quiz method.
        static void Easy(string userName)
        {
            int score = 0;
            Console.WriteLine("Welcome to the Easy Level, "+ userName +"!\n\nIn this quiz, you'll be asked 5 questions about Māori words and phrases. Choose the correct answer from the options provided.\n");
            string[] questions = {
                  "Q1) What is the Māori word for Hello?" ,
                  "Q2) What is the Māori word for Family?" ,
                  "Q3) What is the Māori word for Love?" ,
                  "Q4) What is the Māori word for Food?" ,
                  "Q5) What is the Māori word for Mountain?"
            };

            string[][] answers = {
                new string[] { "Papa", "Kia Ora", "Manaakitanga", "Haere rā" },
                new string[] { "Whanau", "Waka", "Kikorangi", "Pango" },
                new string[] { "Aroha", "Ahiahi Pai", "Papura", "Parauri" },
                new string[] { "Ngako", "Kai", "Mea Atu", "Roopu" },
                new string[] { "Maunga", "Ua", "Aotearoa", "Koropiko" }
            };

            int[] correctAnswerIndex = { 1, 0, 0, 1, 0 };

            int userAnswerIndex;

            bool validInput = false;

            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine(questions[i]);

                for (int j = 0; j < answers[i].Length; j++)
                {
                    Console.WriteLine($"{j + 1}. {answers[i][j]}");
                }

                do
                {
                    Console.Write("\nEnter your answer (1-4): ");
                    string userInput = Console.ReadLine();

                    if (int.TryParse(userInput, out userAnswerIndex))
                    {
                        userAnswerIndex--;
                        if (userAnswerIndex >= 0 && userAnswerIndex < 4)
                        {
                            validInput = true;
                        }
                    }

                    if (!validInput)
                    {
                        Console.WriteLine("Invalid input. Please enter a number from 1 to 4.");
                    }

                } while (!validInput);

                if (userAnswerIndex == correctAnswerIndex[i])
                {
                    Console.WriteLine("\nCorrect!\n");
                    score++;
                }
                else
                {
                    Console.WriteLine("\nIncorrect. The correct answer is " + answers[i][correctAnswerIndex[i]] + ".\n");
                }

                Console.WriteLine("Your score is: " + score + "\nPress any key to continue to the next question.");
                Console.ReadKey();
                Console.Clear();
            }
            Console.WriteLine($"Congratulations, {userName}! You have completed the Easy Level and scored {score} out of 5.\n");

            if (score == 5)
            {
                Console.WriteLine("Perfect score! Well done!");
            }

            // Prompt the user for their next action
            Console.WriteLine("Please choose one of the following options:");
            Console.WriteLine("1. Restart the quiz (type 'R')");
            Console.WriteLine("2. Play the Easy level again (type 'E')");
            Console.WriteLine("3. Play the Normal level (type 'N')");
            Console.WriteLine("4. Play the Hard level (type 'H')");
            Console.WriteLine("5. Quit the program (type 'Q')");

            // Get user input and validate it
            string choice = Console.ReadLine().ToLower();
            while (true)
            {
                if (choice == "r")
                {
                    Console.Clear();
                    quiz();
                    break;
                }
                else if (choice == "e")
                {
                    Console.Clear();
                    Easy(userName);
                    break;
                }
                else if (choice == "n")
                {
                    Console.Clear();
                    Normal(userName);
                    break;
                }
                else if (choice == "h")
                {
                    Console.Clear();
                    Hard(userName);
                    break;
                }
                else if (choice == "q")
                {
                    Console.Clear();
                    Console.WriteLine(userName + ", thank you for playing the quiz. Goodbye!");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please enter a valid option (1-5):");
                    choice = Console.ReadLine().ToLower();
                }
            }
            /*In this code, we first define a question and an array of possible answers. We also specify the
            index of the correct answer (in this case, 1, since the correct answer is "Kia Ora").

            Next, we display the question and the possible answers using a for loop to iterate over the
            answers array. We then prompt the user to enter their answer and read their input from the
            console.

            After that, we use the do-while loop which keeps asking the user for input until they enter a valid choice. 
            The int.TryParse() method is used to convert the user's input to an integer, and the value is checked to 
            ensure it is within the range of valid choices. If the user enters an invalid choice, they will be prompted to 
            enter a valid choice. Then we display a message indicating whether the user was correct or not and then show their 
            score. we use the Console.ReadKey() method to wait for the user to press a key before continuing to the next question.
            
            Finally, after the user has finished the set of 5 questions we display their score out of 5 and prompt 
            them to either restart the quiz from the beginning, play the easy level, play the normal level, play the 
            hard level or to exit the quiz.*/

        }// End of Easy method.
        static void Normal(string userName)
        {
            int score = 0;
            Console.WriteLine("Welcome to the Normal Level, "+ userName +"!\n\nIn this quiz, you'll be asked 5 questions about Māori words and phrases. Choose the correct answer from the options provided.\n");
            string[] questions = {
                     "Q1) What is the Māori word for Land?",
                     "Q2) What is the Māori word for River?",
                     "Q3) What is the Māori word for Hear?",
                     "Q4) What is the Māori word for You?",
                     "Q5) What is the Māori word for Earth?"
            };

            string[][] answers = {
                 new string[] { "Rangatira", "Whenua", "Whare", "Tangata" },
                 new string[] { "Awa", "Moana", "Wai", "Rangi" },
                 new string[] { "Rongo", "Whakarongo Mai", "Hapa", "Parauri" },
                 new string[] { "Ahau", "Koe", "Matou", "Ratou" },
                 new string[] { "Papatūānuku", "Tangaroa", "Tāne", "Rangi" }
            };

            int[] correctAnswerIndex = { 1, 0, 0, 1, 0 };

            int userAnswerIndex;

            bool validInput = false;

            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine(questions[i]);

                for (int j = 0; j < answers[i].Length; j++)
                {
                    Console.WriteLine($"{j + 1}. {answers[i][j]}");
                }

                do
                {
                    Console.Write("\nEnter your answer (1-4): ");
                    string userInput = Console.ReadLine();

                    if (int.TryParse(userInput, out userAnswerIndex))
                    {
                        userAnswerIndex--;
                        if (userAnswerIndex >= 0 && userAnswerIndex < 4)
                        {
                            validInput = true;
                        }
                    }

                    if (!validInput)
                    {
                        Console.WriteLine("Invalid input. Please enter a number from 1 to 4.");
                    }

                } while (!validInput);

                if (userAnswerIndex == correctAnswerIndex[i])
                {
                    Console.WriteLine("\nCorrect!\n");
                    score++;
                }
                else
                {
                    Console.WriteLine("\nIncorrect. The correct answer is " + answers[i][correctAnswerIndex[i]] + ".\n");
                }

                Console.WriteLine("Your score is: " + score + "\nPress any key to continue to the next question.");
                Console.ReadKey();
                Console.Clear();
            }

            Console.WriteLine($"Congratulations, {userName}! You have completed the Normal Level and scored {score} out of 5.\n");

            if (score == 5)
            {
                Console.WriteLine("Perfect score! Well done!");
            }

            // Prompt the user for their next action
            Console.WriteLine("Please choose one of the following options:");
            Console.WriteLine("1. Restart the quiz (type 'R')");
            Console.WriteLine("2. Play the Easy level (type 'E')");
            Console.WriteLine("3. Play the Normal level again (type 'N')");
            Console.WriteLine("4. Play the Hard level (type 'H')");
            Console.WriteLine("5. Quit the program (type 'Q')");

            // Get user input and validate it
            string choice = Console.ReadLine().ToLower();
            while (true)
            {
                if (choice == "r")
                {
                    Console.Clear();
                    quiz();
                    break;
                }
                else if (choice == "e")
                {
                    Console.Clear();
                    Easy(userName);
                    break;
                }
                else if (choice == "n")
                {
                    Console.Clear();
                    Normal(userName);
                    break;
                }
                else if (choice == "h")
                {
                    Console.Clear();
                    Hard(userName);
                    break;
                }
                else if (choice == "q")
                {
                    Console.Clear();
                    Console.WriteLine(userName + ", thank you for playing the quiz. Goodbye!");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please enter a valid option (1-5):");
                    choice = Console.ReadLine().ToLower();
                }
            }
        }// End of Normal method.
        static void Hard(string userName)
        {
            int score = 0;
            Console.WriteLine("Welcome to the Hard Level, "+ userName +"!\n\nIn this quiz, you'll be asked 5 questions about Māori words and phrases. Choose the correct answer from the options provided.\n");
            string[] questions = {
                "Q1) What is the Māori word for Carving?",
                "Q2) What is the Māori word for Weaving?",
                "Q3) What is the Māori word for Clothing?",
                "Q4) What is the Māori word for Plant?",
                "Q5) What is the Māori word for Lieutenant?"
            };

            string[][] answers = {
                new string[] { "Tekau", "Whakairo", "Tāniko", "Pango" },
                new string[] { "Raranga", "Poti", "Moana", "Ngā mihi" },
                new string[] { "Kakahu", "Māra", "Rākau", "Matimati" },
                new string[] { "Whangi", "Tipu", "Tī", "Tuhi" },
                new string[] { "Rutene", "Ringa", "Hauhautanga", "Whanui" }
            };

            int[] correctAnswerIndex = { 1, 0, 0, 1, 0 };

            int userAnswerIndex;

            bool validInput = false;

            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine(questions[i]);

                for (int j = 0; j < answers[i].Length; j++)
                {
                    Console.WriteLine($"{j + 1}. {answers[i][j]}");
                }

                do
                {
                    Console.Write("\nEnter your answer (1-4): ");
                    string userInput = Console.ReadLine();

                    if (int.TryParse(userInput, out userAnswerIndex))
                    {
                        userAnswerIndex--;
                        if (userAnswerIndex >= 0 && userAnswerIndex < 4)
                        {
                            validInput = true;
                        }
                    }

                    if (!validInput)
                    {
                        Console.WriteLine("Invalid input. Please enter a number from 1 to 4.");
                    }

                } while (!validInput);

                if (userAnswerIndex == correctAnswerIndex[i])
                {
                    Console.WriteLine("\nCorrect!\n");
                    score++;
                }
                else
                {
                    Console.WriteLine("\nIncorrect. The correct answer is " + answers[i][correctAnswerIndex[i]] + ".\n");
                }

                Console.WriteLine("Your score is: " + score + "\nPress any key to continue to the next question.");
                Console.ReadKey();
                Console.Clear();
            }
            Console.WriteLine($"Congratulations, {userName}! You have completed the Easy Level and scored {score} out of 5.\n");

            if (score == 5)
            {
                Console.WriteLine("Perfect score! Well done!");
            }
            
            // Prompt the user for their next action
            Console.WriteLine("Please choose one of the following options:");
            Console.WriteLine("1. Restart the quiz (type 'R')");
            Console.WriteLine("2. Play the Easy level (type 'E')");
            Console.WriteLine("3. Play the Normal level (type 'N')");
            Console.WriteLine("4. Play the Hard level again (type 'H')");
            Console.WriteLine("5. Quit the program (type 'Q')");

            // Get user input and validate it
            string choice = Console.ReadLine().ToLower();
            while (true)
            {
                if (choice == "r")
                {
                    Console.Clear();
                    quiz();
                    break;
                }
                else if (choice == "e")
                {
                    Console.Clear();
                    Easy(userName);
                    break;
                }
                else if (choice == "n")
                {
                    Console.Clear();
                    Normal(userName);
                    break;
                }
                else if (choice == "h")
                {
                    Console.Clear();
                    Hard(userName);
                    break;
                }
                else if (choice == "q")
                {
                    Console.Clear();
                    Console.WriteLine(userName + ", thank you for playing the quiz. Goodbye!");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please enter a valid option (1-5):");
                    choice = Console.ReadLine().ToLower();
                }
            }
        }// End of Hard method.
    }// End of internal class Program.
}// End of my code.