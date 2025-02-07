using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Answers
    {
        public int id;
        public string answerText;
        public Answers()
        {

        }
        public Answers(int id, string answerText)
        {
            this.id = id;
            this.answerText = answerText;
        }

        public int Id
        {
            set
            {
                if (value > 0)
                {
                    id = value;
                }
                else
                {
                    bool flag = false;
                    do
                    {
                        Console.Write("what is answer id?");
                        flag = int.TryParse(Console.ReadLine(), out id);
                    } while (flag || id <= 0);
                }
            }
            get
            {
                return id;
            }
        }
        public string AnswerText
        {
            set
            {
                if (value is not null)
                {
                    answerText = value;
                }
                else
                {
                    do
                    {
                        Console.Write("what is answer text ? ");
                        answerText = Console.ReadLine();
                    } while (answerText is null);
                }
            }
            get
            {
                return answerText;
            }
        }



        public override string ToString()
        {
            return $"{id} , {answerText}";

        }
    }
}
