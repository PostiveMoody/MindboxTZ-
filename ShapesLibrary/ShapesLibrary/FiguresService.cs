using ShapesLibrary.Shapes;

namespace ShapesLibrary
{
    /// <summary>
    /// Сервис вычисления площади любой фигуры
    /// </summary>
    /// <remarks>Паттерн Стратегия</remarks>
    public class FiguresService
    {
        public double CalcSquare(ShapeBase shape)
        {
            return shape.GetSquare();
        }

        public Circle CreateCircle(float radius)
        {
            return new Circle(radius);
        }

        /// <summary>
        /// Создать треугольник.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public Triangle CreateTriangle(double a, double b, double c)
        {
            return new Triangle(a, b, c);
        }

        /// <summary>
        /// Создать прямоугольный треугольник.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public Triangle CreateRectangularTriangle(double a, double b)
        {
            return new Triangle(a, b);
        }

        public double SumOfSquares(IEnumerable<ShapeBase> shapes) {
            return shapes.Sum(s => s.GetSquare());
        }
    }
}
