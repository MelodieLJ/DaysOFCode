using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";

            int a = int.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            string c = Console.ReadLine();

            Console.WriteLine("Sum of the two integers is: {0}", Addition.Sum(i, a));
            Console.WriteLine("Sum of the two doubles rounded to one decimal place is: {0:N1}", Addition.Sum(d, b));
            Console.WriteLine("Concation of the two strings: {0}", Addition.Concat(s, c));
        }
    }
}
