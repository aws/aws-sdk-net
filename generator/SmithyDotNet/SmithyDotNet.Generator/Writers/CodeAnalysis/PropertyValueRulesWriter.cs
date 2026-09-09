using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model.Shapes;
using SmithyDotNet.Generator.Model.Traits;
using SmithyDotNet.Generator.Writers.Shapes;
using System.Globalization;
using System.Text;
using System.Xml;

namespace SmithyDotNet.Generator.Writers.CodeAnalysis;

/// <summary>
/// Emits <c>PropertyValueRules.xml</c>: the min/max/pattern constraints for every constrained
/// scalar property, consumed by the service's compile-time property-value analyzer.
/// <para />
/// Mirrors the legacy generator's walk: operation input/output structures first (named
/// <c>{Operation}Request</c>/<c>{Operation}Response</c> after the generated classes), then every
/// other structure sorted by shape name. Only scalar members carrying a <c>length</c>,
/// <c>range</c>, or <c>pattern</c> constraint produce a rule.
/// </summary>
public sealed class PropertyValueRulesWriter(GenerationContext context)
{
    public string Write(CancellationToken cancellationToken = default)
    {
        var sb = new StringBuilder();
        using (var writer = XmlWriter.Create(sb, new XmlWriterSettings { Indent = true }))
        {
            writer.WriteStartElement("property-value-rules");

            // The legacy generator skips S3 entirely here (it hand-maintains its own rules). S3 isn't
            // onboarded to the Smithy path yet; revisit this carve-out when it is.

            // Input/output structures are named after the generated request/response classes, not
            // their modeled shape names, so they're emitted here and skipped in the sorted walk below.
            var requestAndResponseShapes = new HashSet<string>();
            foreach (var operation in context.Operations)
            {
                cancellationToken.ThrowIfCancellationRequested();
                WriteShapeRules(writer, $"{operation.Name}Request", operation.Input);
                WriteShapeRules(writer, $"{operation.Name}Response", operation.Output);
                requestAndResponseShapes.Add(operation.Shape.Input.Name);
                requestAndResponseShapes.Add(operation.Shape.Output.Name);
            }

            foreach (var (shapeId, structure) in context.Structures.Concat(context.Errors)
                         .OrderBy(kvp => kvp.Key.Name, StringComparer.Ordinal))
            {
                cancellationToken.ThrowIfCancellationRequested();
                if (requestAndResponseShapes.Contains(shapeId.Name))
                {
                    continue;
                }

                // An error shape's rules go under its generated exception class name.
                WriteShapeRules(writer, structure.IsError() ? ExceptionWriter.ToExceptionName(shapeId.Name) : shapeId.Name, structure);
            }

            writer.WriteEndElement();
        }

        return sb.ToString();
    }

    private void WriteShapeRules(XmlWriter writer, string shapeName, StructureShape structure)
    {
        // Sort by property name so output is stable and matches the SDK's generated ordering.
        // current SDK sorts at the Members accessor level.
        var members = structure.Members
            .Select(kvp => (Property: SdkNaming.ToUpperFirstCharacter(kvp.Key), Member: kvp.Value))
            .OrderBy(m => m.Property, StringComparer.Ordinal);

        foreach (var (property, member) in members)
        {
            // An exception class never declares Message: it flows to the base Exception via the
            // constructor, so a rule for it could never match an assignment.
            if (structure.IsError() && property == "Message")
            {
                continue;
            }

            var target = context.Resolve(member.Target);
            if (!TypeMapper.IsScalar(target))
            {
                continue;
            }

            // A constraint on the member overrides one on the target shape, matching TypeMapper.
            // length (string/blob) and range (numeric) are mutually exclusive per the Smithy spec, so
            // a single min/max pair covers both.
            var length = member.GetLength() ?? target.GetLength();
            var range = member.GetRange() ?? target.GetRange();
            var min = length?.Min ?? range?.Min;
            var max = length?.Max ?? range?.Max;
            var pattern = member.GetPattern() ?? target.GetPattern();
            if (min is null && max is null && pattern is null)
            {
                continue;
            }

            writer.WriteStartElement("property-value-rule");
            writer.WriteElementString("property", $"{context.Namespace}.Model.{shapeName}.{property}");

            if (min is not null)
            {
                writer.WriteElementString("min", min.Value.ToString(CultureInfo.InvariantCulture));
            }

            if (max is not null)
            {
                writer.WriteElementString("max", max.Value.ToString(CultureInfo.InvariantCulture));
            }

            // The consuming analyzer (AbstractPropertyValueAssignmentAnalyzer) wraps its `new Regex(pattern)`
            // in a try/catch and silently skips the rule on failure, so an invalid .NET regex here is a
            // missed check, not a build break. Every pattern across the six migrated services compiles
            // today; revisit only if that stops being true.
            if (pattern is not null)
            {
                writer.WriteElementString("pattern", ConvertSmithyPattern(pattern));
            }

            writer.WriteEndElement();
        }
    }

    /// <summary>
    /// A Smithy pattern matches anywhere in the input, but the consuming analyzer requires its match to
    /// cover the whole value, so an unanchored pattern like <c>\S</c> would flag every constant longer
    /// than one character. Padding unanchored ends with <c>.*</c> preserves the Smithy match-anywhere
    /// semantics — the same translation the C2J models carry for such patterns (<c>\S</c> appears there
    /// as <c>.*\S.*</c>).
    /// <para />
    /// This intentionally diverges from the C2J translation in one way: that translation also strips
    /// <c>^</c>/<c>$</c> anchors, which is a no-op under the analyzer's whole-value comparison. Keeping
    /// them emits anchored patterns exactly as the smithy.json states them and leaves the already-shipped
    /// XML of previously migrated services unchanged.
    /// <para />
    /// Edge cases, all matching the C2J translation's behavior:
    /// <list type="bullet">
    /// <item>An end already padded with <c>.*</c> is not padded again, so re-translation is stable.</item>
    /// <item>Patterns that are only anchors (<c>^</c>, <c>$</c>, <c>^$</c>) are returned untouched.</item>
    /// <item>The anchor checks are textual: an escaped trailing <c>\$</c> counts as an anchor, and a
    /// padded top-level alternation is not grouped first (<c>a|b</c> becomes <c>.*a|b.*</c>).</item>
    /// </list>
    /// </summary>
    public static string ConvertSmithyPattern(string pattern)
    {
        var anchoredStart = pattern.StartsWith('^');
        var anchoredEnd = pattern.EndsWith('$');
        var coreLength = pattern.Length - (anchoredStart ? 1 : 0) - (anchoredEnd ? 1 : 0);
        if (coreLength <= 0)
        {
            return pattern; // Don't try to do anything to unexpected patterns
        }

        var prefix = !anchoredStart && !pattern.StartsWith(".*", StringComparison.Ordinal) ? ".*" : "";
        var suffix = !anchoredEnd && !pattern.EndsWith(".*", StringComparison.Ordinal) ? ".*" : "";
        return prefix + pattern + suffix;
    }
}
