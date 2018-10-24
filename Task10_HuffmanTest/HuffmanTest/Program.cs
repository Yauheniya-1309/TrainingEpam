using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace HuffmanTest
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Encoding enc=Encoding.GetEncoding(1251);
            string input = System.IO.File.ReadAllText(@"D:\Epam\goncharov.txt",Encoding.Default);
            HuffmanTree huffmanTree = new HuffmanTree();

            // Build the Huffman tree
            huffmanTree.Build(input);

            // Encode

            Console.Write("Encoded1: "); 
            BitArray encoded = huffmanTree.Encode(input);

            Console.Write("Encoded2: ");
            string dec = "";
            Console.WriteLine(encoded.Length);
            int i = 0;
            foreach (bool bit in encoded)
            {
                dec+=(bit ? (char)1 : (char)0);
              //  Console.Write(i++);
            //    Console.Write((bit ? 1 : 0) + "");
            }
            System.IO.File.WriteAllText(@"D:\Epam\code.txt", dec);
            Console.WriteLine();
            Console.Write("Encoded3: ");
            // Decode
            string decoded = huffmanTree.Decode(encoded);

            Console.Write("Encoded4: ");
            System.IO.File.WriteAllText(@"D:\Epam\result.txt",decoded,Encoding.Default);
            Console.WriteLine("Decoded: " + decoded);

            Console.ReadLine();
        }
    }
}
