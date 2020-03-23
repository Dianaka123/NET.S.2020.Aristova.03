using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace NET.S._2020.Aristova._03
{
    public class NOD
    {
        public int[] ArrayNumb { get; set; }


        private Stopwatch evklidTIme;
        private Stopwatch binTime;

        public NOD(int[] arrayNumb)
        {
            ArrayNumb = arrayNumb;
        }

        public int EvklidNOD()
        {
            evklidTIme = new Stopwatch();
            evklidTIme.Start();
            if (ArrayHaveNull())
            {
                return -1;
            }

            if (CountSimpleNumb() > 1)
            {
                return 1;
            }

            int min = foundMin();
            int max = foundMax();

            evklidTIme.Stop();

            return FoundNOD(max, min);
        }

        public uint BinaryGCD()
        {
            binTime = new Stopwatch();
            binTime.Start();

            ArrayHaveNull();

            if (CountSimpleNumb() > 1)
            {
                return 1;
            }

            uint max = (uint)foundMax();
            uint min = (uint)foundMin();

            binTime.Stop();

            return GCD(max, min);
        }

        public double GetEvklidTime()
        {
            return evklidTIme.Elapsed.TotalMilliseconds;
        }

        public double GetBinTime()
        {
            return binTime.Elapsed.TotalMilliseconds;
        }
        private int foundMin()
        {
            int min = Int32.MaxValue;
            for (int i = 0; i < ArrayNumb.Length; i++)
            {
                if (min > Math.Abs(ArrayNumb[i]))
                {
                    min = Math.Abs(ArrayNumb[i]);
                }
            }

            return min;
        }

        private int foundMax()
        {
            int max = Int32.MinValue;
            for (int i = 0; i < Math.Abs(ArrayNumb.Length); i++)
            {
                if (max < ArrayNumb[i])
                {
                    max = Math.Abs(ArrayNumb[i]);
                }
            }

            return max;
        }

        private int FoundNOD(int a, int b)
        {
            while (b != 0)
                b = a % (a = b);
            return a;
        }

        private bool ArrayHaveNull()
        {
            bool isHaveNull = false;

            for (int i = 0; i < ArrayNumb.Length; i++)
            {
                if (ArrayNumb[i] == 0)
                {
                    isHaveNull = true;
                    ArrayNumb[i] = foundMax();
                }
            }

            return isHaveNull;
        }
        private int CountSimpleNumb()
        {
            int count = 0;
            for (int i = 0; i < ArrayNumb.Length; i++)
            {
                if (isSimple(ArrayNumb[i]))
                {
                    count++;
                }
            }

            return count;
        }
        private bool isSimple(int N)
        {
            for (int i = 2; i < (int) (N / 2); i++)
            {
                if (N % i == 0)
                    return false;
            }

            return true;
        }
        private bool IsOdd(uint num) => (num & 1) == 1;
        private bool IsEven(uint num) => (num & 1) == 0;
        private uint Mul2(uint n) => n << 1;
        private uint Div2(uint n) => n >> 1;
        private uint GCD(uint a, uint b)
        {

            if (a == b || a == 0)
                return b;

            if (b == 0)
                return a;

            if (IsEven(a))
            {
                return IsOdd(b)
                    ? GCD(Div2(a), b)
                    : Mul2(GCD(Div2(a), Div2(b)));
            }
            else if (IsEven(b))
            {
                return GCD(a, Div2(b));
            }
            else
            {
                return a > b
                    ? GCD(Div2((a - b)), b)
                    : GCD(Div2((b - a)), a);
            }
        }

    }
}
