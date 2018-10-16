using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Slogi
{
    class Program
    {
        static void Main(string[] args)
        {
            string stroka = "Зачем на дерево ты лезешь? Никак безделье и тоска? Своим глазам тут не поверишь! Ты б позвала ещё быка. Иль от трагической любови? Ворона, каркая корове, Крылом вертела у виска. Сползая со ствола, корова, Нет - отдохнуть бы и присесть: Бывай, ворона, ты здорова! Я яблоко желаю съесть!";
            char[] glasniy = { 'а', 'у', 'е', 'э', 'о', 'ы', 'я', 'и', 'ю', 'ё' };
            string []sonor={"р", "рь", "л", "ль", "м", "мь", "н", "нь", "й"};
            char[] separator = { ' ', '.', ',', '!', '?', ';', ':', '-' };
            string[] slova = stroka.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(stroka);
            Console.WriteLine();
            string newStroka = "";
            for (int i = 0; i < slova.Length; i++)
            {
                string newSlova = ""; 
                int mestoGl = 0;
                int k = 0;
                for (int j = 0; j < slova[i].Length; j++)
                {
                    if (glasniy.Contains(slova[i][j]))
                    { k++; }
                }
                int start = 0;
                while (k > 1)
                {
                    mestoGl = slova[i].IndexOfAny(glasniy, start);
                    if ((mestoGl + 2) < slova[i].Length)
                    {
                       if (sonor.Contains(slova[i].Substring(mestoGl + 1, 2).ToString()))
                       { newSlova = newSlova + slova[i].Substring(start, mestoGl - start + 3) + "-"; start = mestoGl + 3; k--; break; }
                    }
                    if (mestoGl + 1 < slova[i].Length)
                    {
                        if (sonor.Contains(slova[i][mestoGl + 1].ToString() ) )
                        { newSlova = newSlova + slova[i].Substring(start, mestoGl - start + 2) + "-"; start = mestoGl + 2; k--; break; }
                    }
                         newSlova = newSlova + slova[i].Substring(start, mestoGl - start + 1) + "-"; start = mestoGl + 1; k--; 
                }
                newSlova += slova[i].Substring(start);
                newStroka += newSlova + " ";            
            } 
            Console.WriteLine(newStroka);
            Console.ReadKey();
        }
    }
}
