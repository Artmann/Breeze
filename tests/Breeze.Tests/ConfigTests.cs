namespace Breeze.Tests;

public class ConfigTests
{
    [Fact]
    public void Merge_EmptyConfigs_ReturnsEmptyConfig()
    {
        var config1 = new Config();
        var config2 = new Config();

        var result = config1.Merge(config2);

        Assert.Empty(result.spacing);
        Assert.Empty(result.width);
    }

    [Fact]
    public void Merge_ConfigsWithDifferentValues_ReturnsMergedConfig()
    {
        var config1 = new Config
        {
            spacing = new Dictionary<string, string> { { "small", "1rem" }, { "medium", "2rem" } },
            width = new Dictionary<string, string> { { "thin", "100px" }, { "thick", "200px" } }
        };
        var config2 = new Config
        {
            spacing = new Dictionary<string, string>
            {
                { "large", "4rem" },
                { "extra large", "8rem" }
            },
            width = new Dictionary<string, string> { { "thicc", "400px" } }
        };

        var result = config1.Merge(config2);

        Assert.Equal("1rem", result.spacing["small"]);
        Assert.Equal("2rem", result.spacing["medium"]);
        Assert.Equal("4rem", result.spacing["large"]);
        Assert.Equal("8rem", result.spacing["extra large"]);

        Assert.Equal("100px", result.width["thin"]);
        Assert.Equal("200px", result.width["thick"]);
        Assert.Equal("400px", result.width["thicc"]);
    }
}
