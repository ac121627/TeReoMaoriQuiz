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
            // I am welcoming the user, asking for their name and asking which level they want to play then taking them to their desired level.
            String userName, level;
            Console.Write("\tWelcome To My Te Reo Māori Quiz!\n\t\tI Hope You Enjoy\n\nPlease enter your name to begin: ");
            userName = Console.ReadLine();
            while (string.IsNullOrEmpty(userName))
            {
                Console.Write("Please enter a name with at least 1 character: ");
                userName = Console.ReadLine();
            }
            Console.Write("\nHello " + userName + ", this is a Te Reo Māori quiz with 3 levels (Easy, Normal, Hard) and 5 questions on each level.\n\tEasy level (Press E)\tNormal level (Press N)\t  Hard level (Press H)\n\nEnter Your choice here: ");
            level = Console.ReadLine().ToLower();
            while (string.IsNullOrEmpty(level))
            {
                Console.Write("Please enter a valid choice: ");
                level = Console.ReadLine().ToLower();
            }
            do
            {
                if (level.Equals("e") || level.Equals("n") || level.Equals("h"))
                {
                    Console.Clear();
                    if (level.Equals("e"))
                    {
                        Easy(userName);
                    }
                    else if (level.Equals("n"))
                    {
                        Normal(userName);
                    }
                    else if (level.Equals("h")) 
                    {
                        Hard(userName);
                    }
                } 
                else
                {
                    Console.Write("Please enter a valid choice: ");
                    level = Console.ReadLine();
                }
            } while (true);

        }// End of quiz method.
        static void Easy(string userName)
        {
            int score = 0;
            Console.WriteLine("Welcome To The Easy Level " + userName + ",\nHope You Have Fun!\n");
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

            string[] correctAnswerIndex = { "b", "a", "a", "b", "a" };

            string userAnswerIndex;

            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine(questions[i]);

                for (int j = 0; j < answers[i].Length; j++)
                {
                    Console.WriteLine($"{j + 1}. {answers[i][j]}");
                }

                    Console.Write("\nEnter your answer (A-D): ");
                    userAnswerIndex = Console.ReadLine().ToLower();

                    if (userAnswerIndex.Equals(correctAnswerIndex[i]))
                    {
                        Console.WriteLine("\nCorrect!\n");
                        score++;
                    }
               
                    else
                    {
                        Console.WriteLine("\nIncorrect. The correct answer is " + correctAnswerIndex[i] + ".\n");
                    }
                
                Console.WriteLine("Your score is: " + score + "\nPress any key to continue to the next question.");
                Console.ReadKey();
                Console.Clear();
            }
                Console.WriteLine("\n\tCongratulations! You have completed the Easy level and scored " + score + " out of 5 right.\n\n\tIf you want to start the quiz all over again press 'R'\n\n\t\t\t\tIf you want to play the:\n\n\t Easy level press 'E'\t Normal level press 'N'\t Hard level press 'H'\n\n\tIf you want to exit the quiz press 'X'.");
                String endOfQuiz = Console.ReadLine().ToLower();
                do
                {
                    if (endOfQuiz.Equals("e") || endOfQuiz.Equals("n") || endOfQuiz.Equals("h") || endOfQuiz.Equals("r") || endOfQuiz.Equals("x"))
                    {
                        if (endOfQuiz.Equals("e"))
                        {
                            Console.Clear();
                            Easy(userName);
                            Environment.Exit(0);
                        }
                        else if (endOfQuiz.Equals("n"))
                        {
                            Console.Clear();
                            Normal(userName);
                            Environment.Exit(0);
                        }
                        else if (endOfQuiz.Equals("h"))
                        {
                            Console.Clear();
                            Hard(userName);
                            Environment.Exit(0);
                        }
                        else if (endOfQuiz.Equals("r"))
                        {
                            Console.Clear();
                            quiz();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("\t" + userName + ", Thank You for playing the Quiz\n\tHope You Enjoyed Your time!");
                            Environment.Exit(0);
                        }
                    }
                    else
                    {
                        Console.Write("Please enter a valid choice: ");
                        endOfQuiz = Console.ReadLine();
                    }
                } while (true);
            
            /*In this code, we first define a question and an array of possible answers. We also specify the
            index of the correct answer (in this case, 1, since the correct answer is "Kia Ora").

            Next, we display the question and the possible answers using a for loop to iterate over the
            answers array. We then prompt the user to enter their answer and read their input from the
            console.

            After that, we check whether the user's answer index matches the index of the correct answer,
            and display a message indicating whether the user was correct or not and then show their score. we use the 
            Console.ReadKey() method to wait for the user to press a key before continuing to the next question.
            
            Finally, after the user has finished the set of 5 questions I display their score out of 5 and prompt 
            them to either restart the quiz from the beginning, play the easy level, play the normal level, play the 
            hard level or to exit the quiz.*/

        }// End of Easy method.
        static void Normal(string userName)
        {
            int score = 0;
            Console.WriteLine("Welcome To The Normal Level " + userName + ",\nHope You Have Fun!\n");
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

                Console.WriteLine("Your score is: " + score + "\nPress any key to continue to the next question.");
                Console.ReadKey();
                Console.Clear();
            }

            Console.WriteLine("\n\tCongratulations! You have completed the Normal level and scored " + score + " out of 5 right.\n\n\tIf you want to start the quiz all over again press 'R'\n\n\t\t\t\tIf you want to play the:\n\n\t Easy level press 'E'\t Normal level press 'N'\t Hard level press 'H'\n\n\tIf you want to exit the quiz press 'X'.");
            String endOfQuiz = Console.ReadLine().ToLower();
            do
            {
                if (endOfQuiz.Equals("e") || endOfQuiz.Equals("n") || endOfQuiz.Equals("h") || endOfQuiz.Equals("r") ||endOfQuiz.Equals("x"))
                {
                    if (endOfQuiz.Equals("e"))
                    {
                        Console.Clear();
                        Easy(userName);
                        Environment.Exit(0);
                    }
                    else if (endOfQuiz.Equals("n"))
                    {
                        Console.Clear();
                        Normal(userName);
                        Environment.Exit(0);
                    }
                    else if (endOfQuiz.Equals("h"))
                    {
                        Console.Clear();
                        Hard(userName);
                        Environment.Exit(0);
                    }
                    else if (endOfQuiz.Equals("r"))
                    {
                        Console.Clear();
                        quiz();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\t" + userName + ", Thank You for playing the Quiz\n\tHope You Enjoyed Your time!");
                        Environment.Exit(0);
                    }
                }
                else
                {
                    Console.Write("Please enter a valid choice: ");
                    endOfQuiz = Console.ReadLine();
                }
            } while (true);
        }// End of Normal method.
        static void Hard(string userName)
        {
            int score = 0;
            Console.WriteLine("Welcome To The Hard Level " + userName + ",\nHope You Have Fun!\n");
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

                Console.WriteLine("Your score is: " + score + "\nPress any key to continue to the next question.");
                Console.ReadKey();
                Console.Clear();
            }

            Console.WriteLine("\n\tCongratulations! You have completed the Hard level and scored " + score + " out of 5 right.\n\n\tIf you want to start the quiz all over again press 'R'\n\n\t\t\t\tIf you want to play the:\n\n\t Easy level press 'E'\t Normal level press 'N'\t Hard level press 'H'\n\n\t\tIf you want to exit the quiz press 'X'.");
            String endOfQuiz = Console.ReadLine().ToLower();
            do
            {
                if (endOfQuiz.Equals("e") || endOfQuiz.Equals("n") || endOfQuiz.Equals("h") || endOfQuiz.Equals("r") || endOfQuiz.Equals("x"))
                {
                    if (endOfQuiz.Equals("e"))
                    {
                        Console.Clear();
                        Easy(userName);
                        Environment.Exit(0);
                    }
                    else if (endOfQuiz.Equals("n"))
                    {
                        Console.Clear();
                        Normal(userName);
                        Environment.Exit(0);
                    }
                    else if (endOfQuiz.Equals("h"))
                    {
                        Console.Clear();
                        Hard(userName);
                        Environment.Exit(0);
                    }
                    else if (endOfQuiz.Equals("r"))
                    {
                        Console.Clear();
                        quiz();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\t" + userName + ", Thank You for playing the Quiz\n\tHope You Enjoyed Your time!");
                        Environment.Exit(0);
                    }
                }
                else
                {
                    Console.Write("Please enter a valid choice: ");
                    endOfQuiz = Console.ReadLine();
                }
            } while (true);
        }// End of Hard method.
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
    }
}