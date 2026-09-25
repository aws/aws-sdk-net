using System.Globalization;
using System.Text.Json;
using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Generation.Operations;
using SmithyDotNet.Generator.Model.Shapes;
using SmithyDotNet.Generator.Model.Traits;

namespace SmithyDotNet.Generator.Writers.Examples;

/// <summary>An operation's example, with the region id that links its code to its .extra.xml entry.</summary>
public sealed record DocSample(Operation Operation, ExampleTraitEntry Example, string RegionId);

/// <summary>
/// Emits <c>{ServiceName}.GeneratedSamples.cs</c> from <c>smithy.api#examples</c>, rendering values as C2J's
/// <c>Example.cs</c> does but with the SDK's types, so a copied sample compiles once any placeholder is filled in.
/// The file is never compiled and its values can be placeholders such as <c>&lt;binary data&gt;</c>, so it is
/// written raw rather than Roslyn-formatted.
/// </summary>
public sealed class DocSamplesWriter(GenerationContext context)
{
    // global:: because inside this file's AWSSDKDocSamples.Amazon namespace "Amazon." binds there, and a bare
    // Document could be a service model class.
    private const string DocumentType = "global::Amazon.Runtime.Documents.Document";

    private static readonly double MinEpochMilliseconds = (DateTime.MinValue - DateTime.UnixEpoch).TotalMilliseconds;
    private static readonly double MaxEpochMilliseconds = (DateTime.MaxValue - DateTime.UnixEpoch).TotalMilliseconds;

    /// <summary>
    /// The service's examples in emission order, or none for S3, which C2J skips because its samples are
    /// hand-written. The trait carries no example id (C2J's came from the retiring examples.json), so each
    /// region id is <c>{Operation}-{n}</c>; it must be unique, since the docs build takes the first matching region.
    /// </summary>
    public static IReadOnlyList<DocSample> Collect(GenerationContext context)
    {
        if (context.SdkId == "S3")
        {
            return [];
        }

        // C2J orders operations with the culture comparer, which ignores case here (ListReports before
        // ListReportVersions); context.Operations is ordinal.
        return context.Operations
            .OrderBy(operation => operation.Name, StringComparer.OrdinalIgnoreCase)
            .SelectMany(operation => operation.Shape.GetExamples().Select((example, i) => new DocSample(operation, example, $"{operation.Name}-{i + 1}")))
            .ToList();
    }

    public string Write(IReadOnlyList<DocSample> samples)
    {
        var writer = new CodeWriter();
        FileHeader.WriteUsings(writer, ["System", "System.Collections.Generic", "System.IO", "System.Linq", "System.Text", "System.Threading.Tasks"]);
        FileHeader.WriteUsings(writer, [context.Namespace, $"{context.Namespace}.Model"]);
        writer.OpenNamespace($"AWSSDKDocSamples.{context.Namespace}.Generated", () =>
        {
            writer.OpenBlock($"class {context.BaseName}Samples : ISample", () =>
            {
                foreach (var sample in samples)
                {
                    WriteMethod(writer, sample);
                    writer.WriteLine();
                }

                writer.WriteLine("#region ISample Members");
                writer.OpenBlock("public virtual void Run()", () => { });
                writer.WriteLine("#endregion");
            });
        });

        return writer.ToRawString();
    }

    private void WriteMethod(CodeWriter writer, DocSample sample)
    {
        var (operation, example, regionId) = sample;
        writer.OpenBlock($"public void {context.BaseName}{operation.Name}()", () =>
        {
            writer.WriteLine($"#region {regionId}");
            writer.WriteLine();
            writer.WriteLine($"var client = new {context.ClientName}Client();");
            writer.OpenBlock($"var response = client.{operation.Name}(new {operation.Name}Request", "});", () => WriteRequestAssignments(writer, operation.Input, example.Input));
            writer.WriteLine();
            WriteResponseAssignments(writer, operation.Output, example.Output);
            writer.WriteLine();
            writer.WriteLine("#endregion");
        });
    }

    private void WriteRequestAssignments(CodeWriter writer, StructureShape input, JsonElement data)
    {
        if (data.ValueKind != JsonValueKind.Object)
        {
            return;
        }

        // The comma test counts keys that match no member, as C2J's does.
        var members = TypeMapper.ResolveMembers(input, context);
        var properties = SortedProperties(data);
        for (var i = 0; i < properties.Count; i++)
        {
            // A request event stream is a Func publisher property, which example data can't express.
            if (FindMember(members, properties[i].Name) is { Type.IsEventStream: false } member)
            {
                WriteValue(writer, $"{member.PropertyName} = ", member.Type.Target, properties[i].Value, i < properties.Count - 1 ? "," : "");
            }
        }
    }

