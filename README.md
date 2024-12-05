# Breeze

Breeze is a .NET Core tool that creates Tailwind-like utility classes specifically for Unity's UI Toolkit. It generates a `Breeze.uss` file—a Unity stylesheet—that you can easily integrate into your project. While we aim for compatibility with Tailwind CSS, note that not all CSS properties are supported due to the limitations of Unity's UI Toolkit.

To learn more about available class names and their usage, refer to the [Tailwind CSS documentation](https://tailwindcss.com/docs/).

## Releases

Each release provides prebuilt executables for Windows, Mac, and Linux. These executables let you generate the `Breeze.uss` file with ease. Additionally, every release includes the `Breeze.uss` file generated using the default configuration, so you can start using it immediately.

## Development

To work on the project locally, clone the repository and use the following commands:

- Restore dependencies using `dotnet restore`.
- Run the tool with `dotnet run --project .\src\Breeze\`.
- Execute tests to ensure everything works as expected with `dotnet test`.

Feel free to explore, modify, and enhance the codebase during your development process.

## Contributing

We welcome and appreciate your contributions! Whether it's reporting issues, suggesting features, or submitting pull requests, your input helps improve Breeze. Join the project and help us make utility-first styling accessible for Unity developers everywhere.
