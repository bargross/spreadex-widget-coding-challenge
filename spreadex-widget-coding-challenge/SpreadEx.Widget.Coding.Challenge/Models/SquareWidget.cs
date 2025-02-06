using SpreadEx.Widget.Coding.Challenge.Models.Base;
using SpreadEx.Widget.Coding.Challenge.Validation;

namespace SpreadEx.Widget.Coding.Challenge.Models;

public class SquareWidget: BaseWidget
{
    private int Width { get; set; }
    
    public SquareWidget(int xCoordinate, int yCoordinate, int width) : base("Square",
        xCoordinate, yCoordinate)
    {
        Guard.IsValidHeight(width);
        
        Width = width;        
    }
    
    public override string ToString()
    {
        return $"{base.ToString()} size={Width}";
    }
}