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
    /// Emits the endpoint parameters source. The rule set is required; callers gate on
    /// <see cref="GenerationContext.HasEndpointRuleSet"/>.
    /// </summary>
    public string Write(CancellationToken cancellationToken = default)
    {
        var ruleSet = context.EndpointRuleSet ?? throw new GeneratorException("EndpointParametersWriter requires an endpoint rule set.");
        var className = $"{context.ServiceName}EndpointParameters";

        var writer = new CodeWriter();
        FileHeader.WriteLicense(writer, modelFileName);
        // The provider/resolver crefs live in the *.Internal namespace, so it must be imported.
        FileHeader.WriteUsings(writer, [.. FileHeader.EndpointParametersUsings, $"{context.Namespace}.Internal"]);
        writer.OpenNamespace($"{context.Namespace}.Endpoints", () =>
        {
            writer.WriteLine("/// <summary>");
            writer.WriteLine($"/// Contains parameters used for resolving {context.ServiceName} endpoints.");
            writer.WriteLine("/// <para />");
            writer.WriteLine("/// Parameters can be sourced from client config and service operations used by the");
            writer.WriteLine($"/// internal <see cref=\"{context.ClientName}EndpointProvider\"/> and <see cref=\"{context.ClientName}EndpointResolver\"/>.");
            writer.WriteLine("/// <para />");
            writer.WriteLine("/// Can be used by custom Endpoint Providers, <see cref=\"ClientConfig.EndpointProvider\"/>");
            writer.WriteLine("/// </summary>");
            writer.OpenBlock($"public class {className} : EndpointParameters", () =>
            {
                WriteConstructor(writer, ruleSet, className);
                foreach (var (name, parameter) in ruleSet.Parameters)
                {
                    writer.WriteLine();
                    WriteProperty(writer, name, parameter);
                }
            });
        });

        return writer.ToFormattedString(cancellationToken);
    }

    private static void WriteConstructor(CodeWriter writer, EndpointRuleSet ruleSet, string className)
    {
        writer.WriteLine("/// <summary>");
        writer.WriteLine($"/// {className} constructor");
        writer.WriteLine("/// </summary>");
        writer.OpenBlock($"public {className}()", () =>
        {
            foreach (var (name, parameter) in ruleSet.Parameters)
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
        writer.OpenBlock($"public {type} {name}", () =>
        {
            writer.WriteLine($"get => ({type})this[\"{name}\"];");
            writer.WriteLine($"set => this[\"{name}\"] = value;");
        });
    }

    // Rule-set parameters are nullable value types so an unset parameter is distinguishable from a
    // false/empty one (the provider checks IsSet before reading them).
    private static string NativeType(string smithyType) => smithyType switch
    {
        "string" => "string",
        "boolean" => "bool?",
        _ => throw new GeneratorException($"Unsupported endpoint parameter type '{smithyType}'."),
    };
}