    private void WriteResponseAssignments(CodeWriter writer, StructureShape output, JsonElement data)
    {
        if (data.ValueKind != JsonValueKind.Object)
        {
            return;
        }

        var members = TypeMapper.ResolveMembers(output, context);
        foreach (var property in SortedProperties(data))
        {
            if (FindMember(members, property.Name) is { } member)
            {
                writer.WriteLine($"{QualifyDocument(member.Type.DotNetType)} {SdkNaming.ToParameterName(member.ModeledName)} = response.{member.PropertyName};");
            }
        }
    }

    // C2J writes keys in examples.json's order, which is ordinal-sorted for about 92% of objects; the
    // trait's own order matches it for about 37%.
    private static List<JsonProperty> SortedProperties(JsonElement data) =>
        data.EnumerateObject().OrderBy(property => property.Name, StringComparer.Ordinal).ToList();

    // C2J matches an example key to a member ignoring case (Utils.GetMemberByName).
    private static Member? FindMember(IReadOnlyList<Member> members, string key) =>
        members.FirstOrDefault(member => string.Equals(member.ModeledName, key, StringComparison.OrdinalIgnoreCase));

    // Writes "{prefix}{value}{suffix}". A collection opens "{" at the end of its first line, as C2J lays it out.
    private void WriteValue(CodeWriter writer, string prefix, Shape shape, JsonElement data, string suffix)
    {
        switch (shape)
        {
            case ListShape list when data.ValueKind == JsonValueKind.Array:
                WriteBlock(writer, $"{prefix}new {TypeName(list)} ", suffix, data.EnumerateArray().ToList(),
                    (item, itemSuffix) => WriteValue(writer, "", context.Resolve(list.Member.Target), item, itemSuffix));
                break;

            case MapShape map when data.ValueKind == JsonValueKind.Object:
                WriteBlock(writer, $"{prefix}new {TypeName(map)} ", suffix, SortedProperties(data),
                    (entry, entrySuffix) => WriteValue(writer, $"{{ {CodeWriter.Literal(entry.Name)}, ", context.Resolve(map.Value.Target), entry.Value, $" }}{entrySuffix}"));
                break;

            case StructureShape structure when data.ValueKind == JsonValueKind.Object:
                WriteStructure(writer, prefix, structure, data, suffix);
                break;

            // C2J rendered a document as an empty initializer of a class that doesn't exist.
            case DocumentShape:
                WriteDocument(writer, prefix, data, suffix);
                break;

            default:
                writer.WriteLine($"{prefix}{ScalarLiteral(shape, data)}{suffix}");
                break;
        }
    }

    // Keys that match no member still count toward the brace style and the comma test, as in C2J.
    private void WriteStructure(CodeWriter writer, string prefix, StructureShape structure, JsonElement data, string suffix)
    {
        var members = TypeMapper.ResolveMembers(structure, context);
        var fields = SortedProperties(data);
        var header = $"{prefix}new {TypeName(structure)} ";
        if (fields.Count > 1)
        {
            WriteBlock(writer, header, suffix, fields, (field, fieldSuffix) =>
            {
                if (FindMember(members, field.Name) is { } member)
                {
                    WriteValue(writer, $"{member.PropertyName} = ", member.Type.Target, field.Value, fieldSuffix);
                }
            });
        }
        else if (fields.Count == 1 && FindMember(members, fields[0].Name) is { } member)
        {
            WriteValue(writer, $"{header}{{ {member.PropertyName} = ", member.Type.Target, fields[0].Value, $" }}{suffix}");
        }
        else
        {
            writer.WriteLine($"{header}{{  }}{suffix}");
        }
    }

    // Document's collection initializers and its implicit conversions from string, bool and numbers keep the
    // value as written. An empty object or array needs its constructor: an empty initializer is a null document.
    private static void WriteDocument(CodeWriter writer, string prefix, JsonElement data, string suffix)
    {
        switch (data.ValueKind)
        {
            case JsonValueKind.Object when data.EnumerateObject().Any():
                WriteBlock(writer, $"{prefix}new {DocumentType} ", suffix, SortedProperties(data),
                    (field, fieldSuffix) => WriteDocument(writer, $"{{ {CodeWriter.Literal(field.Name)}, ", field.Value, $" }}{fieldSuffix}"));
                break;

            case JsonValueKind.Array when data.GetArrayLength() > 0:
                WriteBlock(writer, $"{prefix}new {DocumentType} ", suffix, data.EnumerateArray().ToList(),
                    (item, itemSuffix) => WriteDocument(writer, "", item, itemSuffix));
                break;

            case var kind:
                var literal = kind switch
                {
                    JsonValueKind.Object => $"new {DocumentType}(new Dictionary<string, {DocumentType}>())",
                    JsonValueKind.Array => $"new {DocumentType}(new List<{DocumentType}>())",
                    JsonValueKind.String => CodeWriter.Literal(data.GetString() ?? string.Empty),
                    JsonValueKind.Number or JsonValueKind.True or JsonValueKind.False => data.GetRawText(),
                    _ => $"new {DocumentType}()",
                };
                writer.WriteLine($"{prefix}{literal}{suffix}");
                break;
        }
    }

