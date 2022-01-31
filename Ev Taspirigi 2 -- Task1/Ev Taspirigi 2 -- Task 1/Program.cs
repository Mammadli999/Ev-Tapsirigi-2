using System;

namespace Ededin_evveline_7_axrina_8_reqemi_elave_et
/*4 reqemli eded verilib. 
 * Bu ededin eveline 7 reqemini , axirinada 8 reqemini artir. 
 */
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 4444;
            int b = 70000;
            int c = 10;
            int d = 8;

            if (a>=1000 && a<10000)
            {
               int e = b + a;
               int f = e * c;
               int g = f + d;
                Console.WriteLine(g);
            }
            else
            {
                Console.WriteLine("4 reqemli deyil");
            }

        }
    }
}
