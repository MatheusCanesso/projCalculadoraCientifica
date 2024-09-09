using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjCalcCientifica
{
    internal class Calcula
    {
        public double calcular (double n1, double n2,string op)
        {
            if (op == "+")
            {
         
                Double t = n1 + n2;
                return t;
            }
            else if (op == "-")
            {
                Double t = n1 - n2;
                return t;
            }
            else if (op == "*")
            {
                
                Double t = n1 * n2;
               return t;
            }
            else
            {
                
                Double t = n1 / n2;
                return t;
            }
        }

        public double seno(double n1)
        {
            
            double rad = (n1 * Math.PI) / 180;
            return Math.Sin(rad);
            
        }

        public double cosseno (double n1)
        {

            double rad = (n1 * Math.PI) / 180;
            return Math.Cos(rad);

        }

        public string decbin(int dec)
        {
            return Convert.ToString(dec, 2);
        }

        public string bindec (string bin)
        {

                int dec = Convert.ToInt32(bin, 2);
                return dec.ToString();

        }

    } // fim classe
}
