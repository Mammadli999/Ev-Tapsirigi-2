using System;

namespace Ev_Tapsirigi_2____Task_9
/*
 * 3 dene 6 reqemli eded verilib. 
 * Her birinin 10 faizini tapib neticeleri topla. 
 * Alinan cavabin 10% tap
 */
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 123456;
            int b = 654321;
            int c = 987654;
            if (a>=100000 && a<=1000000 && b>=100000 && b<=1000000 && c>=100000 && c<=1000000)
            {
                double d = a * 0.10;
                double e = b * 0.10;
                double f = c * 0.10;
                double g = d + e + f;
                double h = g * 0.10;

                Console.WriteLine(h);
            }
            else
            {
                Console.WriteLine("Yanlishdir");
            }
            

        }
    }
}
