using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model.Traits;

namespace SmithyDotNet.Generator.Writers.Endpoints;

/// <summary>
/// Emits the endpoint parameters class (e.g. <c>CloudTrailDataEndpointParameters</c>), one property
/// per rule-set parameter. Note the class name has no <c>Amazon</c> prefix even though the file does
/// (<c>AmazonCloudTrailDataEndpointParameters</c>) — matching the existing SDK.
/// </summary>
public sealed class EndpointParametersWriter(GenerationContext context, string modelFileName)
{
    /// <summary>
    /// Emits the endpoint parameters source from <see cref="GenerationContext.EndpointParameters"/>. A rule set
    /// or endpoint BDD is required; callers gate on <see cref="GenerationContext.HasEndpointRuleSet"/> or
    /// <see cref="GenerationContext.HasEndpointBdd"/>.
    /// </summary>
    public string Write(CancellationToken cancellationToken = default)
    {
        var parameters = context.EndpointParameters ?? throw new GeneratorException("EndpointParametersWriter requires an endpoint rule set or endpoint BDD.");
        var className = $"{context.BaseName}EndpointParameters";

        var writer = new CodeWriter();
        FileHeader.WriteLicense(writer, modelFileName);
        // The provider/resolver crefs live in the *.Internal namespace, so it must be imported.
        FileHeader.WriteUsings(writer, [.. FileHeader.EndpointParametersUsings, $"{context.Namespace}.Internal"]);
        writer.OpenNamespace($"{context.Namespace}.Endpoints", () =>
        {
            writer.WriteLine("/// <summary>");
            writer.WriteLine($"/// Contains parameters used for resolving {context.BaseName} endpoints.");
            writer.WriteLine("/// <para />");
            writer.WriteLine("/// Parameters can be sourced from client config and service operations used by the");
            writer.WriteLine($"/// internal <see cref=\"{context.ClientName}EndpointProvider\"/> and <see cref=\"{context.ClientName}EndpointResolver\"/>.");
            writer.WriteLine("/// <para />");
            writer.WriteLine("/// Can be used by custom Endpoint Providers, <see cref=\"ClientConfig.EndpointProvider\"/>");
            writer.WriteLine("/// </summary>");
            writer.OpenBlock($"public class {className} : EndpointParameters", () =>
            {
                WriteConstructor(writer, parameters, className);
                foreach (var (name, parameter) in parameters)
                {
                    writer.WriteLine();
                    WriteProperty(writer, name, parameter);
                }

                WriteIndexer(writer, parameters);
                WriteParameterValuesEqual(writer, parameters, className);
            });
        });

        return writer.ToFormattedString(cancellationToken);
    }

    private static void WriteConstructor(CodeWriter writer, IReadOnlyDictionary<string, EndpointParameter> parameters, string className)
    {
        writer.WriteLine("/// <summary>");
        writer.WriteLine($"/// {className} constructor");
        writer.WriteLine("/// </summary>");
        writer.OpenBlock($"public {className}()", () =>
        {
            foreach (var (name, parameter) in parameters)
            {
                if (parameter.Default is { } defaultValue)
                {
                    writer.WriteLine($"{name} = {CodeWriter.NativeValue(defaultValue)};");
                }
            }
        });
    }

    private static void WriteProperty(CodeWriter writer, string name, EndpointParameter parameter)
    {
        if (parameter.Deprecated is not null)
        {
            // A deprecated parameter needs an [Obsolete] attribute (see the record); emitting the
            // property without it would silently drop the deprecation.
            throw new GeneratorException($"Endpoint parameter '{name}' is deprecated, which is not supported yet.");
        }

        var type = NativeType(parameter.Type);
        writer.WriteLine("/// <summary>");
        writer.WriteLine($"/// {parameter.Documentation ?? $"{name} parameter"}");
        writer.WriteLine("/// </summary>");
        // A typed auto-property (backing field, no dictionary lookup/boxing). The overridden indexer
        // routes parameters["X"] to this same property so string and typed access stay in sync.
        writer.WriteLine($"public {type} {name} {{ get; set; }}");
    }

    // Overrides PropertyBag's (virtual) indexer so parameters["X"] reads/writes the same typed
    // backing field as parameters.X. Unknown keys fall through to the base dictionary, preserving the
    // custom-provider contract.
    private static void WriteIndexer(CodeWriter writer, IReadOnlyDictionary<string, EndpointParameter> parameters)
    {
        writer.WriteLine();
        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Gets or sets an endpoint parameter by name. Known parameters read and write the typed");
        writer.WriteLine("/// properties; any other name falls through to the underlying property bag.");
        writer.WriteLine("/// </summary>");
        writer.OpenBlock("public override object this[string name]", () =>
        {
            writer.OpenBlock("get => name switch", "};", () =>
            {
                foreach (var (name, _) in parameters)
                {
                    writer.WriteLine($"\"{name}\" => {name},");
                }

                writer.WriteLine("_ => base[name],");
            });

            writer.OpenBlock("set", () =>
            {
                writer.OpenBlock("switch (name)", () =>
                {
                    foreach (var (name, parameter) in parameters)
                    {
                        writer.WriteLine($"case \"{name}\": {name} = ({NativeType(parameter.Type)})value; break;");
                    }

                    writer.WriteLine("default: base[name] = value; break;");
                });
            });
        });
    }

    // Core's endpoint cache reuses an endpoint resolved earlier in the request when the parameters are
    // unchanged. The base comparison only sees the property bag, which typed properties never write, so
    // compare each typed property here and defer to the base for keys set only through the indexer.
    // string/bool? use == (no boxing); stringArray uses Equals, the same reference comparison the bag
    // applies to list values.
    private static void WriteParameterValuesEqual(CodeWriter writer, IReadOnlyDictionary<string, EndpointParameter> parameters, string className)
    {
        writer.WriteLine();
        writer.WriteLine("/// <inheritdoc/>");
        writer.OpenBlock("protected override bool ParameterValuesEqual(EndpointParameters other)", () =>
        {
            writer.WriteLine($"var o = ({className})other;");
            var comparisons = parameters.Select(p => NativeType(p.Value.Type) == "IEnumerable<string>"
                ? $"Equals({p.Key}, o.{p.Key})"
                : $"{p.Key} == o.{p.Key}");
            var lines = comparisons.Append("base.ParameterValuesEqual(other)").ToList();
            for (var i = 0; i < lines.Count; i++)
            {
                var prefix = i == 0 ? "return " : "    && ";
                var suffix = i == lines.Count - 1 ? ";" : string.Empty;
                writer.WriteLine($"{prefix}{lines[i]}{suffix}");
            }
        });
    }

    // Rule-set parameters are nullable value types so an unset parameter is distinguishable from a
    // false/empty one (the provider checks IsSet before reading them). stringArray is a reference
    // type (IEnumerable<string>), so it needs no "?".
    // The type is matched case-insensitively: the rules-engine spec uses lowercase (string/boolean/
    // stringArray), but some models may carry the capitalized shape names (String/Boolean).
    private static string NativeType(string smithyType) => smithyType.ToLowerInvariant() switch
    {
        "string" => "string",
        "boolean" => "bool?",
        "stringarray" => "IEnumerable<string>",
        _ => throw new GeneratorException($"Unsupported endpoint parameter type '{smithyType}'."),
    };
}
