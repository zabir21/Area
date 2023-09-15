using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    public class Square : Figure
    {
        public double SideA { get; set; }

        public Square(double sideA)
        {
            SideA = sideA;
        }

        public override double GetArea()
        {
            return SideA * SideA;
        }
    }
}
