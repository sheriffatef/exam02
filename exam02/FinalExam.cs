using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class FinalExam : Exam
    {
        private Question[] questions;



        public FinalExam(int time, int number_of_Questions, Subject subject) : base(time, number_of_Questions, subject)
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
                Console.WriteLine($"quistion =>{i + 1}");
                do
                {
                    Console.Write("enter 1 for mcq and 2 for true and false ");
                    flag = int.TryParse(Console.ReadLine(), out x);
                } while (!flag || (x != 1 && x != 2));
                if (x == 1)
                {
                    questions[i] = new MCQ();

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


                    Console.WriteLine("Enter the answers for this MCQ question");

                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write($"Enter answer {j + 1}: ");
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

                else if (x == 2)
                {
                    questions[i] = new True_or_False();

                    do
                    {
                        Console.WriteLine($"Enter question number{i + 1}");
                        questions[i].Body = Console.ReadLine();
                    } while (questions[i].Body is null);

                    do
                    {
                        Console.Write($"q number =>{i + 1} Mark?");
                        flag = int.TryParse(Console.ReadLine(), out x);
                    } while (!flag || x <= 0);
                    questions[i].Mark = x;

                    string rightans;
                    do
                    {
                        Console.Write("Enter the correct answer true or false ");
                        rightans = Console.ReadLine().ToLower();
                    } while (rightans != "true" && rightans != "false");

                    questions[i].rightanswer = new Answers(1, rightans);

                }

            }


        }


        public override void Showexam()
        {

            int totalMarks = 0;
            int earnedMarks = 0;

            foreach (var q in Subject.Exam.Questions)
            {
                q.Displayquistion();
                Console.WriteLine("Your Answer: ");
                string studentAnswer = Console.ReadLine().ToLower();


                totalMarks += (int)q.Mark;

                if (studentAnswer == q.rightanswer.AnswerText.ToLower())
                {
                    Console.WriteLine("Correct!");
                    earnedMarks += (int)q.Mark;
                }
                else
                {
                    Console.WriteLine($"The correct answer is: {q.rightanswer.AnswerText}");
                }
            }
            Console.WriteLine($"You earned {earnedMarks} out of {totalMarks} marks.");
        }


    }
}

