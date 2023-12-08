namespace ShapesLibrary.Shapes
{
    public class Circle : ShapeBase
    {
        public Circle(double radius)
        {
            if (radius == default)
                throw new ArgumentException(nameof(radius));

            _radius = radius;
        }

        public double Radius
        {
            get
            {
                return _radius;
            }
            set 
            {
                if(_radius == value)
                    return;

                _radius = value;

                base.FigureChanged();
            }
        }
  
        protected override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        protected override double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }

        private double _radius;

        public override bool Equals(object obj) => obj is Circle circle && Radius == circle?.Radius;
        public override int GetHashCode() => Radius.GetHashCode();
    }
}
