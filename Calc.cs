using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using calculator;



namespace CalcClass
{

    public class Calc
    {
        public const int MININT = -2147483648;
        public const int MAXINT = 2147483647;
        public static int Add(long a, long b)
        {
            int sum = Convert.ToInt32(a + b);
            if (MinMaxCheck(sum))
                return sum;
            else
            {
                return 0;
            }
        }

        public static int Sub(long a, long b)
        {
            int sub = Convert.ToInt32(a - b);
            if (MinMaxCheck(sub))
                return sub;
            else
            {
                return 0;
            }
        }

        public static int Mult(long a, long b)
        {
            int mult = Convert.ToInt32(a * b);
            if (MinMaxCheck(mult))
                return mult;
            else
            {
                return 0;
            }
        }

        public static int Div(long a, long b)
        {
            if (b == 0)
            {
                Global.lastError  = "Error 09: Failed to divide by 0";
                return 09;
            }
            int div = Convert.ToInt32(a / b);
            if (MinMaxCheck(div) && MinMaxCheck(Convert.ToInt32(a)) && MinMaxCheck(Convert.ToInt32(b)))
                return div;
            else
            {
                return 0;
            }
        }

        public static int Mod(long a, long b)
        {
            if (b == 0)
            {
                Global.lastError = "Error 09: Failed to divide by 0";
                return 09;
            }
            int mod = Convert.ToInt32(a % b);
            if (MinMaxCheck(mod) && MinMaxCheck(Convert.ToInt32(a)) && MinMaxCheck(Convert.ToInt32(b)))
                return mod;
            else
            {
                return 0;
            }
        }

        public static int ABS(long a)
        {
            if (MinMaxCheck(Convert.ToInt32(a)))
                return Convert.ToInt32(0 + a);
            else
            {
                return 0;
            }

        }

        public static int IABS(long a)
        {
            if (MinMaxCheck(Convert.ToInt32(a)))
                return Convert.ToInt32(0 - a);
            else
            {
                return 0;
            }
        }

        public static bool MinMaxCheck(int a)
        {
            if (a >= MININT && a <= MAXINT) return true;
            else
            {
                Global.lastError = "Error 06: value is very small or very large for int";
                return false;
            }
        }
    }
}
