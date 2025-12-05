using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace RhianH_TriviaGame
{
    internal class Program
    {
        static List<string> questions = new List<string>();
        static List<string> correctAnswers = new List<string>();
        static char[] possibleAnswers = { '1', '2', '3', '4' };

        static string[,] answers =
{ 
        { "Spider extension", "Data storing a sequence of words", "Data storing a number", "A thing I pulled off my shirt" },
        { "Allows anyone to make instances of the item being modified", "Posts the item being modified to the internet", "Creates a social media account for the item being modified", "Places the item being modified onto your desktop" },
        { "1956", "1776", "2015", "2000" },
        { "2", "True", "False", "Null/NA" },
        { "int name = 1;", "int = 1;", "int name 1;", "int -=1;" },
        { "OR", "MAYBE", "AND", "IF" },
        { "Searching", "Examine", "Scouring", "Indexing" },
        { "0", "1", "2", "3" },
        { "End", "LoopQuit", "Break", "Stop" },
        { "call Method();", "Dial the number of the method on your phone", "Method();", "Method: Method();" },
};

        static string name;
        static int score;
        static bool isPlaying = true;


        static void Main(string[] args)
        {

            StartGame();
            EnterName();
            Questions();

            while (isPlaying == true)
            {

                score = 0;

                for (int i = 0; i < questions.Count; i++)
                {
                    HUD();
                    Console.WriteLine("Question: " + (i + 1));
                    Console.WriteLine();


                    Console.WriteLine(questions[i]);


                    Console.WriteLine($"1. {answers[i, 0]}");
                    Console.WriteLine($"2. {answers[i, 1]}");
                    Console.WriteLine($"3. {answers[i, 2]}");
                    Console.WriteLine($"4. {answers[i, 3]}");



                    int input = AnswerInput();
                    if (correctAnswers[i] == answers[i, input])
                    {
                        Console.SetCursorPosition(0, 10);
                        score++;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Correct!");
                        Console.ForegroundColor= ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("No");
                        Console.ForegroundColor= ConsoleColor.White;
                    }


                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey(true);
                    Console.Clear();
                }

                ReplayGame();
            }

            
        }

        static void EnterName()
        {
            Console.WriteLine("Please enter your name: ");
            name = Console.ReadLine();


            if (name == "Simon")
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Welcome, Special Guest. Enjoy the quiz!");
                Console.ReadKey();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (name == "Michael")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You're not supposed to be here.");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else if (name == "Roman")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Cheeky Peeky!");
                Console.ReadKey();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        static void Questions()
        {
            questions.Add("What is a string in coding?");
            questions.Add("What does the public modifier do in coding?");
            questions.Add("When was C# released?");
            questions.Add("What is the default value of a boolean?");
            questions.Add("How do you properly declare an int value?");
            questions.Add("What does && do as an operator in coding?");
            questions.Add("What is the term used when finding a specific position in an array or list via a numerical position?");
            questions.Add("What is the index of the first line in a C# array?");
            questions.Add("What function is used to end a loop to end a loop prematurely?");
            questions.Add("How do you properly call a method to be used?");

            correctAnswers.Add("Data storing a sequence of words");
            correctAnswers.Add("Allows anyone to make instances of the item being modified");
            correctAnswers.Add("2000");
            correctAnswers.Add("False");
            correctAnswers.Add("int name = 1;");
            correctAnswers.Add("AND");
            correctAnswers.Add("Indexing");
            correctAnswers.Add("0");
            correctAnswers.Add("Break");
            correctAnswers.Add("Method();");
        }
        static int AnswerInput()
        {
            while (true)
            {
                char input = Console.ReadKey(true).KeyChar;
                if (input == '1')
                {
                    return 0;
                }
                else if (input == '2')
                {
                    return 1;
                }
                else if (input == '3')
                {
                    return 2;
                }
                else if (input == '4')
                {
                    return 3;
                }
                else
                {
                    Console.SetCursorPosition(0, 11);
                    Console.WriteLine("Please enter a valid number.");
                }
            }



        }
        static void ReplayGame()
        {
            bool gameEnd;
            

            gameEnd = true;
            Console.WriteLine();
            Console.WriteLine("Game has ended.");
            Console.WriteLine("Your final score: " + score + "/10");
            Console.WriteLine("Play again or quit by pressing Y/N");



            while (gameEnd == true)
            {
                char replayInput = Console.ReadKey(true).KeyChar;
                if (replayInput == 'y')
                {
                    isPlaying = true;
                    gameEnd = false;
                }
                else if (replayInput == 'n')
                {
                    isPlaying = false;
                    gameEnd = false;
                }
                else
                {
                    Console.SetCursorPosition(0, 11);
                    Console.WriteLine("Please enter a valid response.");
                }
            }
            Console.Clear();

        }
        static void HUD()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("Current Player: " + name);
            Console.WriteLine("Current Score: " + score);
        }
        static void StartGame()
        {
            isPlaying = true;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔══════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                                      ║");
            Console.WriteLine("║     * Click any button to start the game *           ║");
            Console.WriteLine("║                                                      ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════╝");
            Console.ResetColor();
            Console.ReadKey(true);
            Console.Clear();
        }


    }
}
