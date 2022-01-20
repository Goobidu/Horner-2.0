using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horner_2._0
{
    class Diskriminant
    {
        public double Run(string q, string w, string r)
        {
            double a = Convert.ToDouble(q);
            double b = Convert.ToDouble(w);
            double c = Convert.ToDouble(r);

            double D = Math.Pow(b, 2) - 4 * a * c;


            if (D < 0)
            {
                double v = 0;
                for (double i = 0; i < 1000; i++)
                {
                    v = c / i;
                    if (v + i == (b * -1))
                    {
                        Console.WriteLine("x1 se rovná " + i);
                        Console.WriteLine("x2 se rovná " + v);
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            else if (a == 0)
            {
                Console.WriteLine("Nemá řešení. ");
            }

            double xx = b * -1 - Math.Sqrt(D);
            double xxx = b * -1 + Math.Sqrt(D);
            double x = xx / (2 * a);
            double x2 = xxx / (2 * a);


            Console.WriteLine(x + " je X1");
            Console.WriteLine(x2 + " je X2");


            return x;
        }
    }
}
