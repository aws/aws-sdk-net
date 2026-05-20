namespace SmithyDotNet.Generator;

/// <summary>
/// Thrown when the generator encounters a model or configuration error that prevents code generation.
/// </summary>
public class GeneratorException : Exception
{
    public GeneratorException() { }
    public GeneratorException(string message) : base(message) { }
    public GeneratorException(string message, Exception innerException) : base(message, innerException) { }
}
