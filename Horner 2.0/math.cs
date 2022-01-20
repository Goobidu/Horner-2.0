using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horner_2._0
{
    class math
    {
        
        public void Horner()
        {
            Console.WriteLine("Jaký má polynom stupeň?");
            int stupeň = Convert.ToInt32(Console.ReadLine());
            int[] bse = new int[stupeň + 1];
            for (int i = 0; i < stupeň + 1; i++)
            {
                Console.WriteLine("Jaký je člen č. " + (i + 1));
                int základ = Convert.ToInt32(Console.ReadLine());
                bse[i] = základ;
            }
            Console.WriteLine("Chcete rovnici vypsat?    ano - 1     ne - 2");
            string start = Console.ReadLine();
            if (start == "1")
            {

                int stp = stupeň;
                for (int i = 0; i <= stupeň; i++)
                {
                    Console.Write(bse[i] + "x^" + stp   );
                    if (i == stupeň)
                    {
                        if (bse[i] > 0)
                        {
                            Console.Write(" +");
                        }
                    }
                    else
                    {


                        if (bse[i + 1] > 0) { Console.Write(" +"); }
                        
                    }
                    Console.Write(  " " );
                    stp = stp - 1;
                }
                Console.Write(" = 0" + '\n');
            }
            List<int> dělitelé = new List<int>();
            for (int i = 1; i < 100; i++)
            {
                if (bse[stupeň] < 0)
                {
                    int stp2 = bse[stupeň] * -1;
                    if (bse[stupeň] % i == 0)
                    {
                        for (int a = 0; a < 1; a++)
                        {
                            dělitelé.Insert(a, i);
                        }
                    }
                }
                if (bse[stupeň] % i == 0)
                {
                    for (int g = 0; g < 1; g++)
                    {
                        dělitelé.Insert(g, i);
                    }
                }
            }
            int p = 0;

            int[] vys = new int[stupeň + 1];
            for (int i = 0; i < dělitelé.Count; i++)
            {
                int vysledek = 0;

                for (p = 0; p < stupeň ; p++)
                {

                    vysledek = (bse[p] + vysledek) * dělitelé[i];

                    vys[p] = vysledek; 
                }
                if (vysledek + bse[stupeň] == 0)
                {
                    Console.WriteLine("Kořen je " + dělitelé[i]);
                   
                }
            }
            for (int i = 0; i < dělitelé.Count; i++)
            {
                int vysledek = 0;

                for ( p = 0; p < stupeň; p++)
                {

                    vysledek = (bse[p] + vysledek) * (dělitelé[i] * -1);
                }
                if (vysledek + bse[stupeň] == 0)
                {
                    Console.WriteLine("Kořen je " + (dělitelé[i] * -1));
                }
            }
        }
    }
}
