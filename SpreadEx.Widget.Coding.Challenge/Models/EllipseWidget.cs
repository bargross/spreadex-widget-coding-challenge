using SpreadEx.Widget.Coding.Challenge.Models.Base;
using SpreadEx.Widget.Coding.Challenge.Validation;

namespace SpreadEx.Widget.Coding.Challenge.Models;

public class EllipseWidget: BaseWidget
{
    private int HDiameter { get; set; }
    private int VDiameter { get; set; }

    public EllipseWidget(int xCoordinate, int yCoordinate, int hDiameter, int vDiameter): base("Ellipse", xCoordinate, yCoordinate)
    {
        Guard.IsValidDiameter(hDiameter);
        Guard.IsValidDiameter(vDiameter);
            
        HDiameter = hDiameter;
        VDiameter = vDiameter;
    }

    public override string ToString()
    {
        return $"{base.ToString()} diameterH = {HDiameter} diameterV = {VDiameter}";
    }
}