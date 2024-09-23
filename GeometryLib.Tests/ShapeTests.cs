namespace GeometryLib.Tests;
using Xunit;
using GeometryLib;

public class ShapeTests
{
    [Fact]
    public void Circle_Area_Calculation()
    {
        var circle = new Circle(5);
        Assert.Equal(78.53981633974483, circle.CalculateArea(), precision: 10);
    }

    [Fact]
    public void Triangle_Area_Calculation()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.Equal(6, triangle.CalculateArea(), precision: 10);
    }

    [Fact]
    public void Triangle_IsRightAngled()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.True(triangle.IsRightAngled());
            
        var nonRightTriangle = new Triangle(5, 5, 6);
        Assert.False(nonRightTriangle.IsRightAngled());
    }

    [Fact]
    public void Invalid_Triangle_Throws_Exception()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 3));
    }

    [Fact]
    public void Invalid_Circle_Throws_Exception()
    {
        Assert.Throws<ArgumentException>(() => new Circle(-1));
    }
}