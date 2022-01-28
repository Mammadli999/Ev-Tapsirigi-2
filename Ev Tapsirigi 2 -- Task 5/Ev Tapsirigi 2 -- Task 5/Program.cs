using System;

namespace Ev_Tapsirigi_2____Task_5
/*4 reqemli eded verilib. 
 * Bu ededin evvelin 4 reqemi , axirina ise 44 ededini artir.
 * Alinan cavabin 44 % tap.
 */
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 5678;
            if (a>=1000 && a<=10000)
            {
                double b = 40000 + a;
                double c = b * 100 + 44;
                double d = c * 0.44;

                Console.WriteLine(d);
            }
            else
            {
                Console.WriteLine("4 reqemli deyil");
            }
            

            
        }
    }
}
