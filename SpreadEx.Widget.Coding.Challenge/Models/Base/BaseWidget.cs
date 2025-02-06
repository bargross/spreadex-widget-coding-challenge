namespace SpreadEx.Widget.Coding.Challenge.Models.Base;

public abstract class BaseWidget
{
    private string ShapeName { get; set; }
    private Coordinates Coordinates { get; set; }
    
    protected BaseWidget(string shapeName, int xCoordinate, int yCoordinate)
    {
        ShapeName = shapeName;
        Coordinates = new Coordinates
        {
            XCoordinate = xCoordinate,
            YCoordinate = yCoordinate
        };        
    }

    public override string ToString()
    {
        return $"{ShapeName} ({Coordinates.XCoordinate},{Coordinates.YCoordinate})";
    }
}