using System.Data.SqlTypes;
using Task1.Lib.Exceptions;

namespace Task1.Lib.DefaultFigures;

public class Triangle : ICalculatableFigure
{
    private float _edgeA;
    private float _edgeB;
    private float _edgeC;
    private float? _calculatedSquare;


    public Triangle(float edgeA, float edgeB, float edgeC)
    {
        Initialize(edgeA, edgeB, edgeC);
    }

    public float CalculateSquare()
    {
        if (_calculatedSquare != null)
        {
            return (float) _calculatedSquare;
        }

        var halfPerimeter = (_edgeA + _edgeB + _edgeC) / 2;
        var product = halfPerimeter * (halfPerimeter - _edgeA) * (halfPerimeter - _edgeB) * (halfPerimeter - _edgeC);
        var triangeSquare = MathF.Sqrt(product);

        _calculatedSquare = triangeSquare;
        return triangeSquare;
    }

    public void Initialize(float edgeA, float edgeB, float edgeC)
    {
        if (edgeA < 0 || edgeB < 0 || edgeC < 0)
        {
            throw new FormatException("Arguments must be positive or zero");
        }

        //сумма двух любых сторон треугольника должна быть больше третьей
        if (!(edgeA + edgeB > edgeC) || !(edgeB + edgeC > edgeA) || !(edgeC + edgeA > edgeB))
        {
            throw new FigureNotPossibleException();
        }

        _edgeA = edgeA;
        _edgeB = edgeB;
        _edgeC = edgeC;
        _calculatedSquare = null;
    }
}