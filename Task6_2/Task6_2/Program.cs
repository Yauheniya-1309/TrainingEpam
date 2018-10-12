using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Flower[] Boucket=new Flower[5];
            int price=0;
            Boucket[0] = new Tulip();
            price+=Boucket[0].AddToBoucket(3);

            Boucket[1] = new Sunflower();
            price += Boucket[1].AddToBoucket(1);

            Boucket[2] = new Rose();
            price += Boucket[2].AddToBoucket(10);

            Boucket[3] = new Orchid();
            price += Boucket[3].AddToBoucket(4);

            Boucket[4] = new Daisy();
            price += Boucket[4].AddToBoucket(19);

            Console.WriteLine("Total price "+ price);
            Console.ReadKey();
        }
    }
}
