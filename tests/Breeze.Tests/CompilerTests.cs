using Xunit.Abstractions;

namespace Breeze.Tests;

public class CompilerTests
{
    [Fact]
    public async void Compile_ReturnsCss()
    {
        var config = Config.Default();
        var compiler = new Compiler();

        var template = await TemplateLoader.Load("template");

        Assert.NotNull(template);
        Assert.NotEmpty(template);

        var css = compiler.Compile(template, config);

        Assert.NotNull(css);
        Assert.NotEmpty(css);
    }

    [Fact]
    public async void Compile_EscapesSpecialCharactersInSelectors()
    {
        var config = Config.Default();
        var compiler = new Compiler();

        var template = await TemplateLoader.Load("template");
        var css = compiler.Compile(template, config);

        Assert.Contains(".basis-1\\/2", css);
        Assert.Contains(".h-1\\/2", css);
        Assert.Contains(".w-1\\/2", css);
        Assert.Contains(".p-0\\.5", css);

        Assert.DoesNotContain(".basis-1/2 ", css);
        Assert.DoesNotContain(".h-1/2 ", css);
        Assert.DoesNotContain(".p-0.5 ", css);
    }
}
