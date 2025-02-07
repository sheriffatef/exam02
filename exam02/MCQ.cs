using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MCQ : Question
    {
        public MCQ()
        {
            header = "mcq";
            answerlist = new Answers[4];
            rightanswer = new Answers();
        }
        public override Answers[] Displayanswers()
        {
            return answerlist;
        }
        public override void Displayquistion()
        {
            Console.WriteLine($"head is =>{Header} ,body is => {body} , mark is =>{mark}");
            foreach (var answer in answerlist)
            {
                Console.WriteLine(answer.AnswerText);
            }
        }
        public void setanswers()
        {
            for (int i = 0; i < 4; i++)
            {
                answerlist[i] = new Answers();
                answerlist[i].id = i + 1;
                do
                {
                    Console.Write($"answer for {i + 1} is ? ");
                    answerlist[i].AnswerText = Console.ReadLine();
                } while (answerlist[i].AnswerText is null);
            }
        }
    }
}
