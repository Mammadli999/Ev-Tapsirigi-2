using System;

namespace Ev_Tapsirigi_2____Task_7
/*
 *  2 dene 5 reqemli eded verilib. Bu ededleri toplayib. 
 *  Alinan cavabin evveline ve axirina 5 artir. Neticenin 5 % tap
 */
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 12345;
            int b = 54321;
            if (a>=10000 && a<100000 && b>=10000 && b<100000)
            {
                int c = a + b;
                int d = 500000 + c;
                int e = d * 10 + 5;
                double f = e * 0.05;

                Console.WriteLine(f);
            }
            else
            {
                Console.WriteLine("5 reqemli deyil");
            }
            
        }
    }
}