    // "{header}{", one indented item per entry with a comma after all but the last, then "}{suffix}".
    private static void WriteBlock<T>(CodeWriter writer, string header, string suffix, IReadOnlyList<T> items, Action<T, string> writeItem)
    {
        writer.WriteLine($"{header}{{");
        writer.Indent(() =>
        {
            for (var i = 0; i < items.Count; i++)
            {
                writeItem(items[i], i < items.Count - 1 ? "," : "");
            }
        });
        writer.WriteLine($"}}{suffix}");
    }

    private static string ScalarLiteral(Shape shape, JsonElement data) => shape switch
    {
        // An enum is a ConstantClass in .NET; C2J renders the wire value as a string literal (the
        // implicit string conversion makes it assignable).
        StringShape or EnumShape when data.ValueKind == JsonValueKind.String => CodeWriter.Literal(data.GetString() ?? string.Empty),
        BooleanShape when data.ValueKind is JsonValueKind.True or JsonValueKind.False => data.GetRawText(),
        // C2J prints a string-typed boolean or number unquoted, which is only valid C# when the string parses.
        BooleanShape when data.ValueKind == JsonValueKind.String && bool.TryParse(data.GetString(), out var flag) => flag ? "true" : "false",
        IntegerShape or IntEnumShape or LongShape or DoubleShape => NumberLiteral(data) ?? "<data>",
        // A fractional literal is a double in C#, which doesn't convert to float implicitly.
        FloatShape => NumberLiteral(data) is { } number ? (long.TryParse(number, out _) ? number : number + "f") : "<data>",
        TimestampShape => TimestampLiteral(data),
        // Unquoted, as C2J writes it: the value is a placeholder such as "<binary data>".
        BlobShape when data.ValueKind == JsonValueKind.String => $"new MemoryStream({data.GetString()})",
        _ => "<data>",
    };

    // C2J's JSON reader turns a number with a fraction or exponent into a double, printed shortest
    // round-trip ("1.0" becomes "1").
    private static string? NumberLiteral(JsonElement data)
    {
        var text = data.ValueKind switch
        {
            JsonValueKind.Number => data.GetRawText(),
            JsonValueKind.String => data.GetString(),
            _ => null,
        };

        if (long.TryParse(text, NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture, out var integer))
        {
            return integer.ToString(CultureInfo.InvariantCulture);
        }

        return double.TryParse(text, NumberStyles.Float, CultureInfo.InvariantCulture, out var real) ? real.ToString(CultureInfo.InvariantCulture) : null;
    }

    // A date-time string, parsed as UTC so the value doesn't depend on the machine's zone, or a number of epoch
    // seconds (Smithy's two forms for a timestamp in example data), to millisecond precision. Some models put
    // epoch milliseconds there, which is past DateTime's range as seconds.
    private static string TimestampLiteral(JsonElement data)
    {
        DateTime? value = data.ValueKind switch
        {
            JsonValueKind.String when DateTime.TryParse(data.GetString(), CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeUniversal, out var parsed) => parsed,
            JsonValueKind.Number when Math.Round(data.GetDouble() * 1000) is var epochMilliseconds && epochMilliseconds > MinEpochMilliseconds && epochMilliseconds < MaxEpochMilliseconds
                => DateTime.UnixEpoch.AddMilliseconds(epochMilliseconds),
            _ => null,
        };

        if (value is not { } time)
        {
            return "DateTime.UtcNow";
        }

        var milliseconds = time.Millisecond > 0 ? $", {time.Millisecond}" : "";
        return string.Create(CultureInfo.InvariantCulture, $"new DateTime({time.Year}, {time.Month}, {time.Day}, {time.Hour}, {time.Minute}, {time.Second}{milliseconds}, DateTimeKind.Utc)");
    }

    // The SDK's type for a collection value, which is also how C2J types these literals: string for strings and
    // enums, non-nullable scalars, the structure's class name.
    private string TypeName(Shape shape) =>
        QualifyDocument(TypeMapper.MapCollectionValueType(TypeMapper.CollectionElementTarget(shape), context, isSparse: false));

    private static string QualifyDocument(string type) => type.Replace("Amazon.Runtime.Documents.Document", DocumentType);
}
