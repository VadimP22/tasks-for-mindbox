using Task1.Lib.DefaultFigures;
using Task1.Lib.Exceptions;

namespace Task1.Tests;

public class TestDefaultFigures
{
    [Fact]
    public void TestCircleSquareCalculation()
    {
        var radius = 10f;

        var circle = new Circle(radius);
        Assert.Equal(MathF.PI * radius * radius, circle.CalculateSquare());
    }


    [Fact]
    public void TestTriangleSquareCalculation()
    {
        var edgeA = 3f;
        var edgeB = 4f;
        var edgeC = 5f;
        var expectedSquare = 6f;

        var triangle = new Triangle(edgeA, edgeB, edgeC);
        Assert.Equal(expectedSquare, triangle.CalculateSquare());
    }


    [Fact]
    public void TestImpossibleTriangle()
    {
        try
        {
            var triangle = new Triangle(1, 2, 3);
        }
        catch (FigureNotPossibleException)
        {
            Assert.True(true);
            return;
        }

        Assert.True(false);
    }
}