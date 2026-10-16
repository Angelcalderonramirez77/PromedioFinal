using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromedioFinal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float P1, P2, P3, P4, Prom, Exmane, TrabajoF, PromFinal;


            Console.Write("Ingrese la Nota del primer periodo:");
            P1 = float.Parse(Console.ReadLine());
            Console.Write("Ingrese la Nota del segundo periodo:");
            P2 = float.Parse(Console.ReadLine());
            Console.Write("Ingrese la Nota del tercer periodo:");
            P3 = float.Parse(Console.ReadLine());
            Console.Write("Ingrese la Nota del cuarto periodo:");
            P4 = float.Parse(Console.ReadLine());

            Prom = ((P1 + P2 + P3 + P4) / 4) * 0.55F;




            Console.WriteLine(Prom);
            Console.ReadLine();
        }
    }
}
