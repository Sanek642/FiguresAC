using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresAC
{
    public class Circle:Figures
    {
        private double radius;
        public double Radius
        {
            get { return radius; }
            set
            {
                if (radius < 0)
                    throw new ArgumentOutOfRangeException("Радиус должен быть больше нуля!!!");
                radius = value;
            }
        }

        public Circle() { }
        public Circle(double radius)
        {
            Radius = radius;
            Area = Math.PI * Math.Pow(radius, 2);
        }
    }
}
