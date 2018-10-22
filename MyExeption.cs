using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYList
{
    class MyExeption:Exception
    {
        public  MyExeption(string mess):base(mess)
        {
            
           // Console.WriteLine("Mistake!");
           
        }

     }
}
