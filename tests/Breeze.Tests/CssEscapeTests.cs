namespace Breeze.Tests;

public class CssEscapeTests
{
    [Fact]
    public void Identifier_EscapesForwardSlash()
    {
        Assert.Equal("1\\/2", CssEscape.Identifier("1/2"));
    }

    [Fact]
    public void Identifier_EscapesPeriod()
    {
        Assert.Equal("0\\.5", CssEscape.Identifier("0.5"));
    }

    [Fact]
    public void Identifier_LeavesHyphenatedNamesUntouched()
    {
        Assert.Equal("slate-500", CssEscape.Identifier("slate-500"));
    }

    [Fact]
    public void Identifier_LeavesUnderscoresUntouched()
    {
        Assert.Equal("foo_bar", CssEscape.Identifier("foo_bar"));
    }

    [Fact]
    public void Identifier_ReturnsEmptyForEmptyInput()
    {
        Assert.Equal("", CssEscape.Identifier(""));
    }

    [Fact]
    public void Identifier_EscapesColonAndPercent()
    {
        Assert.Equal("hover\\:50\\%", CssEscape.Identifier("hover:50%"));
    }
}
