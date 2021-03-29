using System;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 20 , y = 35;
            x = y++ + x++;
            Console.WriteLine(x);
            Console.WriteLine(y);
            x = x+2;
            Console.WriteLine(x);
            //Console.WriteLine("Hello World!");
        }
    }
}
