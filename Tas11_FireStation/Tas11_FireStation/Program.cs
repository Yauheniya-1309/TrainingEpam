using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tas11_FireStation
{
    class Program
    {
        static void Main(string[] args)
        {
          //  bool BigFire;
            
            House[] house = new House[5];
            
            for (int i = 0; i < house.Length; i++)
            {
                house[i] = new House();
            }
            
            FireCar1 car1 = new FireCar1();
            FireCar2 car2 = new FireCar2();

            Random rnd = new Random();
           
            
         //   
            for (int i = 0; i < house.Length; i++)
            {
                Console.WriteLine("House #{0}", i);
                
                int j = rnd.Next(1, 4);
                
                if (j == 1)
                {
                    house[i].onFire += car1.Drive;
                }
                else if (j == 2)
                {
                    house[i].onFire += car1.Drive;
                
                    house[i].onFire += car2.Drive;
                }
                else
                {
                    Console.WriteLine("No Fire");

                }
                house[i].FireInHouse();
                
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
