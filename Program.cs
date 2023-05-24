namespace TeReoMaoriQuiz
{
    internal class Program
    {
        static void Main()
        {
            string[] eQuestionsAndAnswers = { // Declare an array called "eQuestionAndAnswers" that contains the quiz questions and answers for the Easy level
                  "Q1) What is the Māori word for Hello?\n1. Papa\n2. Kia Ora\n3. Manaakitanga\n4. Haere ra",
                  "Q2) What is the Māori word for Family?\n1. Whanau\n2. Waka\n3. Kikorangi\n4. Pango" ,
                  "Q3) What is the Māori word for Love?\n1. Aroha\n2. Ahiahi Pai\n3. Papura\n4. Parauri" ,
                  "Q4) What is the Māori word for Food?\n1. Ngako\n2. Kai\n3. Mea Atu\n4. Roopu" ,
                  "Q5) What is the Māori word for Mountain?\n1. Maunga\n2. Ua\n3. Aotearoa\n4. Koropiko"
            };
            string[] nQuestionsAndAnswers = { // Questions and answers for Normal level
                  "Q1) What is the Māori word for Land?\n1. Rangatira\n2. Whenua\n3. Whare\n4. Tangata",
                  "Q2) What is the Māori word for River?\n1. Awa\n2. Moana\n3. Wai\n4. Rangi",
                  "Q3) What is the Māori word for Hear?\n1. Rongo\n2. Whakarongo Mai\n3. Hapa\n4. Parauri",
                  "Q4) What is the Māori word for You?\n1. Ahau\n2. Koe\n3. Matou\n4. Ratou",
                  "Q5) What is the Māori word for Earth?\n1. Papatūānuku\n2. Tangaroa\n3. Tāne\n4. Rangi"
            };
            string[] hQuestionsAndAnswers = { // Questions and answers for Hard level
                  "Q1) What is the Māori word for Carving?\n1. Tekau\n2. Whakairo\n3. Tāniko\n4. Pango",
                  "Q2) What is the Māori word for Weaving?\n1. Raranga\n2. Poti\n3. Moana\n4. Ngā mihi",
                  "Q3) What is the Māori word for Clothing?\n1. Kakahu\n2. Māra\n3. Rākau\n4. Matimati",
                  "Q4) What is the Māori word for Plant?\n1. Whangi\n2. Tipu\n3. Tī\n4. Tuhi",
                  "Q5) What is the Māori word for Lieutenant?\n1. Rutene\n2. Ringa\n3. Hauhautanga\n4. Whanui"
            };

            bool choice = false;

            // Greet the user and ask for their name
            Console.Write("\t\tWelcome to my Te Reo Māori Quiz!\nPlease enter your name to begin: ");
            string userName = Console.ReadLine();

            while (string.IsNullOrEmpty(userName)) // Validate the user's name
            {
                Console.Write("Please enter a name with at least 1 letter: ");
                userName = Console.ReadLine();
            }

            do
            {   // Ask the user which level they want to play
                Console.Write($"\nHello {userName}! This quiz has 3 levels:\nPress E for Easy level\nPress N for Normal level\nPress H for Hard level\n\nEnter your choice here: ");

                string level = Console.ReadLine().ToLower();

                while (level != "e" && level != "n" && level != "h") // Validate the user's level choice
                {
                    Console.Write("Please enter a valid choice (E, N, or H): ");
                    level = Console.ReadLine().ToLower();
                }

                // Launch the selected level
                Console.Clear();
                if (level.Equals("e"))
                {
                    Quiz(userName, eQuestionsAndAnswers);
                }
                else if (level.Equals("n"))
                {
                    Quiz(userName, nQuestionsAndAnswers);
                }
                else if (level.Equals("h"))
                {
                    Quiz(userName, hQuestionsAndAnswers);
                }

                // Ask the user if they want to restart the quiz
                Console.Write("\nDo you want to restart the quiz? (Y/N)\n\nEnter your choice here:");
                string restart = Console.ReadLine().ToLower();

                while (!restart.Equals("y") && !restart.Equals("n")) // Validate the user's choice
                {
                    Console.Write("Please enter a valid choice (Y or N): ");
                    restart = Console.ReadLine().ToLower();
                }

                Console.Clear();
                if (restart.Equals("n"))
                {
                    choice = true; // Set choice to true if the user doesn't want to restart the quiz
                }

            } while (!choice);

            Console.WriteLine(userName + ", thank you for playing my quiz. Goodbye!");

        }// End of Main method.
        static void Quiz(string userName, string[] questions)
        {
            int[] correctAnswerIndex = { 1, 0, 0, 1, 0 }; // Declare an array called "correctAnswerIndex" that contains the index of the correct answer for each question

            int userAnswerIndex, score = 0; // Declare a variable called "userAnswerIndex" to store the user's answer and declare the variable "score" setting it to 0.

            // Print a welcome message to the screen, using the "userName" parameter
            Console.WriteLine("Welcome " + userName + "!\n\nIn this quiz, you'll be asked 5 questions about Māori words. Choose the correct answer from the options provided.\n");

            for (int i = 0; i < questions.Length; i++) // Loop through each question in the quiz, "i" represents the question index
            {
                Console.WriteLine(questions[i]); // Print the current question to the screen

                bool validInput = false; // Declare a variable called "validInput" and set it to false

                do // Ask the user to enter their answer and validate their input
                {
                    Console.Write("\nEnter your answer (1-4): ");
                    string userInput = Console.ReadLine();

                    if (int.TryParse(userInput, out userAnswerIndex))
                    {
                        userAnswerIndex--; // Subtract 1 from the user's input to match the answer index

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
                    Console.WriteLine($"\nIncorrect. The correct answer is {correctAnswerIndex[i] + 1}\n");
                }

                Console.WriteLine("Your score is: " + score + "\nPlease press any key to continue."); 
                Console.ReadKey(); Console.Clear();

            } // End of for loop

            // Display the final score and level completion message
            Console.WriteLine($"Congratulations, {userName}! You have completed this Level and scored {score} out of 5.");

            //In this code, we first define an array of questions and answers. Next, we display the question and the answer choices using a for loop. We then prompt the user to enter their answer and read their input from the console. After that, we use the do-while loop which keeps asking the user for input until they enter a valid choice. The int.TryParse() method is used to convert the user's input to an integer, and the value is checked to ensure it is within the range of valid choices. If the user enters an invalid choice, they will be prompted to enter a valid choice. Finally, we display a message indicating whether the user was correct or not and then show them their score.
            
            //At the end of the quiz, the user's score out of 5 is displayed and we ask them if they want to play the quiz again (yes or no). If their choice is yes (y) then we restart the quiz from the level selection part and if their choice is no (n) then we print a goodbye message on the screen and exit the program.

        }// End of Quiz method.
    }
}                                                       /*End Of My Code*/