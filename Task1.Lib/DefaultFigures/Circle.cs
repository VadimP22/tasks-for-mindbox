namespace Task1.Lib.DefaultFigures;

public class Circle : ICalculatableFigure
{
    private float _radius;
    private float? _calculatedSquare;


    public Circle(float radius)
    {
        Initialize(radius);
    }


    public float CalculateSquare() 
    {
        if (_calculatedSquare != null)
        {
            return (float) _calculatedSquare;
        }
        var circleSquare = MathF.PI * _radius * _radius;

        _calculatedSquare = circleSquare;
        return circleSquare;
    }

    public void Initialize(float radius)
    {
        if (radius < 0)
        {
            throw new FormatException("Must be positive or zero");
        }

        _radius = radius;
        _calculatedSquare = null;
    }
}