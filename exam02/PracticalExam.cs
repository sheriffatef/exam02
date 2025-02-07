using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class PracticalExam : Exam
    {
        private Question[] questions;

        public PracticalExam(int time, int number_of_Questions, Subject subject) : base(time, number_of_Questions, subject)
        {
            questions = new Question[number_of_Questions];

        }
        public override Question[] Questions => questions;

        public override void newquistion()
        {
            int x;
            bool flag;
            for (int i = 0; i < number_of_Questions; i++)
            {
                Console.WriteLine($"Question No.{i + 1}");
                questions[i] = new MCQ();
                do
                {
                    Console.WriteLine($"q number =>{i + 1}");
                    questions[i].Body = Console.ReadLine();
                } while (questions[i].Body is null);

                do
                {
                    Console.Write($"q number =>{i + 1} Mark?");
                    flag = int.TryParse(Console.ReadLine(), out x);
                } while (!flag || x <= 0);
                questions[i].Mark = x;


                Console.WriteLine("Enter the answers for this MCQ question:");

                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"Enter answer #{j + 1}: ");
                    string answerText = Console.ReadLine();
                    questions[i].answerlist[j] = new Answers(j + 1, answerText);
                }

                int correctAnswerIndex;
                do
                {
                    Console.Write("Enter the number (1to4) of the correct answer ");
                } while (!int.TryParse(Console.ReadLine(), out correctAnswerIndex) || correctAnswerIndex < 1 || correctAnswerIndex > 4);

                questions[i].rightanswer = questions[i].answerlist[correctAnswerIndex - 1];


            }



        }



        public override void Showexam()
        {



            Console.WriteLine("right answers");

            foreach (var question in questions)
            {
                Console.WriteLine($"answers are  {question.rightanswer.AnswerText}\n");
            }
        }
    }
}
