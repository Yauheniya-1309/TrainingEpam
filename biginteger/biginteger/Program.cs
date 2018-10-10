using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace biginteger
{
    class Program
    {
        static void Main(string[] args)
        {
            const byte a = 111;
            BigInt obja = new BigInt(a);
            const int b = 10000;
            BigInt objb = new BigInt(b);
            const long c = 1255555;
            BigInt objc = new BigInt(c);
            const string d = "5";
            BigInt objd = new BigInt(d);
            Console.WriteLine("Constructor byte");
            obja.Show();
            Console.WriteLine("Constructor int");
            objb.Show();
            Console.WriteLine("Constructor long");
            objc.Show();
            Console.WriteLine("Constructor string");
            objd.Show();
            
            BigInt objsum = new BigInt();
            Console.WriteLine("object + object");
            objsum = objb + objd;
            objsum.Show();
            Console.WriteLine("object + byte");
            objsum = objb + a;
            objsum.Show();
            Console.WriteLine("object + int");
            objsum = objb + b;
            objsum.Show();
            Console.WriteLine("object + long");
            objsum = objb + c;
            objsum.Show();
            Console.WriteLine("object + string");
            objsum = objb + "99";
            objsum.Show();


            BigInt objdiff = new BigInt();
            Console.WriteLine("object - object");
            objdiff = objc - objd;
            objdiff.Show();
            Console.WriteLine("object - byte");
            objdiff = objc - a;
            objdiff.Show();
            Console.WriteLine("object - int");
            objdiff = objc - b;
            objdiff.Show();
            Console.WriteLine("object - long");
            objdiff = objc - c;
            objdiff.Show();
            Console.WriteLine("object - string");
            objdiff = objc - "99";
            objdiff.Show();

            BigInt objmult = new BigInt(); 
            Console.WriteLine("object * object");
            objmult = objb * objd;
            objmult.Show();
            Console.WriteLine("object * byte");
            objmult = objb * a;
            objmult.Show();
            Console.WriteLine("object * int");
            objmult = objb * b;
            objmult.Show();
            Console.WriteLine("object * long");
            objmult = objb * c;
            objmult.Show();
            Console.WriteLine("object * string");
            objmult = objb * "99";
            objmult.Show();

            objsum.SetNewValue("12345678987654321");
            objsum.Show();

            objdiff.SetNewValue(123456789);
            objdiff.Show();


            Console.ReadKey();
        }
    }
}
