using Shapes;

public class Triangle : Shape
{
    /// <summary>
    /// Base of Triangle
    /// </summary>
    public int TriangleBase { get; set; }
    /// <summary>
    /// height of triangle
    /// </summary>
    public int Height { get; set; }
    /// <summary>
    ///  create method to calculate triangle Area
    /// </summary>
    /// <returns></returns>
    public override double Area()
    {
        return TriangleBase * Height;
    }
    /// <summary>
    /// create method to calculate triangle circumference
    /// </summary>
    /// <returns></returns>
    public override double Circumference()
    {
        return (TriangleBase + Height) * 2;
    }
}
