using SpreadEx.Widget.Coding.Challenge.Models.Base;
using SpreadEx.Widget.Coding.Challenge.Validation;

namespace SpreadEx.Widget.Coding.Challenge.Models;

public class RectangleWidget: BaseWidget
{
    private int Width { get; set; }
    private int Height { get; set;  }
    
    public RectangleWidget(int xCoordinate, int yCoordinate, int width, int height, string shapeName = "Rectangle"): base(shapeName, xCoordinate, yCoordinate)
    {
        Guard.IsValidWidth(width);
        Guard.IsValidHeight(height);

        Width = width;
        Height = height;
    }
    
    public override string ToString()
    {
        return $"{base.ToString()} width={Width} height={Height}";
    }
}