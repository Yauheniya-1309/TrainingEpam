using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace polynoms
{
    class Polynom
    {
        public static int[] EnterPolynom()
        {
            int stepenpol = 0;
            Console.Write("Enter stepen_");
            stepenpol = Convert.ToInt32(Console.ReadLine());
            int[] poly = new int[stepenpol+1];
            Console.WriteLine("Enter polynom_");
            for (int i = 0; i < poly.Length; i++)
            {
                Console.Write("Koefficient (x^{0})=", i);
                poly[i] = Convert.ToInt32(Console.ReadLine());
            }
            return poly;
        }

        public static void ShowPolynom(int[]mas)
        {
            for (int i = mas.Length-1; i > 0; i--)
            {
                Console.Write("{0}(x^{1})+",mas[i],i);
            }
            Console.Write(mas[0]);
            Console.WriteLine();
        }

        public static int[] AddPolynom(int[] mas1, int []mas2)
        {
            if (mas1.Length == mas2.Length)
            {
                for (int i = 0; i < mas1.Length; i++)
                {
                    mas1[i] += mas2[i];
                }
                return mas1;
            }
            else if (mas1.Length < mas2.Length)
            {
                for (int i = 0; i < mas1.Length; i++)
                {
                    mas2[i] += mas1[i];
                }
                return mas2;
            }
            else
                for (int i = 0; i < mas2.Length; i++)
                {
                    mas1[i] += mas2[i];
                }
            return mas1;
        }

        static void Main(string[] args)
        {
            int[] polynom1;
            int[] polynom2;
            polynom1 = EnterPolynom();
            polynom2 = EnterPolynom();

           
            ShowPolynom(polynom1);
            ShowPolynom(polynom2);
            int[] result = AddPolynom(polynom1, polynom2);
            ShowPolynom(result);
            Console.ReadKey();
        }
    }
}
