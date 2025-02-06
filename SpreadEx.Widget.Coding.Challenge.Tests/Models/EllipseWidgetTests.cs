using FluentAssertions;
using SpreadEx.Widget.Coding.Challenge.Models;

namespace SpreadEx.Widget.Coding.Challenge.Tests.Models;

public class EllipseWidgetTests
{
    [Fact]
    public void CircleWidget_HorizontalDiameterIsNotPositive_ThrowArgumentException()
    {
        Action act = () => new EllipseWidget(1, 2, -3, 4);

        act.Should().Throw<ArgumentException>();
    }
    
    [Fact]
    public void CircleWidget_HorizontalDiameterIsPositive_CreatesCircleWidget()
    {
        Action act = () => new EllipseWidget(1, 2, 3, 4);

        act.Should().NotThrow();
    }
    
    [Fact]
    public void CircleWidget_VerticalDiameterIsNotPositive_ThrowArgumentException()
    {
        Action act = () => new EllipseWidget(1, 2, 3, -4);

        act.Should().Throw<ArgumentException>();
    }
    
    [Fact]
    public void CircleWidget_VerticalDiameterIsPositive_CreatesCircleWidget()
    {
        Action act = () => new EllipseWidget(1, 2, 3, 4);

        act.Should().NotThrow();
    }
    
    [Fact]
    public void ToString_WidgetHasValidDetails_ReturnsStringWithCorrectDetails()
    {
        var widget = new EllipseWidget(1, 1, 20, 40);

        widget.ToString().Should().Be("Ellipse (1,1) diameterH = 20 diameterV = 40");
    }
}