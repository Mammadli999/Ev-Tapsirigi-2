using System;

namespace Ev_Tapsirigi_2____Task_8
/*
2 dene eded verilib. I eded 4 reqemli II eded 7 reqemlidir.
I ededin 4%-ni tap.
Sonra II ededin 9% ni tap.
Sonra Cavalari toplayib 10 %ni tap.
 */
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1234;
            int b = 1234567;
            if (a>=1000 && a<=10000 && b>=1000000 && b<=10000000)
            {
                double c = a * 0.04;
                double d = b * 0.09;

                double e = c + d;
                double f = e * 0.10;

                Console.WriteLine(f);
            }
            else
            {
                Console.WriteLine("Yanlishdir");
            }
            
        }
    }
}
