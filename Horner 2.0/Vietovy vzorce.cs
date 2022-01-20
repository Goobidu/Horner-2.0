using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horner_2._0
{
    class Vietovy_vzorce
    {
        public void Run(string q, string w, string r)
        {
            double a = Convert.ToDouble(q);
            double b = Convert.ToDouble(w);
            double c = Convert.ToDouble(r);
            int X1;
            int X2;
            List<int> dělitelé = new List<int>();
            for (int i = 1; i < 100; i++)
            {
                if (c < 0)
                {
                    double stp2 = c * -1;
                    if ( c % i == 0)
                    {
                        for (int p = 0; p < 1; p++)
                        {
                            dělitelé.Insert(p, i);
                        }
                    }
                }
                if (c % i == 0)
                {
                    for (int p = 0; p < 1; p++)
                    {
                        dělitelé.Insert(p, i);
                    }
                }
            }
            //++++

            int bb = dělitelé.Count - 1;
            for (int i = 0; i < dělitelé.Count; i++)
            {

                if (dělitelé[bb] + dělitelé[i] == b * -1 && dělitelé[bb] * dělitelé[i] == c)
                {
                    X1 = dělitelé[bb];
                        X2 = dělitelé[i];

                    Console.WriteLine(X1);
                    Console.WriteLine(X2);
                }
                bb = bb - 1;
            }
            //+-+-
            int bb4 = dělitelé.Count - 1;
            for (int i = 0; i < dělitelé.Count ; i++)
            {

                if (dělitelé[bb4] + (dělitelé[i] * -1) == b * -1 && dělitelé[bb4] * (dělitelé[i] * -1) == c)
                {
                    X1 = dělitelé[bb4];
                    X2 = dělitelé[i];

                    Console.WriteLine(X1);
                    Console.WriteLine(X2);
                }
                bb4 = bb4 - 1;
            }
            //-+-+
            int bb3 = dělitelé.Count - 1;
            for (int i = 0; i < dělitelé.Count; i++)
            {

                if ((dělitelé[bb3] * -1) + dělitelé[i] == b * -1 && (dělitelé[bb3] * -1) * dělitelé[i] == c)
                {
                    X1 = dělitelé[bb3];
                    X2 = dělitelé[i];

                    Console.WriteLine(X1);
                    Console.WriteLine(X2);
                }
                bb3 = bb3 - 1;
            }
            //----
            int bb2 = dělitelé.Count - 1;

            
            for (int i = 0; i < dělitelé.Count; i++)
            {
                Console.WriteLine(dělitelé[bb2] + dělitelé[i]);
                if ((dělitelé[bb2] * -1) + (dělitelé[i] * -1) == b * -1 && (dělitelé[bb2] * -1) * (dělitelé[i] * -1) == c)
                {
                    X1 = dělitelé[bb2];
                    X2 = dělitelé[i];

                    Console.WriteLine(X1);
                    Console.WriteLine(X2);
                }
                bb2 = bb2 - 1;
            }

        }
    }
}
