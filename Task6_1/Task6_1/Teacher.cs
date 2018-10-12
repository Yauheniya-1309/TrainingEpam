using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task6_1
{
    class Teacher:Man
    {
        int _pasion;

        public int _Pasion
        {
            get { return _pasion; }
            set { _pasion = value; }
        }
       
        public Teacher()
        {
            _pasion = 0;
        }
        public Teacher(string my_name, int my_age, string my_gender, int my_pasion)
            : base(my_name, my_age, my_gender)
        {
            _pasion = my_pasion;
        }

        new public void GoToCollege()
        { 
            Console.WriteLine("Teacher goes by bus");
        }

        public void DrinkCoffe()
        {
            _pasion += 20;
        }

        public void TakeExam(Student stud)
        {
            Console.WriteLine(stud._Name + " tries to pass the exam");
            if (stud._Knowledge >= 70)
            { 
                stud._Exam = true;
                Console.WriteLine("Congratulation! " + stud._Name + " You pass!");
                Console.WriteLine();
            }
            else if (stud._Knowledge <= 30)
            {
                stud._Exam = false;  
                Console.WriteLine("Go home and read!!!!");
                stud.VisitLesson();
            }
            else if (_pasion <= 20)
            {
                Console.WriteLine("You can think a little bit more while I drink coffe...");
                DrinkCoffe();
            }
            else
            {
                int question=0;
                while (question<=3)
                {
                    AskQuestion();
                    question+=stud.AnswerQuestion();
                    _pasion -= 5;
                }
                stud._Exam = true;
                Console.WriteLine("Congratulation! " +stud._Name+ ", you pass!");
                Console.WriteLine();
            }
           
        }
        public void AskQuestion()
        {
            Console.WriteLine("One more question");
        }
    }
}
