using System;

namespace Q58
{
    class Program
    {
        static void Main(string[] args)
        // a;
        // {
        //     int a=2, b=3, c=5;
        //     Console.WriteLine(++a);
        //     Console.WriteLine(++b);
        //     Console.WriteLine(++c);
        // }
        // VALID

        // b;
        // {
        //     int a=2, b=3, c=5;
        //     abc;
        //     Console.WriteLine(a);
        //     Console.WriteLine(b);
        //     Console.WriteLine(c);
        // }
        // INVALID

        // c;
        // {
        //     int a=2, b=3, c=5;
        //     Console.WriteLine(a++);
        //     Console.WriteLine(b++);
        //     Console.WriteLine(c++);
        // }
        // VALID

        // d;
        // {
        //     int a=2, b=3, c=5;
        //     b+=a;
        //     Console.WriteLine(a);
        //     Console.WriteLine(b);
        //     Console.WriteLine(c);
        // }
        // VALID

        // e;
        // {
        //     int a=2, b=3, c=5;
        //     b+=a*c;
        //     Console.WriteLine(a);
        //     Console.WriteLine(b);
        //     Console.WriteLine(c);
        // }
        // VALID

        // f;
        // {
        //     int a=2, b=3, c=5;
        //     a++b;
        //     Console.WriteLine(a);
        //     Console.WriteLine(b);
        //     Console.WriteLine(c);
        // }
        // INVALID

        // g;
        // {
        //     int a=2, b=3, c=5;
        //     a+=2;
        //     b=2/2;
        //     c=a*b;
        //     Console.WriteLine(a);
        //     Console.WriteLine(b);
        //     Console.WriteLine(c);
        // }
        // VALID

        // h;
        // {
        //     int a=2, b=3, c=5;
        //     ++b++;
        //     Console.WriteLine(b);
        // }
        // INVALID

        // i;
        {
            int a=2, b=3, c=5;
            b = a++ + b++;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
        // VALID
    }
}
