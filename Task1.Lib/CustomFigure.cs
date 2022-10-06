using System.Numerics;
using Task1.Lib;
using Task1.Lib.DefaultFigures;

public class CustomFigure : ICalculatableFigure
{
    private List<Vector2> _points;
    private float? _calculatedSquare = null;

    public CustomFigure()
    {
        _points = new List<Vector2>();
    }


    public void AddPoint(float x, float y)
    {
        _calculatedSquare = null;
        _points.Add(new Vector2(x, y));
    }


    public List<Triangle> Triangulate()
    {
        var zeroPoint = _points[0];
        var previousPoint = _points[1];
        var triangles = new List<Triangle>();

        foreach (var currentPoint in _points.GetRange(2, _points.Count - 2))
        {
            var distanceFromZeroToPrevious = (previousPoint - zeroPoint).Length();
            var distanceFromZeroToCurrent = (currentPoint - zeroPoint).Length();
            var distaceFromPreviousToCurrent = (currentPoint - previousPoint).Length();

            triangles.Add(new Triangle(distaceFromPreviousToCurrent, distanceFromZeroToCurrent, distanceFromZeroToPrevious));

            previousPoint = currentPoint;
        }

        return triangles;
    }


    public float CalculateSquare()
    {
        if (_calculatedSquare != null)
        {
            return (float) _calculatedSquare;
        }

        _calculatedSquare = 0;
        var triangles = Triangulate();
        
        foreach (var triangle in triangles)
        {
            _calculatedSquare += triangle.CalculateSquare();
        }

        return (float) _calculatedSquare;
    }
}