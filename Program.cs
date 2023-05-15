namespace TeReoMaoriQuiz
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("\t\tWelcome to my Te Reo Māori Quiz!\nPlease enter your name to begin: "); // Greet the user and ask for their name
            string userName = Console.ReadLine();
            while (string.IsNullOrEmpty(userName)) // Validate the user's name
            {
                Console.Write("Please enter a name with at least 1 letter: ");
                userName = Console.ReadLine();
            }
            // Ask the user which level they want to play
            Console.Write($"\nHello {userName}! This quiz has 3 levels:\nPress E for Easy level\nPress N for Normal level\nPress H for Hard level\n\nEnter your choice here: ");
            string level = Console.ReadLine().ToLower();

            while (level != "e" && level != "n" && level != "h") // Validate the user's level choice
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
        }// End of Main method.
        static void Easy(string userName)
        {
            int score = 0; // Declare the variable "score" and set it to 0

            // Print a welcome message to the screen, using the "userName" parameter
            Console.WriteLine("Welcome to the Easy Level, " + userName + "!\n\nIn this quiz, you'll be asked 5 questions about Māori words and phrases. Choose the correct answer from the options provided.\n");

            string[] questions = { // Declare an array called "questions" that contains the quiz questions
                  "Q1) What is the Māori word for Hello?" ,
                  "Q2) What is the Māori word for Family?" ,
                  "Q3) What is the Māori word for Love?" ,
                  "Q4) What is the Māori word for Food?" ,
                  "Q5) What is the Māori word for Mountain?"
            };
            string[][] answers = { // Declare a 2-dimensional array called "answers" that contains the answer choices for each question
                new string[] { "Papa", "Kia Ora", "Manaakitanga", "Haere rā" },
                new string[] { "Whanau", "Waka", "Kikorangi", "Pango" },
                new string[] { "Aroha", "Ahiahi Pai", "Papura", "Parauri" },
                new string[] { "Ngako", "Kai", "Mea Atu", "Roopu" },
                new string[] { "Maunga", "Ua", "Aotearoa", "Koropiko" }
            };
            int[] correctAnswerIndex = { 1, 0, 0, 1, 0 }; // Declare an array called "correctAnswerIndex" that contains the index of the correct answer for each question

            int userAnswerIndex; // Declare a variable called "userAnswerIndex" to store the user's answer

            bool validInput = false; // Declare a variable called "validInput" to ensure the user enters a valid answer
            
            for (int i = 0; i < questions.Length; i++) // Loop through each question in the quiz
            {
                Console.WriteLine(questions[i]); // Print the current question to the screen

                for (int j = 0; j < answers[i].Length; j++) // Loop through each answer choice for the current question
                {
                    Console.WriteLine($"{j + 1}. {answers[i][j]}");
                }
                do // Ask the user to enter their answer and validate their input
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
                if (userAnswerIndex == correctAnswerIndex[i]) // Check if the user's answer is correct and update the score accordingly
                {
                    Console.WriteLine("\nCorrect!\n");
                    score++;
                }
                else
                {
                    Console.WriteLine("\nIncorrect. The correct answer is " + answers[i][correctAnswerIndex[i]] + ".\n");
                }
                Console.WriteLine("Your score is: " + score);
                Thread.Sleep(1500);
                Console.Clear();
            }
            Console.WriteLine($"Congratulations, {userName}! You have completed the Easy Level and scored {score} out of 5.\n");
            if (score == 5)
            {
                Console.WriteLine("Perfect score! Well done!");
            }
            RestartMenu(userName); // Asking the user if they want to play the quiz again, play any other levels or quit the program

            //In this code, we first define a question and an array of possible answers. We also specify the index of the correct answers (in this case, 1, since the correct answer is "Kia Ora"). The 2D array is used to allow for easy access to the answer choices for each question in the quiz. The program can loop through each row of the array to display the answer choices for the current question, and can access the correct answer for each question using the index of the correct answer stored in the "correctAnswerIndex" array. Next, we display the question and the possible answers using a for loop to iterate over the answers array. We then prompt the user to enter their answer and read their input from the console. After that, we use the do-while loop which keeps asking the user for input until they enter a valid choice. The int.TryParse() method is used to convert the user's input to an integer, and the value is checked to ensure it is within the range of valid choices. If the user enters an invalid choice, they will be prompted to enter a valid choice. Then we display a message indicating whether the user was correct or not and then show their score. At the end of the quiz, the user's score out of 5 is displayed, and they are given the option to restart the quiz, play another level, or exit the program.
        }// End of Easy method.
        static void Normal(string userName)
        {
            int score = 0;
            Console.WriteLine("Welcome to the Normal Level, " + userName + "!\n\nIn this quiz, you'll be asked 5 questions about Māori words and phrases. Choose the correct answer from the options provided.\n");
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
                Console.WriteLine("Your score is: " + score);
                Thread.Sleep(1500);
                Console.Clear();
            }
            Console.WriteLine($"Congratulations, {userName}! You have completed the Normal Level and scored {score} out of 5.\n");
            if (score == 5)
            {
                Console.WriteLine("Perfect score! Well done!");
            }
            RestartMenu(userName);
        }// End of Normal method.
        static void Hard(string userName)
        {
            int score = 0;
            Console.WriteLine("Welcome to the Hard Level, " + userName + "!\n\nIn this quiz, you'll be asked 5 questions about Māori words and phrases. Choose the correct answer from the options provided.\n");
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

                Console.WriteLine("Your score is: " + score);
                Thread.Sleep(1500);
                Console.Clear();
            }
            Console.WriteLine($"Congratulations, {userName}! You have completed the Hard Level and scored {score} out of 5.\n");
            if (score == 5)
            {
                Console.WriteLine("Perfect score! Well done!");
            }
            RestartMenu(userName);
        }// End of Hard method.
        static void RestartMenu(string userName)
        {
            Console.WriteLine("Please choose one of the following options:\nRestart the quiz (type 'R')\nPlay the Easy level (type 'E')\nPlay the Normal level (type 'N')\nPlay the Hard level (type 'H')\nQuit the program (type 'Q')");
            // Get user input and validate it
            string choice = Console.ReadLine().ToLower();
            while (true)
            {
                if (choice.Equals("r"))
                {
                    Console.Clear();
                    Main();
                    break;
                }
                else if (choice.Equals("e"))
                {
                    Console.Clear();
                    Easy(userName);
                    break;
                }
                else if (choice.Equals("n"))
                {
                    Console.Clear();
                    Normal(userName);
                    break;
                }
                else if (choice.Equals("h"))
                {
                    Console.Clear();
                    Hard(userName);
                    break;
                }
                else if (choice.Equals("q"))
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
        }// End of RestartMenu method.
    }// End of internal class Program.
}// End of my code.