namespace Breeze;

public class TemplateLoader
{
  public static async Task<string> Load(string name)
  {
    var templatePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"{name}.hbs");

    var templateSource = await File.ReadAllTextAsync(templatePath);

    return templateSource;
  }
}
