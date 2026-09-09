using System.Text;
using System.Text.RegularExpressions;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Model.Shapes;

namespace SmithyDotNet.Generator.Generation;

/// <summary>
/// Compiles the JMESPath expression of a <c>smithy.rules#operationContextParams</c> entry into the C#
/// accessor the endpoint resolver reads, relative to a local named <c>request</c>.
/// <list type="bullet">
///   <item><c>a.b</c> -> <c>A?.B</c></item>
///   <item><c>keys(a)</c> -> <c>A?.Keys.ToList()</c></item>
///   <item><c>a[*].b</c> -> <c>A?.Select(element =&gt; element?.B)</c></item>
///   <item><c>a.*.b</c> -> <c>A?.Values.Select(element =&gt; element?.B)</c></item>
///   <item><c>a[]</c> -> <c>A?.SelectMany(element =&gt; element).Where(element =&gt; element != null)</c></item>
///   <item><c>a[*].[b, c][]</c> -> <c>A?.Select(element =&gt; new [] { element?.B, element?.C })?.SelectMany(...)</c></item>
/// </list>
/// Ports the algorithm of C2J's <c>Utils.JMESPathToNativeValue</c>, so the output matches by
/// construction rather than by special-casing the expressions models happen to use today.
/// <para />
/// Projections deliberately do not filter nulls even though a JMESPath projection drops them: the
/// shipping DynamoDB resolver doesn't either, and diverging would change endpoint resolution for a
/// service already in customers' hands. Array indexing, flattening inside a projection, and a
/// multi-select list outside one all throw, because C2J's output for each is unusable and no model
/// exercises them.
/// </summary>
public static partial class JmesPathCompiler
{
    private const string ElementPrefix = "element?.";

    /// <summary>
    /// Compiles <paramref name="path"/> against <paramref name="start"/>, the shape the path is
    /// relative to. <paramref name="context"/> prefixes any error (e.g. the operation and parameter).
    /// </summary>
    public static string Compile(string path, Shape start, ServiceIndex index, string context)
    {
        if (string.IsNullOrWhiteSpace(path))
        {
            throw new GeneratorException($"{context}: empty JMESPath expression.");
        }

        var accessor = new StringBuilder();
        // Projections open a lambda; their closing parentheses are all emitted after the last token.
        var closing = new StringBuilder();
        var current = start;

        foreach (var token in Tokenize(path))
        {
            if (accessor.Length > 0)
            {
                accessor.Append("?.");
            }

            switch (token)
            {
                case "[*]":
                    current = ProjectionElement(current, isList: true, token, path, index, context);
                    accessor.Append("Select(element => element");
                    closing.Append(')');
                    continue;

                case "*":
                    current = ProjectionElement(current, isList: false, token, path, index, context);
                    accessor.Append("Values.Select(element => element");
                    closing.Append(')');
                    continue;

                case "[]":
                    // Inside an open projection the SelectMany would land in the lambda, yielding a
                    // sequence of sequences (CS0266). A multi-select list closes its projection first,
                    // which is why DynamoDB's flatten works.
                    if (closing.Length > 0)
                    {
                        throw new GeneratorException($"{context}: '[]' directly inside a projection is not supported in '{path}'.");
                    }

                    accessor.Append("SelectMany(element => element).Where(element => element != null)");
                    continue;
            }

            if (token.StartsWith('[') && token.EndsWith(']'))
            {
                AppendMultiSelect(accessor, closing, token, current, index, context);
                continue;
            }

            AppendMember(accessor, token, path, ref current, index, context);
        }

        return accessor.Append(closing).ToString();
    }

    private static Shape ProjectionElement(Shape current, bool isList, string token, string path, ServiceIndex index, string context)
    {
        if (isList)
        {
            return current is ListShape list
                ? ResolveShape(index, list.Member.Target, context)
                : throw new GeneratorException($"{context}: '{token}' in '{path}' needs a list, but the path targets a {current.Type}.");
        }

        return current is MapShape map
            ? ResolveShape(index, map.Value.Target, context)
            : throw new GeneratorException($"{context}: '{token}' in '{path}' needs a map, but the path targets a {current.Type}.");
    }

