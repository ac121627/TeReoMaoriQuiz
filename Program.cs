using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Sources;
namespace TeReoMaoriQuiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            quiz(check:(""));
        }// End of Main method.
        static void quiz(string check)
        {
            // I am welcoming the user, asking for their name and asking which level they want to play.
            String userName, level;
            Console.Write("\tWelcome To My Te Reo Māori Quiz!\n\t\tI Hope You Enjoy\n\nPlease enter your name to begin: ");
            userName = Console.ReadLine();
            while (string.IsNullOrEmpty(userName))
            {
                Console.Write("Please enter a valid name: ");
                userName = Console.ReadLine();
            }
            Console.Write("\nHello " + userName + ", this is a Te Reo Māori quiz with 3 levels (Easy, Normal, Hard) and 5 questions on each level.\n\tEasy level(E)\tNormal level (N)\tHard level (H)\n\nEnter Your choice here: ");
            level = Console.ReadLine().ToLower();
            while (string.IsNullOrEmpty(level))
            {
                Console.Write("Please enter a valid choice: ");
                level = Console.ReadLine();
            }
            Console.Clear();
            if (level.Equals("e"))
            {
                Easy(userName, check: 0);
            }
            if (level.Equals("n"))
            {
                Normal(userName, check:0);
            }
            if (level.Equals("h"))
            {
                Hard(userName, check:0);
            }
        }
        static void Easy(string userName, int check)
        {
            int score = 0;
            Console.WriteLine("Welcome To The Easy Level " + userName + ",\nHope You Have Fun!\n");
            string[] questions = {
                "Q1) What is the Māori word for hello?",
                "Q2) What is the Māori word for family?",
                "Q3) What is the Māori word for love?",
                "Q4) What is the Māori word for food?",
                "Q5) What is the Māori word for mountain?"
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

            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine(questions[i]);

                for (int j = 0; j < answers[i].Length; j++)
                {
                    Console.WriteLine($"{j + 1}. {answers[i][j]}");
                }
                
                    Console.Write("\nEnter your answer (1-4): ");
                    userAnswerIndex = int.Parse(Console.ReadLine()) - 1;

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
                Console.ReadKey();
                Console.Clear();
            }

            Console.WriteLine(userName + ", You have scored " + score + " out of 5 on the Easy level.");
            Console.ReadKey();
            /*In this code, we first define a question and an array of possible answers. We also specify the
            index of the correct answer (in this case, 1, since the correct answer is "Kia Ora").

            Next, we display the question and the possible answers using a for loop to iterate over the
            answers array. We then prompt the user to enter their answer and read their input from the
            console.

            Finally, we check whether the user's answer index matches the index of the correct answer,
            and display a message indicating whether the user was correct or not. We use the
            Console.ReadKey() method to wait for the user to press a key before exiting the program.*/
        }
        static void Normal(string userName, int check)
        {
            int score = 0;
            Console.WriteLine("Welcome To The Normal Level "+userName+",\nHope You Have Fun!\n");
            string[] questions = {
                "Q1) What is the word for land in Māori?",
                "Q2) What is the Māori word for river?",
                "Q3) What is the Māori word for hear?",
                "Q4) What is the Māori word for you?",
                "Q5) What is the Māori word for earth?"
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

            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine(questions[i]);

                for (int j = 0; j < answers[i].Length; j++)
                {
                    Console.WriteLine($"{j + 1}. {answers[i][j]}");
                }
       
                Console.Write("\nEnter your answer (1-4): ");
                validAns(check);
                userAnswerIndex = int.Parse(Console.ReadLine()) - 1;
                
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
                Console.ReadKey();
                Console.Clear();
            }

            Console.WriteLine(userName+", You have scored " + score + " out of 5 on the Normal level.");
            Console.ReadKey();
        }
        static void Hard(string userName, int check)
        {
            int score = 0;
            Console.WriteLine("Welcome To The Hard Level " + userName + ",\nHope You Have Fun!\n");
            string[] questions = {
                "Q1) What is the Māori word for carving?",
                "Q2) What is the Māori word for weaving?",
                "Q3) What is the Māori word for clothing?",
                "Q4) What is the Māori word for plant?",
                "Q5) What is the Māori word for lieutenant?"
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

            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine(questions[i]);

                for (int j = 0; j < answers[i].Length; j++)
                {
                    Console.WriteLine($"{j + 1}. {answers[i][j]}");
                }
                
                 Console.Write("\nEnter your answer (1-4): ");
                 userAnswerIndex = int.Parse(Console.ReadLine()) - 1;        

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
                Console.ReadKey();
                Console.Clear();

            }

            Console.WriteLine("\nYou have scored " + score + " out of 5 on the Hard level.");
            Console.ReadKey();

            Console.WriteLine("\n\tCongratulations! You have completed the Hard level.\n\n\tIf you want to exit the quiz press any key.\n\tIf you want to start the quiz all over again press 'R'\n\tIf you want to play the Easy level press 'E'\n\tIf you want to play the Normal level prss 'N'\n\tIf you want to play the Hard level press 'H'");
            String endOfQuiz = Console.ReadLine().ToLower();
            if (endOfQuiz.Equals("e"))
            {
                Easy(userName,check);
            }
            else if (endOfQuiz.Equals("n"))
            {
                Normal(userName, check);
            }
            else if (endOfQuiz.Equals("h"))
            {
                Hard(userName, check);
            }
            else
            {
                Console.WriteLine("\t"+userName+", Thank You for playing the Quiz\n\tHope You Enjoyed Your time!");
            }
        }
        static bool validAns(int check)
        {
            do
            {
                if (check == 1 || check == 2 || check == 3 || check == 4)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            } while (true);
        }
        static bool validLevel(string check)
        {
            do
            {
                if (check.Equals("e") || check.Equals("n") || check.Equals("h"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            } while (true);
        }
    }
}