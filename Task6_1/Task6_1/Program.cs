using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher maria=new Teacher("Maria Ivanovna", 45, "female", 40);
            Student[] group = new Student[3];
          
            group[0] = new Student("Ivan Ivanov", 20, "male", 50);
            group[1] = new Student("Petr Petrov", 19, "male", 80);
            group[2] = new Student("Sveta Sidorova", 21, "female", 10);
           
            maria.GoToCollege();
            foreach (Man person in group)
                person.GoToCollege();
           
            while (group[0]._Exam != true) maria.TakeExam(group[0]);
            while (group[1]._Exam != true) maria.TakeExam(group[1]);
            while (group[2]._Exam != true) maria.TakeExam(group[2]);
            Console.ReadKey();

        }
    }
}
