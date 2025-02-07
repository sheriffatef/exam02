namespace ConsoleApp1
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam Exam { get; set; }

        public Subject(int subjectId, string subjectName)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
        }

        public void CreateExam()
        {
            bool flag;
            int time, numberOfQuestions, examType;

            do
            {
                Console.Write("Enter exam time ");
                flag = int.TryParse(Console.ReadLine(), out time);
            } while (!flag || time <= 0);

            do
            {
                Console.Write("Enter number of questions ");
                flag = int.TryParse(Console.ReadLine(), out numberOfQuestions);
            } while (!flag || numberOfQuestions <= 0);

            do
            {
                Console.Write("Enter exam type (1 for Final, 2 for Practical): ");
                flag = int.TryParse(Console.ReadLine(), out examType);
            } while (!flag || (examType != 1 && examType != 2));

            Console.Clear();

            if (examType == 1)
            {
                Exam = new FinalExam(time, numberOfQuestions, this);

            }
            else
            {
                Exam = new PracticalExam(time, numberOfQuestions, this);


            }

            Exam.newquistion();

        }

    }
}
