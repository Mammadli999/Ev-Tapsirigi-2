using System;

namespace Ev_Tapsirigi_2____Task_6
/*
 *  4 reqemli eded verilib. Bu ededin evvel 20%-ni , 
 *  sonra ise cavabin 10% tap. Alinan cavabin kvadratini tap
 */
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1234;
            if (a>=1000 && a<10000)
            {
                double b = a * 0.20;
                double c = b * 0.10;
                double d = c * c;

                Console.WriteLine(d);
            }
            else
            {
                Console.WriteLine("4reqemli deyil");
            }
           
                         
        }
    }
}
