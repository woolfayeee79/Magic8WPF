using System;
using System.Collections.Generic;

namespace Magic8Ball_Logic
{

    public class Magic8Ball
    {

        List<string> _answers;
        private int _currentAnswerIndex;
        //set up a random number
        private Random _randomObject;

        public Magic8Ball()
        {
            _randomObject = new Random();
            _answers = new List<string>();
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

        }

        public Magic8Ball(List<string> answers)
        {
            _answers = answers;
        }

        public void Shake()
        {
            //iterate through the random ans in textbox
            Random rdum = new Random();
            for (int i = 0; i < _answers.Count; i++)
            {
               _currentAnswerIndex = rdum.Next(_answers.Count);
            }
           
        }

        public string GetAnswer()
        {
            return _answers[_currentAnswerIndex];
        }

        public int AnswerCount
        {
            get { return _answers.Count; }
        }

        public override string ToString()
        {
            string ansr = String.Join("/n", _answers.ToArray());
            return ansr;
        }
    }
}
