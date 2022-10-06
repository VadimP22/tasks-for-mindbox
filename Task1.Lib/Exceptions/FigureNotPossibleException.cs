namespace Task1.Lib.Exceptions;

public class FigureNotPossibleException : Exception
{
    public override string Message => "Figure with given parameters not possible";
}