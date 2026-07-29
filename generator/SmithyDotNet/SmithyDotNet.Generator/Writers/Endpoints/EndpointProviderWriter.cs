using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model.Traits;

namespace SmithyDotNet.Generator.Writers.Endpoints;

/// <summary>
/// Emits the endpoint provider (e.g. <c>AmazonCloudTrailDataEndpointProvider</c>), whose
/// <c>ResolveEndpoint</c> evaluates the rule set. The rule tree is compiled by
/// <see cref="EndpointRulesCompiler"/>; this writer supplies the surrounding class, the parameter
/// null-guards, and the <c>refs</c> dictionary the compiled code reads from.
/// </summary>
public sealed class EndpointProviderWriter(GenerationContext context, string modelFileName)
{
    /// <summary>
    /// Emits the endpoint provider source. The rule set is required; callers gate on
    /// <see cref="GenerationContext.HasEndpointRuleSet"/>.
    /// </summary>
    public string Write(CancellationToken cancellationToken = default)
    {
        var ruleSet = context.EndpointRuleSet ?? throw new GeneratorException("EndpointProviderWriter requires an endpoint rule set.");
        var className = $"{context.ClientName}EndpointProvider";
        var parametersName = $"{context.ServiceName}EndpointParameters";

        var writer = new CodeWriter();
        FileHeader.WriteLicense(writer, modelFileName);
        // The parameters cref lives in the *.Endpoints namespace, so it must be imported.
        FileHeader.WriteUsings(writer, [.. FileHeader.EndpointProviderUsings, $"{context.Namespace}.Endpoints"]);
        writer.OpenNamespace($"{context.Namespace}.Internal", () =>
        {
            writer.WriteLine("/// <summary>");
            writer.WriteLine($"/// Amazon {context.ServiceName} endpoint provider.");
            writer.WriteLine("/// <para />");
            writer.WriteLine($"/// Resolves endpoint for given set of <see cref=\"{parametersName}\"/>.");
            writer.WriteLine("/// Can throw <see cref=\"AmazonClientException\"/> if endpoint resolution is unsuccessful.");
            writer.WriteLine("/// </summary>");
            writer.OpenBlock($"public class {className} : IEndpointProvider", () =>
            {
                writer.WriteLine("/// <summary>");
                writer.WriteLine($"/// Resolve endpoint for {parametersName}");
                writer.WriteLine("/// </summary>");
                writer.OpenBlock("public Endpoint ResolveEndpoint(EndpointParameters parameters)", () =>
                {
                    WriteGuards(writer, ruleSet);
                    writer.WriteLine();
                    WriteRefs(writer, ruleSet);
                    EndpointRulesCompiler.WriteRules(writer, ruleSet);
                });
            });
        });

        return writer.ToFormattedString(cancellationToken);
    }

    private static void WriteGuards(CodeWriter writer, EndpointRuleSet ruleSet)
    {
        writer.OpenBlock("if (parameters == null)", () =>
        {
            writer.WriteLine("throw new ArgumentNullException(\"parameters\");");
        });

        // Required parameters must be present before the rules read them.
        foreach (var (name, parameter) in ruleSet.Parameters)
        {
            if (parameter.Required)
            {
                writer.OpenBlock($"if (parameters[\"{name}\"] == null)", () =>
                {
                    writer.WriteLine($"throw new AmazonClientException(\"{name} parameter must be set for endpoint resolution\");");
                });
            }
        }
    }

    private static void WriteRefs(CodeWriter writer, EndpointRuleSet ruleSet)
    {
        // The compiled rules read every parameter through refs, so seed it with all of them.
        writer.OpenBlock("var refs = new Dictionary<string, object>()", "};", () =>
        {
            foreach (var name in ruleSet.Parameters.Keys)
            {
                writer.WriteLine($"[\"{name}\"] = parameters[\"{name}\"],");
            }
        });
    }
}
