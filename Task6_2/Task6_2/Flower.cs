using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task6_2
{
    class Flower
    {
        string _type;
        string _country; 
        int _price;

        public string _Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public string _Country
        {
            get { return _country; }
            set { _country = value; }
        }
        public int _Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public Flower()
        {
            _type = null;
            _country = null;
            _price = 0;
        }

        public Flower(string my_type, string my_country, int my_price)
        {
            _type = my_type;
            _country = my_country;
            _price = my_price;  
        }

       public int AddToBoucket(int number)
       {
           Console.WriteLine(number + " "+this._type + " were added to boucket");
           return _price*number;
       }
    }
}
