using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace RhianH_TriviaGame
{
    internal class Program
    {
        static List<string> question = new List<string>();
        static List<string[]> answers = new List<string[]>();
        int[] questionNumbers = new int[10];

        static string name;
        static int answersRight;
        static int answersWrong;

        static bool isPlaying = true;


        static void Main(string[] args)
        {
            

        }

        static void Questions()
        {
            question.Add("Where do Schnauzer's originate from?");
            Console.WriteLine(question[0]);

            char charInput = Console.ReadKey(true).KeyChar;

            if (charInput == 1)
            {
                
            }
            else if (charInput == 2)
            {

            }
            else if (charInput == 3)
            {
                 
            }
            else if (charInput == 4)
            {

            }
            else
            {

            }

        }

        static void Answers()
        {
            
        }



        static void HUD()
        {
            Console.WriteLine("Current Player: " + name);
           
        }

        static void StartGame()
        {
            isPlaying = true;
        }









    }
}
