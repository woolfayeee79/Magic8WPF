using System;
using System.Collections.Generic;
using Magic8Ball_Logic; 

namespace Magic8Ball_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            string anslet = "", questions = "";
            //have a greeting 
            Console.WriteLine("Welcome to my Magic 8 Ball App!");
            //new magic 8 ball method and import
            Magic8Ball ball = new Magic8Ball();
            List<string> _answers = new List<string>();
            //list the answers from the magic 8 ball orginal list 
            _answers.Add("It is certain.");
            _answers.Add("It is decidedly so.");
            _answers.Add("Without a doubt.");
            _answers.Add("Yes - definitely.");
            _answers.Add("You may rely on it.");
            _answers.Add("As I see it, yes.");
            _answers.Add("Most likely.");
            _answers.Add("Outlook good.");
            _answers.Add("Yes.");
            _answers.Add("Signs point to yes.");
            _answers.Add("Reply hazy, try again.");
            _answers.Add("Ask again later.");
            _answers.Add("Better not tell you now.");
            _answers.Add("Cannot predict now.");
            _answers.Add("Concentrate and ask again.");
            _answers.Add("Don't count on it.");
            _answers.Add("My reply is no.");
            _answers.Add("My sources say no.");
            _answers.Add("Outlook not so good.");
            _answers.Add("Very doubtful.");

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
