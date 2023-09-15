using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    public class Rectangle : Figure
    {
        public double SideA { get; set; }
        public double SideB { get; set; }

        public Rectangle(double sideA, double sideB)
        {
            SideA = sideA;
            SideB = sideB;
        }

        public override double GetArea()
        {
            return SideA * SideB;
        }
    }
}
