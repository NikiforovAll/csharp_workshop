#nullable enable

public class Square
{
    public double Side { get; init; }
}

public class Circle
{
    public double Radius { get; init; }
}

public class Rectangle
{
    public double Length { get; init; }
    public double Height { get; init; }

    public void Deconstruct(out double length, out double height) =>
        (length, height) = (Length, Height);
}

public class Triangle
{
    public double Base { get; init; }
    public double Height { get; init; }
}
