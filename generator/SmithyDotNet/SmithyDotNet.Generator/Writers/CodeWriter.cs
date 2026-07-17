using System.Text;
using System.Text.Json;
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
    private const string XmlIndentUnit = "  ";
    private readonly StringBuilder _buffer = new();
    private int _indent;
    private string _indentUnit = IndentUnit;

    /// <summary>
    /// Appends <paramref name="line"/> at the current indent followed by a newline.
    /// An empty argument emits a blank line (no indent). The indent unit is four
    /// spaces for C# and two spaces inside an <see cref="OpenXmlBlock(string, Action)"/>.
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
            _buffer.Append(_indentUnit);
        }

        _buffer.Append(line);
        _buffer.AppendLine();
        return this;
    }

    /// <summary>
    /// Writes a single line comment (format: // comment)
    /// </summary>
    public CodeWriter WriteComment(string comment = "")
    {
        return WriteLine($"// {comment}");
    }

    /// <summary>
    /// Runs <paramref name="body"/> with the indent increased one level, for content that nests
    /// without its own braces (e.g. statements under a <c>switch</c> case label).
    /// </summary>
    public CodeWriter Indent(Action body)
    {
        _indent++;
        try
        {
            body();
        }
        finally
        {
            _indent--;
        }

        return this;
    }

    /// <summary>
    /// Emits <c>&lt;{open}&gt;</c>, runs <paramref name="body"/> with the indent increased one
    /// level (two spaces per level), then emits <c>&lt;/{closeTag}&gt;</c>. Use when the opening tag
    /// carries attributes (e.g. <c>foo bar="x"</c>) but the close is just the element name.
    /// For container elements only; self-closing/leaf elements are written directly with
    /// <see cref="WriteLine"/>.
    /// </summary>
    public CodeWriter OpenXmlBlock(string open, string closeTag, Action body)
    {
        var previousIndentUnit = _indentUnit;
        _indentUnit = XmlIndentUnit;
        WriteLine($"<{open}>");
        _indent++;
        try
        {
            body();
        }
        finally
        {
            _indent--;
            WriteLine($"</{closeTag}>");
            _indentUnit = previousIndentUnit;
        }

        return this;
    }

    /// <summary>
    /// Emits <c>&lt;{tag}&gt;</c>, runs <paramref name="body"/> with the indent increased one
    /// level (two spaces per level), then emits the matching <c>&lt;/{tag}&gt;</c>. For container
    /// elements only; self-closing/leaf elements are written directly with <see cref="WriteLine"/>.
    /// </summary>
    public CodeWriter OpenXmlBlock(string tag, Action body)
    {
        return OpenXmlBlock(tag, tag, body);
    }

    /// <summary>
    /// Emits <paramref name="openLine"/> verbatim (caller supplies the full <c>&lt;Tag ...&gt;</c>),
    /// runs <paramref name="body"/> indented, then emits <c>&lt;/{closeTag}&gt;</c>. Use this when
    /// the opening tag contains attributes with quotes — callers can pass a raw string literal
    /// without escaping.
    /// </summary>
    public CodeWriter WriteXmlBlock(string openLine, string closeTag, Action body)
    {
        var previousIndentUnit = _indentUnit;
        _indentUnit = XmlIndentUnit;
        WriteLine(openLine);
        _indent++;
        try
        {
            body();
        }
        finally
        {
            _indent--;
            WriteLine($"</{closeTag}>");
            _indentUnit = previousIndentUnit;
        }

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
        try
        {
            body();
        }
        finally
        {
            _indent--;
        }

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
    /// Renders a JSON boolean, string, or string-array value as the equivalent C# literal
    /// (<c>true</c>/<c>false</c>, a quoted string, or a <c>List&lt;string&gt;</c> collection
    /// initializer). Used wherever a Smithy model value (an endpoint parameter default, an
    /// endpoint test case's parameter value) needs to become a literal in generated source. Other
    /// kinds fail loud rather than emitting an unverified literal — extend as more are onboarded.
    /// </summary>
    public static string NativeValue(JsonElement value) => value.ValueKind switch
    {
        JsonValueKind.True => "true",
        JsonValueKind.False => "false",
        JsonValueKind.String => Literal(value.GetString() ?? string.Empty),
        JsonValueKind.Array => NativeArrayValue(value),
        _ => throw new GeneratorException($"JSON value of kind '{value.ValueKind}' is not supported yet."),
    };

    // Matches the legacy generator's array support: endpoint parameters/test values only ever
    // carry string arrays (Smithy's stringArray endpoint parameter type), so this fails loud on
    // any element that isn't a string rather than guessing a collection type.
    private static string NativeArrayValue(JsonElement value)
    {
        var elements = value.EnumerateArray().Select(element => element.ValueKind == JsonValueKind.String
            ? Literal(element.GetString() ?? string.Empty)
            : throw new GeneratorException($"Array element of kind '{element.ValueKind}' is not supported yet; only string arrays are."));

        return $"new List<string> {{ {string.Join(", ", elements)} }}";
    }

    /// <summary>
    /// Returns the raw buffered content verbatim, without running it through the Roslyn formatter.
    /// Use for non-C# output (e.g. XML nuspec files) where the writer manages its own indentation
    /// and the C# formatter would corrupt the markup.
    /// </summary>
    public string ToRawString() => _buffer.ToString();

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
