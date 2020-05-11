using System;
using System.Drawing;
using static System.Console;

namespace WorkingWithStruts
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Example 1:");
            WriteLine();
            int n = 7;
            WriteLine($"Initial n value: {n}");
            Increment(n,out n);
            WriteLine($"Value n after method Increment(): {n}");
            WriteLine();
            WriteLine();


            WriteLine("Example 2:");
            WriteLine();
            var p = new Point { X = 7, Y = 18 };
            WriteLine($"Initial p values: {p.X},{p.Y}");
            Clear(ref p);
            WriteLine($"P values after method Clear(): {p.X},{p.Y}");
            WriteLine();
            WriteLine();


            WriteLine("Example 3");
            WriteLine();
            DateTime date = DateTime.Now;
            WriteLine($"Initial date: {date}");
            DateTime newDate = MyAddHours(date, 3);
            WriteLine($"Date after method AddHours(): {newDate}");


            WriteLine();
            WriteLine();
            WriteLine("Press any key to continue...");
            ReadKey();
        }

        //using the word "ref"
        static void Clear(ref Point p)
        {
            p.X = p.Y = 0;
        }

        //using the word "return"
        static DateTime MyAddHours(DateTime dt, int count)
        {
            DateTime newDt = dt.AddHours(count);
            return newDt;
        }

        //using the word "out"
        static void Increment(int i, out int i2)
        {
            i++;
            i2 = i;
        }
             
    }
}
