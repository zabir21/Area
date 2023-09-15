namespace Area
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool isExited = false;
            
            do
            {
                Console.WriteLine("Выберите фигуру для вычисления площади:" +
                    "\n1. Квадрат" +
                    "\n2. Круг" +
                    "\n3. Прямоугольный Треугольник" +
                    "\n4. Прямоугольник" +
                    "\n5. Треугольник" +
                    "\n6. Выйти");

                string input = Console.ReadLine();
                int choice;

                bool isValidInput = int.TryParse(input, out choice);

                Figure RightTriangle;

                if (isValidInput)
                {
                    switch (choice)
                    {
                        case 1:
                            double squareSide = Function.ReadDoubleFromConsole("Введите длину стороны квадрата:");
                            Figure square = new Square(squareSide);
                            var squareArea = square.GetArea();
                            Console.WriteLine($"Площадь квадрата со стороной {squareSide} равна: {squareArea}");
                            break;
                        case 2:
                            double circleRadius = Function.ReadDoubleFromConsole("Введите радиус круга:");
                            Figure circle = new Circle(circleRadius);
                            var circleArea = circle.GetArea();
                            Console.WriteLine($"Площадь круга с радиусом {circleRadius} равна: {circleArea}");
                            break;
                        case 3:
                            double righttriangleA = Function.ReadDoubleFromConsole("Введите сторону треугольника:");
                            double righttriangleB = Function.ReadDoubleFromConsole("Введите сторону треугольника:");
                            double righttriangleC = Function.ReadDoubleFromConsole("Введите сторону треугольника:");

                            bool isRightTriangle = Function.IsRightTriangle(righttriangleA, righttriangleB, righttriangleC);

                            bool isRightTriangleValid = Function.IsTriangleValid(righttriangleA, righttriangleB, righttriangleC);

                            if (isRightTriangleValid)
                            {
                                Console.WriteLine("Треугольник можно построить.");
                            }
                            else
                            {
                                Console.WriteLine("Треугольник нельзя построить.");
                                break;
                            }

                            if (isRightTriangle)
                            {
                                Console.WriteLine("Треугольник является прямоугольным.");
                            }
                            else
                            {
                                Console.WriteLine("Треугольник не является прямоугольным.");
                            }

                            Figure righttriangle = new RightTriangle(righttriangleA, righttriangleB, righttriangleC);
                            var rightTriangleArea = righttriangle.GetArea();
                            Console.WriteLine($"Площадь треугольника с основанием {righttriangleA}, {righttriangleB}, {righttriangleC}  равна: {rightTriangleArea}");
                            break;

                        case 4:
                            double length = Function.ReadDoubleFromConsole("Введите длину прямоугольника:");
                            double width = Function.ReadDoubleFromConsole("Введите ширину прямоугольника:");
                            Figure rectangle = new Rectangle(length, width);
                            var rectangleArea = rectangle.GetArea();
                            Console.WriteLine($"Площадь прямоугольника со сторонами {length},{width} равна: {rectangleArea}");
                            break;
                        case 5:
                            double triangleA = Function.ReadDoubleFromConsole("Введите сторону треугольника:");
                            double triangleB = Function.ReadDoubleFromConsole("Введите сторону треугольника:");
                            double triangleC = Function.ReadDoubleFromConsole("Введите сторону треугольника:");

                            bool isTriangleValid = Function.IsTriangleValid(triangleA, triangleB, triangleC);

                            if (isTriangleValid)
                            {
                                Console.WriteLine("Треугольник можно построить.");
                            }
                            else
                            {
                                Console.WriteLine("Треугольник нельзя построить.");
                                break;
                            }

                            Figure triangle = new Triangle(triangleA, triangleB, triangleC);
                            var triangleArea = triangle.GetArea();
                            Console.WriteLine($"Площадь треугольника со стронами {triangleA}, {triangleB}, {triangleC} равна: {triangleArea}");
                            break;
                        case 6:
                            Console.WriteLine("Вы выбрали Выйти");
                            isExited = true;
                            break;
                        default:
                            Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
                }
            }
            while (!isExited);

            Console.ReadLine();
        }
    }
}