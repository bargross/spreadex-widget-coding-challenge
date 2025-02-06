using FluentAssertions;
using SpreadEx.Widget.Coding.Challenge.Layouts;
using SpreadEx.Widget.Coding.Challenge.Models;
using SpreadEx.Widget.Coding.Challenge.Models.Base;

namespace SpreadEx.Widget.Coding.Challenge.Tests.Layouts;

public class LayoutTests
{
    [Fact]
    public void AddWidget_WidgetIsNull_ThrowArgumentNullException()
    {
        var layout = new Layout();

        Action act = () => layout.AddWidget(null as BaseWidget);

        act.Should().Throw<ArgumentNullException>();
    }
    
    [Fact]
    public void AddWidget_WidgetIsValid_ThrowArgumentNullException()
    {
        var layout = new Layout();

        Action act = () => layout.AddWidget(new CircleWidget(1, 1, 5));

        act.Should().NotThrow();
        layout.HasWidgets.Should().BeTrue();
    }
}