using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1
{
    public class Addition
    {
        public static int Sum(int x, int y)
        {
            int sum = x + y;
            return sum;
        }

        public static double Sum(double a, double b)
        {
            double sum = a + b;
            return sum;
        }

        public static string Concat(string s, string t)
        {
            string concat = s + t;
            return concat;
        }
    }
}
