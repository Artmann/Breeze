using Breeze;

var templatePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "template.hbs");

var templateSource = await File.ReadAllTextAsync(templatePath);

var config = Config.Default();

var compiler = new Compiler();

var css = compiler.Compile(templateSource, config);

var currentDirectory = Directory.GetCurrentDirectory();
var outputPath = Path.Combine(currentDirectory, "Breeze.uss");

Console.WriteLine($"Writing the compiled CSS to {outputPath}");

await File.WriteAllTextAsync(outputPath, css);
