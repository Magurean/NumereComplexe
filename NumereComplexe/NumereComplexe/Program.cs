using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumereComplexe
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex aux = new Complex();
            Complex nr1 = new Complex(5, 7);
            Complex nr2 = new Complex(4, 3);
            Console.WriteLine(nr1.ToString());

            Console.WriteLine(nr2.ToString());

            aux = nr1 + nr2;
            Console.WriteLine(aux.ToString());

            aux = nr1 - nr2;
            Console.WriteLine(aux.ToString());

            aux = nr1 * nr2;
            Console.WriteLine(aux.ToString());

            aux = nr1 ^ 2;
            Console.WriteLine(aux.ToString());

            nr1.FormaTrigonometrica();

            
            ComplexD D = new ComplexD();
            Console.WriteLine(D.RidicareaCuFormaTrig(nr1,2));

            List<Complex> multime = new List<Complex>();

            multime.Add(new ComplexD(2, 4));
            multime.Add(new ComplexD(5, 2));
            multime.Add(new ComplexD(1, 1));
            D.Dist(multime);
            
            
            Console.ReadKey();
        }
    }
}
