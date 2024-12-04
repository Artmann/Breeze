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
}
