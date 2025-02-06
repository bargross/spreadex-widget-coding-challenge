using FluentAssertions;
using SpreadEx.Widget.Coding.Challenge.Models;

namespace SpreadEx.Widget.Coding.Challenge.Tests.Models;

public class CircleWidgetTests
{
    [Fact]
    public void CircleWidget_DiameterIsNotPositive_ThrowArgumentException()
    {
        Action act = () => new CircleWidget(1, 1, -1);

        act.Should().Throw<ArgumentException>();
    }
    
    [Fact]
    public void CircleWidget_DiameterIsPositive_CreatesCircleWidget()
    {
        Action act = () => new CircleWidget(1, 1, 2);

        act.Should().NotThrow();
    }
    
    [Fact]
    public void ToString_WidgetHasValidDetails_ReturnsStringWithCorrectDetails()
    {
        var widget = new CircleWidget(1, 1, 1);

        widget.ToString().Should().Be("Circle (1,1) size=1");
    }
}