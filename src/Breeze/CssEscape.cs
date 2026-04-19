using System.Text;

namespace Breeze;

public static class CssEscape
{
    public static string Identifier(string value)
    {
        var sb = new StringBuilder(value.Length);

        foreach (var c in value)
        {
            if (char.IsLetterOrDigit(c) || c == '-' || c == '_')
            {
                sb.Append(c);
            }
            else
            {
                sb.Append('\\').Append(c);
            }
        }

        return sb.ToString();
    }
}
