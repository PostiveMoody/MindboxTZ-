using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapesLibrary.Shapes;

namespace ShapesLibrary.Tests
{
    [TestClass()]
    public class FiguresServiceTests
    {
        private FiguresService _service;

        [TestInitialize]
        public void TestInitialize()
        {
            _service = new FiguresService();
        }


        /// <summary>
        /// Naming Convention - ClassName_MethodName_ExpectedResult
        /// </summary>
        [TestMethod("CreateCircle_PositiveScenario")]
        public void FiguresService_CreateCircle_CircleCreated()
        {
            // Arrange
            var radius = 5;
            Circle circle = new Circle(radius);

            // Act 
            var actualResult = _service.CreateCircle(radius);

            // Assert
            Assert.AreEqual(circle, actualResult);
        }

        /// <summary>
        /// Naming Convention - ClassName_MethodName_ExpectedResult
        /// </summary>
        [ExpectedException(typeof(ArgumentException))]
        [TestMethod("CreateCircle_NegaitiveScenario")]
        public void FiguresService_CreateCircle_CircleNotCreated()
        {
            // Arrange
            var radius = 0;

            // Act 
            _service.CreateCircle(radius);  
        }

        /// <summary>
        /// Naming Convention - ClassName_MethodName_ExpectedResult
        /// </summary>
        [TestMethod("CreateTriangle_PositiveScenario")]
        public void FiguresService_CreateTriangle_TriangleCreated()
        {
            // Arrange
            double a = 5;
            double b = 6;
            double c = 7;
            Triangle triangle = new Triangle(a, b, c);

            // Act 
            var actualResult =  _service.CreateTriangle(a, b, c);

            // Assert
            Assert.AreEqual(triangle, actualResult);
        }

        /// <summary>
        /// Naming Convention - ClassName_MethodName_ExpectedResult
        /// </summary>
        [ExpectedException(typeof(ArgumentException))]
        [TestMethod("CreateTriangle_NegaitiveScenario")]
        public void FiguresService_CreateTriangle_TriangleNotCreated()
        {
            // Arrange
            double a = 0;
            double b = 6;
            double c = 7;

            // Act 
            _service.CreateTriangle(a, b, c);
        }

        /// <summary>
        /// Naming Convention - ClassName_MethodName_ExpectedResult
        /// </summary>
        [TestMethod("CreateRectangularTriangle_PositiveScenario")]
        public void FiguresService_CreateRectangularTriangle_RectangularTriangleCreated()
        {
            // Arrange
            double a = 5;
            double b = 6;
            Triangle triangle = new Triangle(a, b);

            // Act 
            var actualResult = _service.CreateRectangularTriangle(a, b);

            // Assert
            Assert.AreEqual(triangle, actualResult);
        }

        /// <summary>
        /// Naming Convention - ClassName_MethodName_ExpectedResult
        /// </summary>
        [ExpectedException(typeof(ArgumentException))]
        [TestMethod("CreateTriangle_NegaitiveScenario")]
        public void FiguresService_CreateRectangularTrianglee_RectangularTriangleNotCreated()
        {
            // Arrange
            double a = 0;
            double b = 6;

            // Act 
            _service.CreateRectangularTriangle(a, b);
        }

        /// <summary>
        /// Naming Convention - ClassName_MethodName_ExpectedResult
        /// </summary>
        [TestMethod("SumOfSquares_PositiveScenario")]
        public void FiguresService_SumOfSquares_SumsAreEquals()
        {
            // Arrange
            double a = 5;
            double b = 6;
            Triangle triangle = new Triangle(a, b);
            var radius = 5;
            Circle circle = new Circle(radius);
            List<ShapeBase> shapes = new List<ShapeBase>() { triangle, circle };


            // Act 
            var actualTriangleResult = _service.CreateRectangularTriangle(a, b);
            var actualCircleResult = _service.CreateCircle(radius);
            var sumSquares = actualTriangleResult.GetSquare() + actualCircleResult.GetSquare();

            // Assert
            Assert.AreEqual(sumSquares, _service.SumOfSquares(shapes));
        }
    }
}