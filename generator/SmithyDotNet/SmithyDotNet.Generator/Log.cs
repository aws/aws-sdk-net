namespace SmithyDotNet.Generator;

/// <summary>
/// Minimal generator-owned logging: informational output to stdout, warnings and errors to stderr.
/// </summary>
public static class Log
{
    public static void Info(string message) => Console.WriteLine(message);
    public static void Warn(string message) => Console.Error.WriteLine($"Warning: {message}");
    public static void Error(string message) => Console.Error.WriteLine($"Error: {message}");
}
