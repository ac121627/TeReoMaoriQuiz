using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace TeReoMaoriQuiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*QUESTIONS FOR EASY LEVEL: 
            Q1. what is the word for the colour red in te reo maori?
            a. whero b. kowhai c. kikorangi d. pango

            Q2. what is the word for canoe in te reo maori?
            a. kia ora b. whanau c. waka d. ata marie

            Q3. what is the word for family in te reo maori?
            a. ma b. pango c. whanau  d. ua

            Q4. what is the word for the colour blue in te reo maori?(ans:kahurangi)
            a. kahurangi b. kakariki c. mawhero d. tekau

            Q5: what is the word for hello in te reo maori?
            a. parauri b. papura c. kia ora d. ahiahi pai

            QUESTIONS FOR NORMAL LEVEL:
            Q1. what is the word for land in maori?
            a. whenua b. whare c. rangatira d. tangata

            Q2: what is "tnagata" in english? (ans: person)
            a. man b. woman c. people d. children

            Q3: what is the word for "hear" in te reo maori?(ans: rongo)
            a. parauri b. hapa c. whakarongo mai d. rongo 

            Q4: what is 'you' in maori?(ans: koe)
            a. koe b. ahau c. matou d. ratou

            Q5: what is the word for group in maori?(ans:roopu)
            a. koropiko b. ngako c. roopu d. mea atu

            QUESTIONS FOR HARD LEVEL:

            Q1. what is the word for lieutenant in te reo maori?(ans:rutene)
            a. ringa b. hauhautanga c. rutene d. whanui

            Q2. what is 'waewae' in english?(ans:leg)
            a. stomach b. arm c. leg d. face

            Q3. what is the word for read in te reo maori? (ans:panui)
            a. puku b. whanau c. panui d. pene

            Q4. what is 'tuhi' in english? (ans:write)
            a. pencil b. write c. stomach d. book

            Q5. what is the word for boat in te reo maori?(ans:poti)
            a. matimati b. waka c. poti d. whangi*/

            quiz();
        }// End of Main method.
        static void quiz()
        {
            // I am welcoming the user and asking for their name.
            String name, level;
            Console.Write("\tWelcome To My Te Reo Maori Quiz!\n\t\tI Hope You Enjoy\n\nPlease enter your name to begin: ");
            name = Console.ReadLine();
            while (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Please enter a valid name:");
                name = Console.ReadLine();
            }
            Console.Write("\nHello " + name + ", this is a te reo maori quiz with 3 levels (Easy, Normal, Hard) and 5 questions on each level.\nEasy level: E\nNormal level: N\nHard level: H\nEnter Your choice here: ");
            level = Console.ReadLine().ToLower();
            Console.Clear();
            if (level == "e")
            {
                Easy();
                Console.Clear();
            }
            if (level == "n")
            {
                Normal();
            }
            if (level == "h")
            {
                Hard();
            }
        }
        static void Easy()
        {
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

                Console.Write("Enter your answer (1-4): ");
                userAnswerIndex = int.Parse(Console.ReadLine()) - 1;

                if (userAnswerIndex == correctAnswerIndex[i])
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine("Incorrect. The correct answer is " + answers[i][correctAnswerIndex[i]] + ".");
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
        static void Normal()
        {
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

                Console.Write("Enter your answer (1-4): ");
                userAnswerIndex = int.Parse(Console.ReadLine()) - 1;

                if (userAnswerIndex == correctAnswerIndex[i])
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine("Incorrect. The correct answer is " + answers[i][correctAnswerIndex[i]] + ".");
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
        static void Hard()
        {
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

                Console.Write("Enter your answer (1-4): ");
                userAnswerIndex = int.Parse(Console.ReadLine()) - 1;

                if (userAnswerIndex == correctAnswerIndex[i])
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine("Incorrect. The correct answer is " + answers[i][correctAnswerIndex[i]] + ".");
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
        static bool validAns(string check)
        {
            do
            {
                if (check.Contains("1") || check.Contains("2") || check.Contains("3") || check.Contains("4"))
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
                if (check.Contains("e") || check.Contains("n") || check.Contains("h"))
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