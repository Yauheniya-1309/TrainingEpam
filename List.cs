using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Exception.MyExeption;

namespace MYList
{
    class MList<T>
    {
        const int _LENGTH=10;
        int _kol;
        Cell<T> _head;

        public MList()
        {
           _head = null;
        }
        public MList(T new_val)
        {
            Cell<T> new_cell = new Cell<T>(new_val);
            new_cell._Next = null;
            _head = new_cell;
            _kol = 1;
        }

        public void Push(T new_val)
        {
            if(_kol>_LENGTH)
            {
                throw  new MyExeption("The List is full");
            }
            Cell<T> new_cell = new Cell<T>(new_val);
            new_cell._Next = _head;
            _head = new_cell;
            _kol++;
        }

        public void Push(T new_val, T pos)
        {
            if (_kol > _LENGTH)
            {
                throw new MyExeption("The List is full");
            }
            bool found = false;
            Cell<T> temp = _head;
            while(temp._Next!=null)
            { if (Object.Equals(temp._Value, pos)) { found = true; break; }
                else temp = temp._Next;
            }
            if (found == true)
            {
                Cell<T> new_cell = new Cell<T>(new_val);
                new_cell._Next = temp._Next;
                temp._Next = new_cell;
                _kol++;
            }
            else
            {
                throw new MyExeption("The value is not exist");
            }
        }

       
        public void Pop()
        {
            if(_kol<1)
            {
                throw new MyExeption("The list is empty");
            }
            _head = _head._Next;
            _kol--;
        }

        public void Pop(T del_val)
        {
            if (_kol < 1)
            {
                throw new MyExeption("The list is empty");
            }
            bool found = false; 
            Cell<T> temp = _head;
            while (temp._Next != null)
            {
                if (Object.Equals(temp._Next._Value, del_val)) { found = true; break; }
                else temp = temp._Next;
            }
            if (found == true)
            {
                temp._Next = temp._Next._Next;
                _kol--;
            }
            else
                
            {
                throw new MyExeption("The value is not exist");
            }
        }

        public void Show()
        {
            Cell<T> temp = _head;
            while (temp._Next != null)
            {
                Console.Write(temp._Value+"  ");
                temp = temp._Next;
            }
            Console.Write(temp._Value + "  ");
            Console.WriteLine();
        }
        }
}
