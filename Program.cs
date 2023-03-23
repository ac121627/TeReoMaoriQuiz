﻿namespace TeReoMaoriQuiz
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
            Console.Write("\nHello " + name + ", this is a te reo maori quiz with 3 levels (Easy, Normal, Hard) and 5 questions on each level.\nPlease press they key 'E' if you want to play the Easy level \npress 'N' if you want to play the Normal level \npress 'H' if you want to play the Hard level: ");
            level = Console.ReadLine().ToLower();
            while (string.IsNullOrEmpty(level)) valid(level);
            {
                Console.Write("Please eneter a valid option:");
                level = Console.ReadLine();
            }
            valid(level);
            if (level=="e")
            {
                Easy();
                Console.Clear();
            }
            if (level=="n") 
            {
                Normal();
            }
            if (level=="h") 
            {
                Hard();
            }
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

            Console.Write("Enter your answer (1-4): ");
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

            string question1 = "What is the capital of France?";
            string[] answers1 = { "Berlin", "Paris", "Madrid", "London" };
            int correctAnswerIndex1 = 1;
            int userAnswerIndex1;

            Console.WriteLine(question);

            for (int i = 0; i < answers.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {answers[i]}");
            }

            Console.Write("Enter your answer (1-4): ");
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
            /*Dictionary:

            Dictionary<string, int> ages = new Dictionary<string, int>();
            ages.Add("Alice", 25);
            ages.Add("Bob", 30);
            ages.Add("Charlie", 35);

            Dictionary<string, string> capitals = new Dictionary<string, string>()
            {
                {"USA", "Washington, D.C."},
                {"Japan", "Tokyo"},
                {"France", "Paris"}
            };

            Console.WriteLine("Ages:");
            foreach (KeyValuePair<string, int> pair in ages)
            {
                Console.WriteLine(pair.Key + ": " + pair.Value);
            }

            Console.WriteLine("\nCapitals:");
            foreach (KeyValuePair<string, string> pair in capitals)
            {
                Console.WriteLine(pair.Key + ": " + pair.Value);
            }

            Console.ReadKey();*/

            /*Listing:

            List<string> fruits = new List<string>() { "apple", "banana", "cherry" };
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };
            List<double> prices = new List<double>();

            prices.Add(1.99);
            prices.Add(2.99);
            prices.Add(3.99);

            Console.WriteLine("Fruits:");
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            Console.WriteLine("\nNumbers:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("\nPrices:");
            foreach (double price in prices)
            {
                Console.WriteLine(price);
            }

            Console.ReadKey();*/
        }
        static void Normal()
        {
            Console.WriteLine("");
        }
        static void Hard()
        {
            Console.WriteLine("");
        }
        static bool validate(string check)
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
        static bool valid(string check)
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
        static void userDefinedFunctions()
        {
            int a = 10, b = 5;
            int sum = Add(a, b);
            Console.WriteLine("{0} + {1} = {2}", a, b, sum);

            double c = 2.5, d = 1.5;
            double product = Multiply(c, d);
            Console.WriteLine("{0} * {1} = {2}", c, d, product);

            Console.ReadKey();
        }

        static int Add(int x, int y)
        {
            return x + y;
        }

        static double Multiply(double x, double y)
        {
            return x * y;
        }
    }   
}