    // The enclosing projection has already emitted "element?.", which the array replaces rather than
    // extends, and its closing paren is pulled forward so the array sits inside the lambda.
    private static void AppendMultiSelect(StringBuilder accessor, StringBuilder closing, string token, Shape current, ServiceIndex index, string context)
    {
        var inner = token[1..^1];
        if (int.TryParse(inner, out _))
        {
            throw new GeneratorException($"{context}: array indexing '{token}' is not supported.");
        }

        // Each selection is written against the enclosing projection's lambda variable, so without one
        // the emitted accessor would reference an undefined 'element'.
        if (closing.Length == 0)
        {
            throw new GeneratorException($"{context}: multi-select list '{token}' outside a projection is not supported.");
        }

        if (accessor.ToString().EndsWith(ElementPrefix, StringComparison.Ordinal))
        {
            accessor.Length -= ElementPrefix.Length;
        }

        var selections = inner
            .Split(',')
            .Select(selection => $"{ElementPrefix}{Compile(selection.Trim(), current, index, context)}");

        accessor.Append("new [] { ").AppendJoin(", ", selections).Append(" }").Append(closing);
        closing.Clear();
    }

    private static void AppendMember(StringBuilder accessor, string token, string path, ref Shape current, ServiceIndex index, string context)
    {
        var keys = KeysCall().Match(token);
        var memberName = keys.Success ? keys.Groups[1].Value.Trim() : token;

        if (!Identifier().IsMatch(memberName))
        {
            throw new GeneratorException($"{context}: unsupported JMESPath syntax '{token}' in '{path}'.");
        }

        if (current is not StructureShape structure || !structure.Members.TryGetValue(memberName, out var member))
        {
            throw new GeneratorException($"{context}: member '{memberName}' in '{path}' is not on the resolved shape.");
        }

        var target = ResolveShape(index, member.Target, context);
        if (keys.Success && target is not MapShape)
        {
            throw new GeneratorException($"{context}: keys() needs a map member, but '{memberName}' targets a {target.Type}.");
        }

        accessor.Append(SdkNaming.ToUpperFirstCharacter(memberName));
        if (keys.Success)
        {
            accessor.Append("?.Keys.ToList()");
        }

        current = target;
    }

    // Ports C2J's SplitJMESPath: "." and "*" separate tokens outside brackets ("*" becoming a token of
    // its own), and a bracketed group is one token so a multi-select list's commas stay intact.
    private static List<string> Tokenize(string path)
    {
        var tokens = new List<string>();
        var current = new StringBuilder();
        var insideBrackets = false;

        foreach (var character in path)
        {
            if (character == '[' && !insideBrackets)
            {
                Flush(tokens, current);
                current.Append('[');
                insideBrackets = true;
            }
            else if (character == ']' && insideBrackets)
            {
                current.Append(']');
                Flush(tokens, current);
                insideBrackets = false;
            }
            else if ((character == '.' || character == '*') && !insideBrackets)
            {
                Flush(tokens, current);
                if (character == '*')
                {
                    tokens.Add("*");
                }
            }
            else
            {
                current.Append(character);
            }
        }

        Flush(tokens, current);
        return tokens;
    }

    private static void Flush(List<string> tokens, StringBuilder current)
    {
        if (current.Length > 0)
        {
            tokens.Add(current.ToString());
            current.Clear();
        }
    }

    // Mirrors PaginationResolver's resolver: both run while GenerationContext is still being built, so
    // GenerationContext.Resolve isn't available yet.
    private static Shape ResolveShape(ServiceIndex index, ShapeId shapeId, string context)
    {
        if (index.Shapes.TryGetValue(shapeId, out var shape))
        {
            return shape;
        }

        return PreludeShapes.Resolve(shapeId) ?? throw new GeneratorException($"{context}: shape '{shapeId}' not found.");
    }

    [GeneratedRegex("^[A-Za-z_][A-Za-z0-9_]*$")]
    private static partial Regex Identifier();

    [GeneratedRegex(@"^keys\(([^)]*)\)$")]
    private static partial Regex KeysCall();
}
