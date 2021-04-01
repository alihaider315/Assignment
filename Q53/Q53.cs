using System;

namespace question_53
{
    class Program
    {
        static void Main(string[] args)
        {
            // a;
            // {
            // int x=20, y=35;
            // x=y++ + x++;
            // y=++y + ++x;
            // Console.Write(x);
            // Console.Write(y);
            // }

            // b;
            // {
            // int x=10, y=15, a,b;
            // a=x++;
            // b=++y;
            // Console.WriteLine(x);
            // Console.WriteLine(y);
            // }

            // c;
            // {
            // int a=10,b;
            // b=a++;
            // Console.WriteLine(value: a);
            // }

            // d;
            // {
            // float x=3.8F;
            // Console.WriteLine((int)x);
            // }

            // e;
            // {
            //     int n = 10;
            //     int x = 0;
            //     x=n--;
            //     Console.WriteLine(x);
            // }

            // f;
            {
                int i = 5, j = 6, k = 7, n = 3;
                Console.WriteLine(i+j*k-k%n);
                Console.WriteLine(i/n);
            }

            // g;
            // {
            //     int n;
            //     int x=3;
            //     n=x;
            //     Console.Write("n=");
            //     Console.Write(n);
            // }

            // h;
            // {
            //     int a=6;
            //     Console.Write(a);
            //     a=a+3;
            //     Console.Write(a);
            //     a-=5;
            //     Console.Write(a);
            //     a++;
            //     Console.Write(a);
            // }

        }
    }
}
