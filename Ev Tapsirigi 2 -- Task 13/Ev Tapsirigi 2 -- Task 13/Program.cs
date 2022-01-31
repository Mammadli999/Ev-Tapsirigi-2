using System;

namespace Ev_Tapsirigi_2____Task_13
/*5 dene eded verilib.
 * Bunlardan 3 denesi 5 reqemli. 
 * 2 denesi ise 3 reqemlidir. 
 * 5 reqemli ededlerin 5% tap ,neticeleri vur bir birine.
Sonra 3 reqemli ededlerin 3% tap ,neticeleri topla. 
Sonra yekunda alinan iki cavalarin her birinin 10%-ni tapib topla.
 */
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 11111;   
            int b = 22222;   
            int c = 33333;   
            int d = 444;
            int e = 555;
            if (a>=10000 && a<100000 && b>=10000 && b<100000 && c>=10000 && c<100000 && d>=100 && d<1000 && e>=100 && e<1000)
            {
                double f = (a * 0.05) * (b * 0.05) * (c * 0.05);
                double g = (d * 0.03) + (e * 0.03);
                double h = (f * 0.10) + (g * 0.10);

                Console.WriteLine(h);
            }
            else
            {
                Console.WriteLine("Yanlishdir");
            }
            
        }
    }
}
