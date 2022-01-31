using System;

namespace Ev_Tapsrigi_2____Task_14
/*6 dene 6 reqemli eded verilib. Evvel hamisini topla . 
 * Sonra I ve III ededi bir birine yapishdir ve bir eded al.
I neticeden II neticeni cix. Alinan cavabin 10% tap. 
Neticenin uzerine V ve VI ededleri gel. Yekunda alinan cavabin 11% tap.
 */
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long a = 111111;
            int b = 222222;
            int c = 333333;
            int d = 444444;
            int e = 555555;
            int f = 666666;
            bool aa = (a>=100000 && b>=100000 && c>=100000 && d>=100000 && e>=100000 && f>=100000);
            bool bb = (a<1000000 && b<1000000 && c<1000000 && d<1000000 && e<1000000 && f<1000000);
            if (aa==bb)
            {
                long g = a + b + c + d + e + f;
                long h = (a * 1000000) + c;
                long i = (g - h);
                double j = i * 0.10;
                double k = j + e + f;
                double l = k * 0.11;

                Console.WriteLine(l);
            }
            else
            {
                Console.WriteLine("6reqemli deyil");
            }
            


            
        }
    }
}
