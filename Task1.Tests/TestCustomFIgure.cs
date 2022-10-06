using Task1.Lib.DefaultFigures;

public class TestCustomFigure
{
    [Fact]
    public void TestTriangulation()
    {
        // Это квадрат
        var fig = new CustomFigure();
        fig.AddPoint(0, 0);
        fig.AddPoint(0, 1);
        fig.AddPoint(1, 1);
        fig.AddPoint(1, 0);

        var triangles = fig.Triangulate();
        Assert.Equal(2, triangles.Count());

    }


    [Fact]
    public void TestCalculateSquare()
    {
        // Это прямоугольник
        var fig = new CustomFigure();
        fig.AddPoint(0, 0);
        fig.AddPoint(0, 2);
        fig.AddPoint(10, 2);
        fig.AddPoint(10, 0);

        var figureSquare = fig.CalculateSquare();
        Assert.Equal(20, (int) figureSquare);

    }
}