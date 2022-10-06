namespace Task1.Lib;

/// <summary>
/// Представляет геометрическую фигуру у которой можно вычислить площадь
/// </summary>
public interface ICalculatableFigure 
{
    /// <summary>
    /// Вычисляет площадь фигуры
    /// </summary>
    /// <returns>
    /// Площадь фигуры
    /// </returns>
    public float CalculateSquare();
}