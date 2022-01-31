using System;

namespace Ev_Tapsirigi_2____Task_10
/* 3 dene 4 reqemli eded verilib. I ededin 1%-ni, II ededin 2% , III ededin 3 % tap.
   Neticeleri bir birinden cix. Alinan cavabin ustune III ededin 7% faizini gel
 */
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1234;
            int b = 4321;
            int c = 8765;
            if (a>=1000 && a<10000 && b>=1000 && b<10000 && c>=1000 && c<10000)
            {
                double d = a * 0.01;
                double e = b * 0.02;
                double f = c * 0.03;
                double g = d - e - f;

                double h = c * 0.07;

                Console.WriteLine(g + h);
            }
            else
            {
                Console.WriteLine("4reqemli deyil");
            }
            
        }
    }
}
