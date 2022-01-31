using System;

namespace Ev_Tapsirigi_2____Task_12
/*4 dene 6 reqemli eded verilib. 
 * Ededlerin hamisinin 10 faizini tap ve topla. 
 * Sonra hamisinin 15 faizini tap ve topla.
Sonra yekunda alinanlar iki cavabi vur biri birine. 
Alinan neticenin evvel 10% tap sonra ise hemin cavabin 11% tap.
 */
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 111111;
            int b = 222222;
            int c = 333333;
            int d = 444444;
            bool aa = (a >= 100000 && b >= 100000 && c >= 100000 && d >= 100000);
            bool bb = (a < 1000000 && b < 1000000 && c < 1000000 && d < 1000000);
            if (aa==bb)
            {
                double e = a * 0.10;
                double f = b * 0.10;
                double g = c * 0.10;
                double l = d * 0.10;
                double m = e + f + g + l;

                double r = a * 0.15;
                double s = b * 0.15;
                double t = c * 0.15;
                double u = d * 0.15;
                double v = r + s + t + u;
                double w = m * v;

                double x = w * 0.10;
                double y = x * 0.11;

                Console.WriteLine(y);
            }
            else
            {
                Console.WriteLine("6 reqemli deyil");
            }


        }
    }
}
