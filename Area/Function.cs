using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    public static class Function
    {
        public static double ReadDoubleFromConsole(string message)
        {
            double value;
            bool isValid = false;

            do
            {
                Console.WriteLine(message);
                string input = Console.ReadLine();

                isValid = double.TryParse(input, out value);

                if (!isValid)
                {
                    Console.WriteLine("Некорректный ввод. Попробуйте еще раз.");
                }
            }
            while (!isValid);

            return value;
        }

        public static bool IsRightTriangle(double side1, double side2, double side3)
        {
            double maxSide = Math.Max(side1, Math.Max(side2, side3));

            if (maxSide == side1)
            {
                return Math.Pow(maxSide, 2) == Math.Pow(side2, 2) + Math.Pow(side3, 2);
            }
            else if (maxSide == side2)
            {
                return Math.Pow(maxSide, 2) == Math.Pow(side1, 2) + Math.Pow(side3, 2);
            }
            else
            {
                return Math.Pow(maxSide, 2) == Math.Pow(side1, 2) + Math.Pow(side2, 2);
            }
        }

        public static bool IsTriangleValid(double side1, double side2, double side3)
        {
            if (side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
