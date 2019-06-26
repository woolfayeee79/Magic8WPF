using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Magic8Ball_Logic;

namespace Magic8Ball_Console 
{
    class Program
    {
        static void Main(string[] args)
        {
            string anslet = "", questions = "";
           

            //make alternative console app.
            Console.WriteLine("Welcome to my Magic 8 Ball App!");
            Magic8Ball ball = new Magic8Ball();
            //make a new list of alternative answers
            List<string> _altAnswers = new List<string>();
            //alternative answers to the console list
            _altAnswers.Add("OK.");
            _altAnswers.Add("No.");
            _altAnswers.Add("Yeah!.");
            _altAnswers.Add("You are right!");
            _altAnswers.Add("You are wrong.");
            _altAnswers.Add("That is possible.");
            _altAnswers.Add("Nope!");
            _altAnswers.Add("It is perfect.");
            _altAnswers.Add("Sorry but I would sayno.");
            _altAnswers.Add("Try again.");
            _altAnswers.Add("Not sure about that.");
            _altAnswers.Add("Seems right.");
            _altAnswers.Add("Seems impossible.");
            _altAnswers.Add("Maybe.");
            _altAnswers.Add("Not possible.");
            _altAnswers.Add("Okay.");
            _altAnswers.Add("Good.");
            _altAnswers.Add("Not bad.");
            _altAnswers.Add("I would not say no.");
            _altAnswers.Add("Yes.");

            // do while loop that asks what task to complete 
            do
            {
                Console.WriteLine("What whould you like to do?");
                Console.WriteLine("(S)hake the Ball\n(A)sk a Question\n(G)et the answer\n(E)xit the game\nEnter S,A,G OR E:");
                anslet = Console.ReadLine();
                anslet = anslet.ToUpper();

                // if the user enter char A print and read the string and shake
                if (anslet == "S")
                {
                    Console.WriteLine("Searching the mystic realms (RAM) for an answer.");
                    ball.Shake();
                }
                //if the user calls char A, call the ask a question and read ans from random ans
                else if (anslet == "A")
                {
                    ConsoleColor oldColor = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("What is your question?");
                    Console.ForegroundColor = ConsoleColor.White;
                    questions = Console.ReadLine();
                }
                //if the user enters g call the g method from main and print the results 
                else if (anslet == "G")
                {
                    ConsoleColor oldColor = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("The answer to your question \n" + questions + " is " + ball.GetAnswer() + ".");
                    Console.ForegroundColor = ConsoleColor.White;
                }

            } while (anslet != "E");

            Console.WriteLine("You are exiting the program");
                

        }
    }
}
