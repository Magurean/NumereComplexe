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

            Complex nr = new Complex(5, 7);
            Complex nr2 = new Complex(4, 3);
            Complex.Print(nr);
            Console.WriteLine();
            Complex.Print(nr2);
            Console.WriteLine();
            Complex.Adunare(nr, nr2);
            Console.WriteLine();
            Complex.Scadere(nr, nr2);
            Console.WriteLine();
            Complex.Inmultire(nr, nr2);
            Console.WriteLine();
            Complex.RidicareaLaPutere(nr, 2);
            Console.WriteLine();
            Complex.FormaTrigonometrica(nr);

            Console.ReadKey();
        }
    }
}
