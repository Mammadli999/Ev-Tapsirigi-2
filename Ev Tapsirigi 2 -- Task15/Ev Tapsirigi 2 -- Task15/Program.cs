using System;

namespace Ev_Tapsirigi_2____Task15
/** 7 dene eded verilib.Bunlardan 2 denesi 3 reqemlidir. 2 denesi 4 reqemlidir. 2 denesi 5 reqemlidir.1 denesi ise 6 reqemlidir.
3 reqemli ededleri topla , sonra bunlarin ustune gel 4 reqemli ededlerin bir birine vurulmasindan alinan cavabi.
Sonra neticenin axirina 7 reqemini artir. Sonra cavabin ustune gel 5 reqemli ededlerin cemini.
Sonra neticeden cix 3 reqemli ededlerin bir birine vurulmasindan alinan cavabin axirina 1 artirilmish variantini.
Sonra alinan cavabin ustune gel 6 reqemli ededi.
Sonra alinan cavabdan cix 3 reqemli ve 4 reqemli ededlerin cemini.
Sonra alinan cavabin 18% -ni sonra 3%-ni sonra 1% tap.
Sonra alinan cavabin ustune 5 reqemli ededlerin cemini gel.
 */
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a1 = 111;
            int a2 = 222;
            int b1 = 1111;
            int b2 = 2222;
            int c1 = 11111;
            int c2 = 22222;
            int d1 = 111111;
            bool aa = (a1 >= 100 && a2 >= 100 && b1 >= 1000 && b2 >= 1000 && c1 >= 10000 && c2 >= 10000 && d1 >= 100000);
            bool bb = (a1 <= 1000 && a2 <= 1000 && b1 <= 10000 && b2 <= 10000 && c1 <= 100000 && c2 <= 100000 && d1 <= 1000000);
            if (aa == bb)
            {
                int a = (a1 + a2) + (b1 * b2);
                int b = ((a * 10) + 7) + (c1 + c2);
                int c = b - (a1 * a2 * 10 + 1);
                int d = (c + d1) - (a1 + a2 + b1 + b2);
                double e = (d * 0.18);
                double f = (e * 0.03);
                double g = (f * 0.01);
                double h = g + c1 + c2;

                Console.WriteLine(h);
            }
            else
            {
                Console.WriteLine("Yanlishdir");
            }
        }
    }
}
