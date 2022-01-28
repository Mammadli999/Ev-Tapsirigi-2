using System;

namespace Ev_tapsirigi_2____Task_3
/*5 reqemli eded verilib. 
 * Bu ededin evvel 18 % sonra ise 3 % tap.
 */
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 12345;
            if (a>=10000 && a<=100000)
            {
                double b = a * 0.18;
                double c = b * 0.03;

                Console.WriteLine(c);
            }
            else
            {
                Console.WriteLine("5 reqemli deyil");
            }
           
        }
    }
}
