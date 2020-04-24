using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumereComplexe
{
    class ComplexD: Complex
    {
        Complex aux = new Complex(12, 13);
        double r;
        double teta;

        public ComplexD()
        {
            parte_reala = 0;
            parte_imaginara = 0;
        }
        public ComplexD(double p_reala)
        {
            parte_reala = p_reala;
            parte_imaginara = 0;
        }
        public ComplexD(double p_reala, double p_imaginara)
        {
            parte_imaginara = p_imaginara;
            parte_reala = p_reala;
        }

    
        public void Dist(List<Complex> multime)
        {
            
            double min = 9999;
            double dist;
            Complex[] v = multime.ToArray();

            for (int i = 0; i < v.Length; i++)
            {
                dist = Math.Sqrt(Math.Pow(aux.ParteReala() - v[i].ParteReala(), 2) + Math.Pow(aux.ParteImaginara() - v[i].ParteImaginara(), 2));
                if (dist < min)
                    min = dist;
            }

            Console.WriteLine("Distanta minima este:{0}", min);
        }

        public override string RidicareaCuFormaTrig(Complex nr,int putere)
        {
            Complex aux = new Complex();

            for (int i = 1; i < putere; i++)
            {
                aux += nr * nr;
            }

            teta =Math.Atan(aux.ParteImaginara() / aux.ParteReala());
            r =Math.Sqrt((aux.ParteReala() * aux.ParteReala()) + (aux.ParteImaginara() * aux.ParteImaginara()));

            return "Ridicarea la putere sub forma trigonometrica: x= " + r + "*(cos(" + teta + ") + i*sin(" + teta + "))";
        }


    }
}
