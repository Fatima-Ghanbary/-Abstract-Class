using Shapes;

public class Squre : Shape
{
    /// <summary>
    /// length of Squre Side
    /// </summary>
    public int SideLength { get; set; }
    /// <summary>
    /// Calculate Area of Squre=a*a
    /// </summary>
    /// <returns></returns>
    public override double Area()
    {
        return SideLength * SideLength;   
    }
    /// <summary>
    /// calculate Circumference Of squre=4*a
    /// </summary>
    /// <returns></returns>
    public override double Circumference()
    {
        return 4 * SideLength;
    }
}
