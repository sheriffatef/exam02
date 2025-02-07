using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Question
    {
        protected string header;
        protected string body;
        protected float mark;
        public Answers[] answerlist;
        public Answers rightanswer { get; set; }
        public string StudentAnswer { get; set; }


        public string Body
        {
            set
            {
                if (value is not null)
                {
                    body = value;
                }
                else
                {
                    do
                    {
                        Console.WriteLine("what is quistion body ?");
                        Body = Console.ReadLine();
                    }
                    while (body is null);
                }
            }
            get { return body; }
        }

        public float Mark
        {
            set
            {
                if (value > 0)
                {
                    mark = value;
                }
                else
                {
                    bool flag;
                    do
                    {
                        Console.WriteLine("what is the mark for this quistion");
                        flag = float.TryParse(Console.ReadLine(), out mark);
                    }
                    while (!flag || mark <= 0);

                }
            }
            get { return mark; }
        }
        public string Header
        {
            get { return header; }

        }
        public abstract Answers[] Displayanswers();
        public abstract void Displayquistion();


    }
}
