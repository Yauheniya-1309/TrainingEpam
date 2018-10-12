using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task6_1
{
    class Man
    {
        string _name;
        int _age;
        string _gender;

        public string _Name
        {
            get {return _name; }
            set { _name = value; }
        }
        public int _Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public string _Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public Man() 
        {
            _name = null;
            _age = 0;
            _gender = null;
        }
        public Man(string my_name, int my_age, string my_gender)
        {
            _name = my_name;
            _age = my_age;
            _gender = my_gender;
        }
        public void GoToCollege()
        {
            Console.WriteLine("Go on foot");
        }
    }
}
