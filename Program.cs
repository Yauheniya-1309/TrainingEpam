using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MYList;

namespace MYlist
{
    class Program
    {
        static void Main(string[] args)
        {
            MList<int> int_list = new MList<int>(123);
            int_list.Show();
            Console.WriteLine("Список типа int ");
            try
            {
                for (int i = 0; i < 8; i++)
                {
                    int_list.Push(i);
                }
            }
            catch  (MyExeption ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
                 
            }
            int_list.Show();
            Console.WriteLine("Добавление после несуществующего элемента ");
            try { int_list.Push(55, 13); }
            catch  (MyExeption ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
            Console.WriteLine("Добавление после существующего элемента ");
            try { int_list.Push(55, 1); }
            catch (MyExeption ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
            int_list.Show();

            Console.WriteLine("Удаление из конца ");
            try
            {
                int_list.Pop();
            }
            catch (MyExeption ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
            int_list.Show();
            Console.WriteLine("Удаление по значению 55");
            try
            {
                int_list.Pop(55);
            }
            catch (MyExeption ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
            int_list.Show();


            Console.WriteLine("Удаление несуществующего элемента ");
            try
            {
                int_list.Pop(33);
            }
            catch (MyExeption ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }


            Console.WriteLine("Список типа char ");
            MList<char> str_list = new MList<char>('A');
            char a='R'; 
            for (int i = 0; i < 9; i++)
            {
                str_list.Push(a++);
            }
            str_list.Show();

            try { str_list.Push('I', 'F'); }
            catch (MyExeption ex)
            {
                Console.WriteLine("Ошибка char: " + ex.Message);
            }
            str_list.Show();

            str_list.Pop();
            str_list.Show();

            str_list.Pop('R');
            str_list.Show();
            Console.ReadKey();

        }
    }
}
