namespace ConsoleApp1
{
    using System;



    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Subject Name: ");
            string subjectName = Console.ReadLine();

            Subject subject = new Subject(1, subjectName);

            subject.CreateExam();

            Console.WriteLine("\nDo you want to start the exam? (yes/no)");
            string startExam = Console.ReadLine().ToLower();

            if (startExam == "yes")
            {
                Console.Clear();
                foreach (var q in subject.Exam.Questions)
                {
                    q.Displayquistion();
                    Console.WriteLine("Your Answer: ");
                    string studentAnswer = Console.ReadLine().ToLower();

                    if (studentAnswer == q.rightanswer.AnswerText.ToLower())
                    {
                        Console.WriteLine("Correct!");

                    }
                    else
                    {
                        Console.WriteLine($"The correct answer is: {q.rightanswer.AnswerText}");
                    }
                }

                Console.WriteLine(" you end the exam ");
                Console.Clear();
                subject.Exam.Showexam();
            }
            else
            {
                Console.WriteLine("you didnt take the exam");
            }

        }
    }
}
