using System;

namespace NumereComplexe
{
    internal class Complex
    {
        protected double parte_reala;
        protected double parte_imaginara;
        
        

        public Complex()
        {
            parte_reala = 0;
            parte_imaginara = 0;
        }
        public Complex(double p_reala)
        {
            parte_reala = p_reala;
            parte_imaginara = 0;
        }
        public Complex(double p_reala, double p_imaginara)
        {
            parte_imaginara = p_imaginara;
            parte_reala = p_reala;
        }

        virtual public double ParteImaginara()
        {
            return parte_imaginara;
        }

        virtual public double ParteReala()
        {
            return parte_reala;
        }

        public static Complex operator +(Complex nr1, Complex nr2)
        {
            return new Complex(nr1.parte_reala+nr2.parte_reala,nr1.parte_imaginara+nr2.parte_imaginara);
        }

        public static Complex operator -(Complex nr1, Complex nr2)
        {
            return new Complex(nr1.parte_reala - nr2.parte_reala, nr1.parte_imaginara - nr2.parte_imaginara);
        }

        public static Complex operator *(Complex nr1, Complex nr2)
        {
            return new Complex((nr1.parte_reala * nr2.parte_reala) - (nr1.parte_imaginara * nr2.parte_imaginara), (nr1.parte_reala * nr2.parte_imaginara) + (nr2.parte_reala * nr1.parte_imaginara));
        }

        public static Complex operator ^(Complex nr1, int power)
        {
            Complex aux = new Complex();

            for (int i = 1; i < power; i++)
            {
                aux += nr1 * nr1;
            }
            return aux;
        }

        public void FormaTrigonometrica()
        {
            float teta = (float)Math.Atan(parte_imaginara / parte_reala);
            float r = (float)Math.Sqrt((parte_reala * parte_reala) + (parte_imaginara * parte_imaginara));

            Console.WriteLine("Forma trigonometrica: x= {0}*(cos({1}) + i*sin({2}))", r, teta, teta);
        }

        virtual public string RidicareaCuFormaTrig(Complex idx, int putere)
        {
            return "-";
        }

        public override string ToString()
        {
            if (parte_imaginara < 0)
            {
                 return "z= " + parte_reala + "-" + parte_imaginara + "*i";
            }
            else return "z= " + parte_reala + "+" + parte_imaginara + "*i";
        }
    }
}