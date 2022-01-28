using System;

namespace Ev_tapsirigi_2____Task_2
/*3 reqemli eded verilib. 
 * Bu ededin axirina hemin ededdin ozunu yapishdir. 
 */
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 444;

            if (a>=100 && a<=1000)
            {
                a = a + (a * 1000);
                Console.WriteLine(a);

                /* 
                int b = a * 1000;
                int c = a + b;               // belede mumkundur
                Console.WriteLine(c);
                */
            }
            else
            {
                Console.WriteLine("3 reqemli deyil");
            }
        }
    }
}
