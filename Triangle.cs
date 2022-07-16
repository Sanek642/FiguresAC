using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresAC
{
    public class Triangle:Figures
    {
        private double a;
        private double b;
        private double c;

        public double A
        {
            get { return a; }
            set
            {
                if (a < 0)
                    a = Math.Abs(a);
                else
                    a = value;
            }
        }
        public double B
        {
            get { return b; }
            set
            {
                if (b < 0)
                    b = Math.Abs(b);
                else
                    b = value;
            }
        }
        public double C
        {
            get { return c; }
            set
            {
                if (c < 0)
                    c = Math.Abs(c);
                else
                    c = value;
            }
        }

        public double Area { get; set; }
        public bool IsRect { get; set; }

        public Triangle() { }
        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;

            double p = (a + b + c) / 2;
            Area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            IsRect =  (a == Math.Sqrt(Math.Pow(b, 2) + Math.Pow(c, 2))
                      || b == Math.Sqrt(Math.Pow(a, 2) + Math.Pow(c, 2))
                      || c == Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)));
        }
    }
}
