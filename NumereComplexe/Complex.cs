using System;

namespace NumereComplexe
{
    internal class Complex
    {
        private int parte_reala;
        private int parte_imaginara;

        public Complex()
        {
            parte_reala = 1;
            parte_imaginara = 1;
        }
        public Complex(int p_reala)
        {
            parte_reala = p_reala;
            parte_imaginara = 1;
        }

        public Complex(int p_reala, int p_imaginara)
        {
            parte_imaginara = p_imaginara;
            parte_reala = p_reala;
        }

        public static void Adunare(Complex nr1, Complex nr2)
        {
            int real = nr1.parte_reala + nr2.parte_reala;
            int imaginar = nr1.parte_imaginara + nr2.parte_imaginara;
            Complex Adunare = new Complex(real, imaginar);
            Console.Write("Adunare: ");
            Complex.Print(Adunare);
        }

        public static void Scadere(Complex nr1,Complex nr2)
        {
            int real = nr1.parte_reala - nr2.parte_reala;
            int imaginar = nr1.parte_imaginara - nr2.parte_imaginara;         
            Complex Scadere = new Complex(real, imaginar);
            Console.Write("Scadere: ");
            Complex.Print(Scadere);
        }

        public static void Inmultire(Complex nr1,Complex nr2)
        {
            int real = (nr1.parte_reala * nr2.parte_reala) - (nr1.parte_imaginara * nr2.parte_imaginara);
            int imaginar = (nr1.parte_reala * nr2.parte_imaginara) + (nr2.parte_reala * nr1.parte_imaginara); ;
            Complex Inmultire = new Complex(real, imaginar);
            Console.Write("Inmultire: ");
            Complex.Print(Inmultire);
        }

        public static void RidicareaLaPutere(Complex nr1, int putere)
        {
            int real = (int)Math.Pow(nr1.parte_reala, putere);
            int imaginar = (int)Math.Pow(nr1.parte_imaginara, putere);
            Complex RidicareLaPutere = new Complex(real, imaginar);
            Console.Write("Ridicarea la puterea {0}: ", putere);
            Complex.Print(RidicareLaPutere);
        }

        public static void FormaTrigonometrica(Complex nr)
        {
            float teta = (float)Math.Atan(nr.parte_imaginara / nr.parte_reala);
            float r = (float)Math.Sqrt((nr.parte_reala * nr.parte_reala) + (nr.parte_imaginara * nr.parte_imaginara));

            //float x = r * ((float)Math.Cos(teta) + (float)Math.Sin(teta));
            Console.WriteLine("Forma trigonometrica: x= {0}*(cos({1}) + i*sin({2}))", r, teta, teta);
        }

        public static void Print(Complex nr)
        {
            if (nr.parte_imaginara < 0)
            {
                nr.parte_imaginara = (int)Math.Abs(nr.parte_imaginara);
                Console.WriteLine("z= {0}-{1}*i", nr.parte_reala, nr.parte_imaginara);
            }
            else Console.WriteLine("z= {0}+{1}*i", nr.parte_reala, nr.parte_imaginara);

        }
    }
}