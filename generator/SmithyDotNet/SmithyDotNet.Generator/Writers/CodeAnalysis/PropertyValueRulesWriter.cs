using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model.Shapes;
using SmithyDotNet.Generator.Model.Traits;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Xml;

namespace SmithyDotNet.Generator.Writers.CodeAnalysis;

/// <summary>
/// Emits <c>PropertyValueRules.xml</c>: the min/max/pattern constraints for every constrained
/// scalar property, consumed by the service's compile-time property-value analyzer.
/// <para />
/// Mirrors the legacy generator's walk: operation input/output structures first (named
/// <c>{Operation}Request</c>/<c>{Operation}Response</c> after the generated classes), then every
/// other structure sorted by shape name. Only scalar members carrying a <c>length</c> or
/// <c>pattern</c> constraint produce a rule.
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

                WriteShapeRules(writer, shapeId.Name, structure);
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
            var target = context.Resolve(member.Target);
            if (!TypeMapper.IsScalar(target))
            {
                continue;
            }

            // A constraint on the member overrides one on the target shape, matching TypeMapper.
            // TODO: numeric range (smithy.api#range) isn't emitted yet - CloudTrail Data has none. Add
            // a GetRange trait accessor and fold its min/max in here once a service needs it.
            var length = member.GetLength() ?? target.GetLength();
            var pattern = member.GetPattern() ?? target.GetPattern();
            if (length?.Min is null && length?.Max is null && pattern is null)
            {
                continue;
            }

            writer.WriteStartElement("property-value-rule");
            writer.WriteElementString("property", $"{context.Namespace}.Model.{shapeName}.{property}");

            if (length?.Min is not null)
            {
                writer.WriteElementString("min", length.Min.Value.ToString(CultureInfo.InvariantCulture));
            }

            if (length?.Max is not null)
            {
                writer.WriteElementString("max", length.Max.Value.ToString(CultureInfo.InvariantCulture));
            }

            // TODO: the consuming analyzer compiles this pattern as a .NET Regex. If a service ever
            // models a pattern that isn't a valid .NET regex, guard this (the legacy generator dropped
            // such patterns). CloudTrail Data's all compile, so no guard yet.
            if (pattern is not null)
            {
                writer.WriteElementString("pattern", pattern);
            }

            writer.WriteEndElement();
        }
    }
}
