using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace biginteger
{
    class BigInt
    {
        int[] _number;
        public int[] _Number
        {
            get{return _number;}
            set{_number=value;}
        }

        public BigInt()
        {
            _number = new int[100];
            for (int i = 0; i < 100; i++)
            {
                _number[i] = 0;
            }    
        }
        public BigInt(int a)
        {
            _number = new int[100];
            for (int i = 0; i < 100; i++)
            {
                _number[i] = 0;
            }
            int pos = 0;
            while (a != 0)
            {
                _number[pos] = a % 10;
                a /= 10;
                pos++;
            }
        }
        public BigInt(long a)
        {
            _number = new int[100];
            for (int i = 0; i < 100; i++)
            {
                _number[i] = 0;
            }
            int pos = 0;
            while (a != 0)
            {
                _number[pos] = (int)(a % 10);
                a /= 10;
                pos++;
            }
        }
        public BigInt(string s)
        {
            _number = new int[100];
            for (int i = 0; i < 100; i++)
            {
                _number[i] = 0;
            }
            int pos = 00;
            int len = s.Length;
            while (len != 0)
            {
                _number[pos] = (int)Char.GetNumericValue(s[len - 1]);
                pos++;
                len--;
            }
        }
       
        public void Show()
        {
            int pos = 99;
            while ((_number[pos] == 0)&&(pos!=0))
            {
                pos--;
            }
            for (int i = pos; i >= 0; i--)
            {
                Console.Write(_number[i]);
            }
            Console.WriteLine();
        }
        
        public static BigInt operator +(BigInt obj1, BigInt obj2)
        {
            BigInt res = new BigInt(0);
            int perenos = 0;
            int chislo = 0;
            for (int i = 0; i < 100; i++)
            {
                chislo = obj1._number[i]+obj2._number[i] + perenos;
                res._number[i] = chislo % 10;
                perenos = chislo / 10;
            }
            return res;
        }   
        public static BigInt operator +(BigInt obj1, int obj)
        {
            BigInt res = new BigInt(0);
            BigInt obj2 = new BigInt(obj);
            int perenos = 0;
            int chislo = 0;
            for (int i = 0; i < 100; i++)
            {
                chislo = obj1._number[i] + obj2._number[i] + perenos;
                res._number[i] = chislo % 10;
                perenos = chislo / 10;
            }
            return res;
        }
        public static BigInt operator +(BigInt obj1, long obj)
        {
            BigInt res = new BigInt(0);
            BigInt obj2 = new BigInt(obj);
            int perenos = 0;
            int chislo = 0;
            for (int i = 0; i < 100; i++)
            {
                chislo = obj1._number[i] + obj2._number[i] + perenos;
                res._number[i] = chislo % 10;
                perenos = chislo / 10;
            }
            return res;
        }
        public static BigInt operator +(BigInt obj1, string obj)
        {
            BigInt res = new BigInt(0);
            BigInt obj2 = new BigInt(obj);
            int perenos = 0;
            int chislo = 0;
            for (int i = 0; i < 100; i++)
            {
                chislo = obj1._number[i] + obj2._number[i] + perenos;
                res._number[i] = chislo % 10;
                perenos = chislo / 10;
            }
            return res;
        }
        
        public static BigInt operator -(BigInt obj1, BigInt obj2)
        {
            BigInt res = new BigInt(0);
            for (int i = 0; i < 100; i++)
            {
                if (obj1._number[i] >= obj2._number[i])
                {
                    res._number[i] = obj1._number[i] - obj2._number[i];
                }
                else
                {
                    res._number[i] = obj1._number[i] + 10 - obj2._number[i];
                    obj1._number[i + 1]--;
                }
            }
            return res;
        }
        public static BigInt operator -(BigInt obj1, int obj)
        {
            BigInt res = new BigInt(0);
            BigInt obj2 = new BigInt(obj);
            for (int i = 0; i < 100; i++)
            {
                if (obj1._number[i] >= obj2._number[i])
                {
                    res._number[i] = obj1._number[i] - obj2._number[i];
                }
                else
                {
                    res._number[i] = obj1._number[i] + 10 - obj2._number[i];
                    obj1._number[i + 1]--;
                }
            }
            return res;
        }
        public static BigInt operator -(BigInt obj1, long obj)
        {
            BigInt res = new BigInt(0);
            BigInt obj2 = new BigInt(obj);
            for (int i = 0; i < 100; i++)
            {
                if (obj1._number[i] >= obj2._number[i])
                {
                    res._number[i] = obj1._number[i] - obj2._number[i];
                }
                else
                {
                    res._number[i] = obj1._number[i] + 10 - obj2._number[i];
                    obj1._number[i + 1]--;
                }
            }
            return res;
        }
        public static BigInt operator -(BigInt obj1, string obj)
        {
            BigInt res = new BigInt(0);
            BigInt obj2 = new BigInt(obj);
            for (int i = 0; i < 100; i++)
            {
                if (obj1._number[i] >= obj2._number[i])
                {
                    res._number[i] = obj1._number[i] - obj2._number[i];
                }
                else
                {
                    res._number[i] = obj1._number[i] + 10 - obj2._number[i];
                    obj1._number[i + 1]--;
                }
            }
            return res;
        }

        public static BigInt operator *(BigInt obj1, BigInt obj2)
        {
            //  length = size_a + size_b + 1;
            BigInt res = new BigInt(0);
            for (int ix = 0; ix < 49; ix++)
                for (int jx = 0; jx < 49; jx++)
                    res._number[ix + jx] += obj1._number[ix] * obj2._number[jx];

            for (int ix = 0; ix < 99; ix++)
            {
                res._number[ix + 1] += res._number[ix] / 10;
                res._number[ix] %= 10;
            }

            return res;
        }
        public static BigInt operator *(BigInt obj1, int obj)
        {
            BigInt res = new BigInt(0);
            BigInt obj2 = new BigInt(obj);
            for (int ix = 0; ix < 49; ix++)
                for (int jx = 0; jx < 49; jx++)
                    res._number[ix + jx] += obj1._number[ix] * obj2._number[jx];

            for (int ix = 0; ix < 99; ix++)
            {
                res._number[ix + 1] += res._number[ix] / 10;
                res._number[ix] %= 10;
            }

            return res;
        }
        public static BigInt operator *(BigInt obj1, long obj)
        {
            BigInt res = new BigInt(0);
            BigInt obj2 = new BigInt(obj);
            for (int ix = 0; ix < 49; ix++)
                for (int jx = 0; jx < 49; jx++)
                    res._number[ix + jx] += obj1._number[ix] * obj2._number[jx];

            for (int ix = 0; ix < 99; ix++)
            {
                res._number[ix + 1] += res._number[ix] / 10;
                res._number[ix] %= 10;
            }

            return res;
        }
        public static BigInt operator *(BigInt obj1, string obj)
        {
            BigInt res = new BigInt(0);
            BigInt obj2 = new BigInt(obj);
            for (int ix = 0; ix < 49; ix++)
                for (int jx = 0; jx < 49; jx++)
                    res._number[ix + jx] += obj1._number[ix] * obj2._number[jx];

            for (int ix = 0; ix < 99; ix++)
            {
                res._number[ix + 1] += res._number[ix] / 10;
                res._number[ix] %= 10;
            }

            return res;
        }
        
        public void SetNewValue(int a)
        {
            for (int i = 0; i < 100; i++)
            {
                _number[i] = 0;
            }
            int pos = 0;
            while (a != 0)
            {
                _number[pos] = a % 10;
                a /= 10;
                pos++;
            }
         }
        public void SetNewValue(long a)
         {
             for (int i = 0; i < 100; i++)
             {
                 _number[i] = 0;
             }
             int pos = 0;
             while (a != 0)
             {
                 _number[pos] = (int)(a % 10);
                 a /= 10;
                 pos++;
             }
         }
        public void SetNewValue(String  s)
         {
            for (int i = 0; i < 100; i++)
            {
                _number[i] = 0;
            }
            int pos = 00;
            int len = s.Length;
            while (len != 0)
            {
                _number[pos] = (int)Char.GetNumericValue(s[len - 1]);
                pos++;
                len--;
            }
         }
    }
}
