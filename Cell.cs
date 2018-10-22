using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYList
{
    class Cell<T>
    {
       // static int _number=0;
     
        T _value;
        Cell<T> _next;

        public Cell(T val)
        {
        //   _number++;
            _value = val;
            _Next = null;
        }

        public T _Value
        {
            get { return _value; }
             set { _value = value; }
        }
        public Cell<T> _Next
        {
            get { return _next; }
             set { _next = value; }
        }

        //public int _Nomer
        //{
        //    get { return _nomer; }
        //    set { _nomer = value; }
        //}
    }
}
