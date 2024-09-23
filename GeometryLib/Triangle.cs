namespace GeometryLib;

public class Triangle : IShape
{
    private readonly double _sideA;
    private readonly double _sideB;
    private readonly double _sideC;

    public Triangle(double sideA, double sideB, double sideC)
    {
        if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            throw new ArgumentException("Стороны треугольника должны быть положительными.");

        _sideA = sideA;
        _sideB = sideB;
        _sideC = sideC;

        if (!IsValidTriangle())
            throw new ArgumentException("Стороны не могут образовать треугольник.");
    }
    
    public double CalculateArea()
    {
        double semiPerimeter = (_sideA + _sideB + _sideC) / 2;
        return Math.Sqrt(semiPerimeter * (semiPerimeter - _sideA) * (semiPerimeter - _sideB) * (semiPerimeter - _sideC));
    }
    
    public bool IsRightAngled()
    {
        double[] sides = { _sideA, _sideB, _sideC };
        Array.Sort(sides);
        return Math.Abs(Math.Pow(sides[2], 2) - (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2))) < 1e-10;
    }
    
    private bool IsValidTriangle()
    {
        return (_sideA + _sideB > _sideC) && (_sideA + _sideC > _sideB) && (_sideB + _sideC > _sideA);
    }
}