using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    public class RightTriangle : Figure
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public RightTriangle(double aSide, double bSide, double cSide)
        {
            this.SideA = aSide;
            this.SideB = bSide;
            this.SideC = cSide;

            if (aSide * aSide + bSide * bSide == cSide * cSide)
            {
                //Console.WriteLine("Прямоугольный треугольник");
            }
        }
        public override double GetArea()
        {
            double p = GetPerimeter() / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }
        public double GetPerimeter()
        {
            return SideA + SideB + SideC;
        }
    }
}
