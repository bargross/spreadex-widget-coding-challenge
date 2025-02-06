using SpreadEx.Widget.Coding.Challenge.Validation;

namespace SpreadEx.Widget.Coding.Challenge.Models;

public class TextboxWidget: RectangleWidget
{
    public string Text { get; set; }

    public TextboxWidget(string text, int xCoordinate, int yCoordinate, int width, int height) : base(
        xCoordinate, yCoordinate, width, height, "Textbox")
    {
        Guard.ThrowIfNullEmptyOrWhiteSpace(text);
        
        Text = text;
    }
    
    public override string ToString()
    {
        return $"{base.ToString()} Text={Text}";
    }
}