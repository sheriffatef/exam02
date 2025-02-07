using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Exam
    {

        public int time;
        public int number_of_Questions;
        public Subject Subject;
        public abstract Question[] Questions { get; }

        protected Exam(int time, int number_of_Questions, Subject subject)
        {
            this.time = time;
            this.number_of_Questions = number_of_Questions;
            Subject = subject;
        }

        public int Time
        {
            set
            {
                if (value > 0)
                {
                    time = value;
                }
                else
                {
                    bool flag;
                    do
                    {
                        Console.WriteLine("what is exam time");
                        flag = int.TryParse(Console.ReadLine(), out time);

                    }
                    while (!flag || time <= 0);
                }
            }
            get { return time; }
        }
        public int Number_of_Questions
        {
            set
            {
                if (value > 0)
                {
                    number_of_Questions = value;
                }
                else
                {
                    bool flag = false;
                    do
                    {
                        Console.WriteLine("what is exam time");
                        flag = int.TryParse(Console.ReadLine(), out number_of_Questions);

                    }
                    while (!flag || number_of_Questions <= 0);
                }
            }
            get
            {
                return number_of_Questions;
            }
        }


        public abstract void Showexam();
        public abstract void newquistion();

    }
}
