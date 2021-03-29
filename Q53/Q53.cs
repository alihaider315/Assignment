using System;

namespace Q53
{
    class Program
    {
        static void Main(string[] args)
        // Part a;
        {
            int a=3 , b=4;
            a=++a*b++;
            Console.WriteLine(a); 
        }
        
        //Part b;
        // {
        //     int a=3 , b=4;
        //     a=++a*++b;
        //     Console.WriteLine(a); 
        // }

        //Part c;
        // {
        //     int a=3 , b=4;
        //     a=a+1;
        //     b=b+1;
        //     a=a*b;
        //     Console.WriteLine(a); 
        // }
    }
}
