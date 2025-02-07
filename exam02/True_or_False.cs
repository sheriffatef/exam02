namespace ConsoleApp1
{

    internal class True_or_False : Question
    {
        public True_or_False()
        {
            header = "true or false";

            answerlist = new Answers[2];
            {
                answerlist[0] = new Answers { Id = 1, AnswerText = "True" };
                answerlist[1] = new Answers { Id = 2, AnswerText = "False" };
            }
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
                Console.WriteLine(answer);
            }
        }
    }
}
