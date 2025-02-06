using FluentAssertions;
using SpreadEx.Widget.Coding.Challenge.Models;

namespace SpreadEx.Widget.Coding.Challenge.Tests.Models;

public class TextboxWidgetTests
{
    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData("   ")]
    public void TextboxWidget_TextIsInvalid_ThrowArgumentException(string text)
    {
        Action act = () => new TextboxWidget(text, 1, 1, 1, 2);

        act.Should().Throw<ArgumentException>().WithMessage("Value cannot be empty, null or whitespace.");
    }
    
    [Fact]
    public void TextboxWidget_WidthIsNotPositive_ThrowArgumentException()
    {
        Action act = () => new TextboxWidget("some text", 1, 1, -1, 2);

        act.Should().Throw<ArgumentException>().WithMessage("width must be a positive number.");
    }
    
    [Fact]
    public void TextboxWidget_WidthIsPositive_CreatesCircleWidget()
    {
        Action act = () => new TextboxWidget("some text",1, 1, 0, 1);

        act.Should().NotThrow();
    }
    
    [Fact]
    public void TextboxWidget_HeightIsNotPositive_ThrowArgumentException()
    {
        Action act = () => new TextboxWidget("some text",1, 1, 1, -2);

        act.Should().Throw<ArgumentException>().WithMessage("height must be a positive number.");
    }
    
    [Fact]
    public void TextboxWidget_HeightIsPositive_CreatesCircleWidget()
    {
        Action act = () => new TextboxWidget("some text",1, 1, 3, 4);

        act.Should().NotThrow();
    }
    
    [Fact]
    public void ToString_WidgetHasValidDetails_ReturnsStringWithCorrectDetails()
    {
        var widget = new TextboxWidget("some other text ;)", 1, 1, 2, 4);

        widget.ToString().Should().Be("Textbox (1,1) width=2 height=4 Text=some other text ;)");
    }
}