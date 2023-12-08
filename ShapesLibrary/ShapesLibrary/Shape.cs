namespace ShapesLibrary
{
    /// <summary>
    /// Базовый класс - Фигуры.
    /// </summary>
    /// <remarks>Буду использовать шаблонный метод</remarks>
    public abstract class ShapeBase
    {
        /// <summary>
        /// Получить площадь фигуры!
        /// </summary>
        /// <returns></returns>
        public double GetSquare()
        {
            if (_square == null)
                _square = CalculateArea();

            return _square.Value;
        }

        protected abstract double CalculateArea();

        protected abstract double CalculatePerimeter();

        protected double? _square;

        protected double? _perimeter;

        protected void FigureChanged()
        {
            _square = null;
            _perimeter = null;
        }
    }
}