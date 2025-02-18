using SpreadEx.Widget.Coding.Challenge.Models.Base;
using SpreadEx.Widget.Coding.Challenge.Validation;

namespace SpreadEx.Widget.Coding.Challenge.Models;

public class RectangleWidget: BaseWidget
{
    private int CurrentWidth { get; set; }
    private int CurrentHeight { get; set;  }

    public readonly List<(int width, int height, DateTime updateDate)> _updateHistory;
    
    public RectangleWidget(int xCoordinate, int yCoordinate, int width, int height, string shapeName = "Rectangle"): base(shapeName, xCoordinate, yCoordinate)
    {
        Guard.IsValidWidth(width);
        Guard.IsValidHeight(height);

        CurrentWidth = width;
        CurrentHeight = height;

        _updateHistory = new List<(int, int, DateTime)>();
        _updateHistory.Add((width, height, DateTime.UtcNow));
    }

    public void UpdateDimensions(int width, int height)
    {
        _updateHistory.Add((width, height, DateTime.UtcNow));
        
        CurrentWidth = width;
        CurrentHeight = height;
    }

    public void RemovePreviousUpdate() 
    {
        if (!_updateHistory.Any()) 
        {
            throw new OperationCanceledException();
        }

        if (_updateHistory.Count == 1)
        {
            throw new Exception("Cannot remove previous update as there are no updates before that!");
        }

        _updateHistory.RemoveAt(_updateHistory.Count - 1);

        var previousUpdate = _updateHistory[_updateHistory.Count - 1];

        CurrentWidth = previousUpdate.Item1;
        CurrentHeight = previousUpdate.Item2;
    }
    
    public override string ToString()
    {
        return $"{base.ToString()} width={Width} height={Height}";
    }
}