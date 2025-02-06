using FluentAssertions;
using SpreadEx.Widget.Coding.Challenge.Models;

namespace SpreadEx.Widget.Coding.Challenge.Tests.Models;

public class SquareWidgetTests
{
    [Fact]
    public void SquareWidget_WidthIsNotPositive_ThrowArgumentException()
    {
        Action act = () => new SquareWidget(1, 1, -1);

        act.Should().Throw<ArgumentException>();
    }
    
    [Fact]
    public void SquareWidget_WidthIsPositive_CreatesCircleWidget()
    {
        Action act = () => new SquareWidget(1, 1, 0);

        act.Should().NotThrow();
    }
    
    [Fact]
    public void ToString_WidgetHasValidDetails_ReturnsStringWithCorrectDetails()
    {
        var widget = new SquareWidget(1, 1, 2);

        widget.ToString().Should().Be("Square (1,1) size=2");
    }
}