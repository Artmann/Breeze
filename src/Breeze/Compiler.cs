using HandlebarsDotNet;

namespace Breeze;

public class Compiler
{
    public string Compile(string templateSource, Config config)
    {
        var template = Handlebars.Compile(templateSource);

        var data = new { config = config };

        var result = template(data);

        return result;
    }
}
