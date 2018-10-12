using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task6_1
{
    class Student:Man
    {
        int _knowledge;
        bool _exam;

        public int _Knowledge
        {
            get { return _knowledge; }
            set { _knowledge = value; }
        }
        public bool _Exam
        {
            get { return _exam; }
            set { _exam = value; }
        }
        public Student()
        {
            _knowledge = 0;
            _exam = false;
        }
        public Student(string my_name, int my_age, string my_gender, int my_knowledge, bool exam = false)
            : base(my_name, my_age, my_gender)
        {
            _knowledge = my_knowledge;
        }

        new public void GoToCollege()
        { 
            Console.WriteLine("Student goes by car");
        }

        public void VisitLesson()
        { 
            Random rnd=new Random();
            _knowledge += rnd.Next(1, 10);
        }
        public int AnswerQuestion()
        {
            Random rnd = new Random();
            int i = rnd.Next(1, 3);
            if (i % 2 == 0) {  return 1; }
            else return 0;
        }
    }
}
