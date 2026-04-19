using HandlebarsDotNet;

namespace Breeze;

public class Compiler
{
    static Compiler()
    {
        Handlebars.RegisterHelper("cssEscape", (writer, context, parameters) =>
        {
            var value = parameters.Length > 0 ? parameters[0]?.ToString() ?? "" : "";
            writer.WriteSafeString(CssEscape.Identifier(value));
        });
    }

    public string Compile(string templateSource, Config config)
    {
        var template = Handlebars.Compile(templateSource);

        var data = new { config = config };

        var result = template(data);

        return result;
    }
}
