using System;

namespace Horner_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var app3 = new Vietovy_vzorce();
            var app2 = new Polynom();
            var app4 = new vypis();
            Console.WriteLine("Co chcete použít - Hornerovo schéma(1)" +'\n'+ "                 - Vietovy vzorce(2)" + '\n' + "                 - Vypsat polynom(kvadratická rovnice(3))");
            string start = Console.ReadLine();
            if (start == "1")
            {

                var app = new math();
                app.Horner();
            }
            if (start == "2")
            {
                Console.WriteLine("Jaký je člen č. 1");
                app2.a = Console.ReadLine();

                Console.WriteLine("Jaký je člen č. 2");
                app2.b = Console.ReadLine();

                Console.WriteLine("Jaký je člen č. 3");
                app2.c = Console.ReadLine();
                app3.Run(app2.a, app2.b, app2.c);
            }
            if (start == "3")
            {
                Console.WriteLine("Jaký je člen č. 1");
                app2.a = Console.ReadLine();

                Console.WriteLine("Jaký je člen č. 2");
                app2.b = Console.ReadLine();

                Console.WriteLine("Jaký je člen č. 3");
                app2.c = Console.ReadLine();
                app4.Vypis(app2.a, app2.b, app2.c);
            }
        }
    }
}
