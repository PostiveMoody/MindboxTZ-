namespace ShapesLibrary.Shapes
{
    public class Triangle : ShapeBase
    {
        public Triangle(double a, double b, double c)
        {
            if (a == default)
                throw new ArgumentException(nameof(a));
            if (b == default)
                throw new ArgumentException(nameof(b));
            if (c == default)
                throw new ArgumentException(nameof(c));

            if (a + b <= c || a + c <= b || b + c <= a)
                throw new ArgumentException("Это не треугольник!");

            A = a;
            B = b;
            C = c;
        }

        /// <summary>
        /// Конструктор для создания прямоугольного треугольника
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <exception cref="ArgumentException"></exception>
        public Triangle(double a, double b)
        {
            if (a == default)
                throw new ArgumentException(nameof(a));
            if (b == default)
                throw new ArgumentException(nameof(b));
            
            var c = Math.Sqrt(a * a + b * b);

            if (a + b <= c || a + c <= b || b + c <= a)
                throw new ArgumentException("Это не треугольник!");

            A = a;
            B = b;
            C = c;
            IsRectangular = true;
        }

        private bool IsRectangular { get; set; }
        public double A
        {
            get
            {
                return _a;
            }
            set
            {
                if (_a == value)
                    return;

                _a = value; 
            }
        }

        private double _a;

        public double B
        {
            get
            {
                return _b;
            }
            set
            {
                if (_b == value)
                    return;

                _b = value;
                base.FigureChanged();
            }
        }
        private double _b;

        public double C
        {
            get
            {
                return _c;
            }
            set
            {
                if (_c == value)
                    return;

                _c = value;
                base.FigureChanged();
            }
        }
        private double _c;

        protected override double CalculateArea()
        {
            var halfPerimeter = CalculatePerimeter() / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - A) * (halfPerimeter - B) * (halfPerimeter - C));
        }

        protected override double CalculatePerimeter()
        {
            return A + B + C;
        }

        public override bool Equals(object obj) => obj is Triangle triangle 
            && A == triangle?.A && B == triangle?.B && C == triangle?.C;
        public override int GetHashCode() => 598075851 + A.GetHashCode();
    }
}
