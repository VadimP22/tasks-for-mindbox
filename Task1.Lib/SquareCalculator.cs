using System.Security.Cryptography;
using Task1.Lib.DefaultFigures;

namespace Task1.Lib;

public class SquareCalculator
{
    private Circle _circle;
    private Triangle _triangle;


    public SquareCalculator()
    {
        _circle = new Circle(0);
        _triangle = new Triangle(0, 0, 0);
    }


    public float CalculateCircleSquare(float radius)
    {
        return 0;
    }


    public float CalculateTriangleSquare(float edgeA, float edgeB, float edgeC)
    {
        return 0;
    }


    public float CalculateCustomFigureSquare(ICalculatableFigure customFigure)
    {
        return 0;
    }
}