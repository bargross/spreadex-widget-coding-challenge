using SpreadEx.Widget.Coding.Challenge.Models.Base;
using SpreadEx.Widget.Coding.Challenge.Validation;

namespace SpreadEx.Widget.Coding.Challenge.Models;

public class CircleWidget: BaseWidget
{
    private int Diameter { get; set; }
    
    public CircleWidget(int xCoordinate, int yCoordinate, int diameter) : base("Circle", xCoordinate,
        yCoordinate)
    {
        Guard.IsValidDiameter(diameter);

        Diameter = diameter;
    }


    public override string ToString()
    {
        return $"{base.ToString()} size={Diameter}";
    }
}