using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace factorial
{
    class Factorial
    {
        public static int [] calcFactor(int n)
        {
            int perenos,chislo;
            int[] mas = new int[102];
           
            mas[101] = 1;
            for (int i = 0; i <= 100; i++)
            {
                mas[i] = 0;
            }
            for (int l = 1; l <= n; l++)
            {
                perenos = 0;
                for (int i = 101; i > 0; i--)
                {
                    chislo = mas[i] * l + perenos;
                    mas[i] = chislo % 10;
                    perenos = chislo / 10;
                }
            }
            return mas;
        }

        public static void showFactor(int [] mas)
        {
           int kolcifr=0;
           while (mas[kolcifr] == 0)
            {
                kolcifr++;
            }
           for (int i = kolcifr; i <= 101; i++)
            {
                Console.Write(mas[i]);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] mas;
            for (int i = 1; i <= 100; i++)
            {
                mas = calcFactor(i);
                Console.Write("{0}!=",i);
                showFactor(mas);
            }
            Console.ReadKey();
        }
    }
}
