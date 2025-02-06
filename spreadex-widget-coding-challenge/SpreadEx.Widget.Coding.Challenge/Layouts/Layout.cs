using SpreadEx.Widget.Coding.Challenge.Models.Base;

namespace SpreadEx.Widget.Coding.Challenge.Layouts;

public class Layout
{
    public bool HasWidgets => Widgets.Any();
    
    private List<BaseWidget> Widgets = new();

    public void AddWidget<TWidget>(TWidget widget) where TWidget : BaseWidget
    {
        if (widget == null)
        {
            throw new ArgumentNullException(nameof(widget));
        }
        
        Widgets.Add(widget);   
    }
    
    public void Render() => Console.WriteLine(string.Join(Environment.NewLine, GetWidgetsDetails()));
    
    private string[] GetWidgetsDetails()
    {
        return Widgets.Select(x => x.ToString()).ToArray();
    }
}