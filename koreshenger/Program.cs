using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace koreshenger
{
    class Program
    {
        static void Main(string[] args)
        {
            Kör k1 = new Kör();
            k1.SetSugar(15);
            k1.SetTerulet();
            k1.SetKerulet();

            kiír(k1);
            
             
            Kör k2 = new Kör(58);
            k2.SetKerulet();
            k2.SetTerulet();


            Console.ReadKey();
        }

        private static void kiír(Kör k)
        {
            Console.WriteLine($"A {k.GetSugar()} sugarú kör kerülete: {k.GetKerulet()}, kerülete: {k.GetTerulet()}");
        }
    }
}
