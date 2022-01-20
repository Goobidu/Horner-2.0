using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horner_2._0
{
    class vypis
    {
        public void Vypis(string q, string w, string r)
        {

            double a = Convert.ToDouble(q);
            double b = Convert.ToDouble(w);
            double c = Convert.ToDouble(r);

            if (a > 1 && b > 0 && c > 0)
            {
                Console.WriteLine(a + "x^2 + " + b + "x + " + c + " = 0");
            }
            if (a == 1 && b > 0 && c > 0)
            {
                Console.WriteLine("x^2 + " + b + "x + " + c + " = 0");
            }
            if (a > 1 && b == 0 && c > 0)
            {
                Console.WriteLine(a + "x^2 + " + c + " = 0");
            }
            if (a > 1 && b > 0 && c < 0)
            {
                Console.WriteLine(a + "x^2 + " + b + "x " + c + " = 0");
            }
            if (a > 1 && b < 0 && c > 0)
            {
                Console.WriteLine(a + "x^2 " + b + "x + " + c + " = 0");
            }
            if (a == 1 && b < 0 && c > 0)
            {
                Console.WriteLine("x^2 " + b + "x + " + c + " = 0");
            }
            if (a > 1 && b < 0 && c < 0)
            {
                Console.WriteLine(a + "x^2 " + b + "x " + c + " = 0");
            }
            if (a > 1 && b == 0 && c < 0)
            {
                Console.WriteLine(a + "x^2 " + c + " = 0");
            }
            if (a > 1 && b > 0 && c == 0)
            {
                Console.WriteLine(a + "x^2 + " + b + "x = 0");
            }
            if (a > 1 && b < 0 && c == 0)
            {
                Console.WriteLine(a + "x^2 " + b + "x = 0");
            }
            if (a == 1 && b < 0 && c < 0)
            {
                Console.WriteLine("x^2 " + b + "x " + c + " = 0");
            }
            if (a == 1 && b == 0 && c < 0)
            {
                Console.WriteLine("x^2 " + c + " = 0");
            }
        }
    }
}
