using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Formatting;

namespace SmithyDotNet.Generator.Writers;

/// <summary>
/// Buffered C# source writer with brace-block and namespace helpers.
/// <para />
/// Internally appends to a <see cref="StringBuilder"/>; <see cref="ToFormattedString"/>
/// runs the buffer through the Roslyn formatter so callers don't have to
/// manage indentation or blank-line placement precisely.
/// </summary>
public class CodeWriter
{
    private const string IndentUnit = "    ";
    private readonly StringBuilder _buffer = new();
    private int _indent;

    /// <summary>
    /// Appends <paramref name="line"/> at the current indent followed by a newline.
    /// An empty argument emits a blank line (no indent).
    /// </summary>
    public CodeWriter WriteLine(string line = "")
    {
        if (line.Length == 0)
        {
            _buffer.AppendLine();
            return this;
        }

        for (var i = 0; i < _indent; i++)
        {
            _buffer.Append(IndentUnit);
        }

        _buffer.Append(line);
        _buffer.AppendLine();
        return this;
    }

    /// <summary>
    /// Emits <paramref name="header"/>, then <c>{</c>, executes <paramref name="body"/>,
    /// and closes with <paramref name="close"/>.
    /// </summary>
    public CodeWriter OpenBlock(string header, string close, Action body)
    {
        WriteLine(header);
        WriteLine("{");
        _indent++;
        body();
        _indent--;
        WriteLine(close);
        return this;
    }

    /// <summary>
    /// Emits <paramref name="header"/>, then <c>{</c>, executes <paramref name="body"/>,
    /// and closes with <c>}</c>.
    /// </summary>
    public CodeWriter OpenBlock(string header, Action body)
    {
        return OpenBlock(header, "}", body);
    }

    /// <summary>
    /// Convenience for <see cref="OpenBlock(string, Action)"/> with a <c>namespace {ns}</c> header.
    /// </summary>
    public CodeWriter OpenNamespace(string ns, Action body)
    {
        return OpenBlock($"namespace {ns}", body);
    }

    /// <summary>
    /// Renders a runtime string value as a quoted, fully-escaped C# string literal, so a value
    /// containing a quote or backslash still produces compilable source.
    /// </summary>
    public static string Literal(string value) => SymbolDisplay.FormatLiteral(value, quote: true);

    /// <summary>
    /// Returns the buffered source after running it through the Roslyn formatter.
    /// </summary>
    public string ToFormattedString(CancellationToken cancellationToken = default)
    {
        var source = _buffer.ToString();
        var tree = CSharpSyntaxTree.ParseText(source, cancellationToken: cancellationToken);

        using var workspace = new AdhocWorkspace();
        var formatted = Formatter.Format(tree.GetRoot(cancellationToken), workspace, cancellationToken: cancellationToken);
        return formatted.ToFullString();
    }
}
