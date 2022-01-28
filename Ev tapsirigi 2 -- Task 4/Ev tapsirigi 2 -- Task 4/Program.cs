using System;

namespace Ev_tapsirigi_2____Task_4
/*3 reqemli eded verilib. 
 * Bu ededin axirina 7 artir. 
 * Sonra cavabin 7% tap;
 */
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 444;
            if (a>=100  && a<=1000)
            {
                double b = (a * 10) + 7;
                double c = b * 0.07;
                
                Console.WriteLine(c);
            }
            else
            {
                Console.WriteLine("3 reqemli deyil");
            }
        }
    }
}
