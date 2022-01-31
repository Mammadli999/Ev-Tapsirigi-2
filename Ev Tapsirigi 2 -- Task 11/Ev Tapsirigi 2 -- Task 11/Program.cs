using System;

namespace Ev_Tapsirigi_2____Task_11
/*4 dene 5 reqemli eded verilib. Her I ededin ustune III ededi gel . 
 * II ededin usutune IV eeddi gel.
Sonra cavablari vur birbirine. 
Alinan neticeden III ededin 3%-ni cix.
 */
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 12345;
            int b = 54321;
            int c = 56789;
            int d = 98765;
            bool aa = (a >= 10000 && b >= 10000 && c >= 10000 && d >= 10000);
            bool bb = (a < 100000 && b < 100000 && c < 100000 && d < 100000);
            if (aa==bb)
            {
                int e = a + c;
                int f = b + d;
                int g = e * f;
                double l = c * 0.03;

                Console.WriteLine(g - l);
            }
            else
            {
                Console.WriteLine("5 reqemli deyil");
            }
            
        }
    }
}
