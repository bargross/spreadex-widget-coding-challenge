using FluentAssertions;
using SpreadEx.Widget.Coding.Challenge.Models;

namespace SpreadEx.Widget.Coding.Challenge.Tests.Models;

public class RectangleWidgetTests
{
    [Fact]
    public void RectangleWidget_WidthIsNotPositive_ThrowArgumentException()
    {
        Action act = () => new RectangleWidget(1, 1, -1, 2);

        act.Should().Throw<ArgumentException>().WithMessage("width must be a positive number.");
    }
    
    [Fact]
    public void RectangleWidget_WidthIsPositive_CreatesCircleWidget()
    {
        Action act = () => new RectangleWidget(1, 1, 0, 1);

        act.Should().NotThrow();
    }
    
    [Fact]
    public void RectangleWidget_HeightIsNotPositive_ThrowArgumentException()
    {
        Action act = () => new RectangleWidget(1, 1, 1, -2);

        act.Should().Throw<ArgumentException>().WithMessage("height must be a positive number.");
    }
    
    [Fact]
    public void RectangleWidget_HeightIsPositive_CreatesCircleWidget()
    {
        Action act = () => new RectangleWidget(1, 1, 3, 4);

        act.Should().NotThrow();
    }
    
    [Fact]
    public void ToString_WidgetHasValidDetails_ReturnsStringWithCorrectDetails()
    {
        var widget = new RectangleWidget(1, 1, 2, 4);

        widget.ToString().Should().Be("Rectangle (1,1) width=2 height=4");
    }
}