using Shapes;

public class Circle : Shape
{
    /// <summary>
    ///Radious Of Circle
    /// </summary>
    public double Radious { get; set; }
    /// <summary>
    /// Pi Number
    /// </summary>
    public double PiNumber { get; } = 3.14;
    /// <summary>
    /// calculate the Area Of Circle
    /// </summary>
    /// <returns></returns>
    public override double Area()
    {
        return PiNumber*(Radious * Radious);
    }

    public override double Circumference()
    {
        return (2*PiNumber)* Radious;
    }
}
