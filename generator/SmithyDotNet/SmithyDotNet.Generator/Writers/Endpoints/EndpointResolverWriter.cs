using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model.Traits;

namespace SmithyDotNet.Generator.Writers.Endpoints;

/// <summary>
/// Emits the endpoint resolver (e.g. <c>AmazonCloudTrailDataEndpointResolver</c>), the pipeline
/// handler the config references. It maps client config onto the endpoint parameters and delegates
/// resolution to the provider. The body is fixed boilerplate apart from the per-builtIn assignments
/// and the region-from-ServiceURL block, which is emitted only when the rule set has a Region
/// parameter.
/// </summary>
public sealed class EndpointResolverWriter(GenerationContext context, string modelFileName)
{
    private readonly IReadOnlyList<string> _usings =
    [
        "System",
        "System.Linq",
        "System.Collections.Generic",
        $"{context.Namespace}.Model",
        "Amazon.Runtime",
        "Amazon.Runtime.Internal",
        "Amazon.Runtime.Endpoints",
        "Amazon.Util",
        $"{context.Namespace}.Endpoints",
    ];

    // Maps a rule-set builtIn to the config expression that sources it. Only the builtIns
    // CloudTrailData uses are handled; anything else fails loudly rather than guessing.
    private static readonly IReadOnlyDictionary<string, string> BuiltInSources = new Dictionary<string, string>
    {
        ["AWS::Region"] = "requestContext.Request.AlternateEndpoint?.SystemName ?? config.RegionEndpoint?.SystemName",
        ["AWS::UseFIPS"] = "config.UseFIPSEndpoint",
        ["AWS::UseDualStack"] = "config.UseDualstackEndpoint",
        ["SDK::Endpoint"] = "config.ServiceURL",
    };

    /// <summary>
    /// Emits the endpoint resolver source. The rule set is required; callers gate on
    /// <see cref="GenerationContext.HasEndpointRuleSet"/>.
    /// </summary>
    public string Write(CancellationToken cancellationToken = default)
    {
        var ruleSet = context.EndpointRuleSet ?? throw new GeneratorException("EndpointResolverWriter requires an endpoint rule set.");
        var className = $"{context.ClientName}EndpointResolver";
        var parametersName = $"{context.BaseName}EndpointParameters";

        var writer = new CodeWriter();
        FileHeader.WriteLicense(writer, modelFileName);
        FileHeader.WriteUsings(writer, _usings);
        FileHeader.WritePragma(writer, ["1591"]);
        writer.OpenNamespace($"{context.Namespace}.Internal", () =>
        {
            writer.WriteLine("/// <summary>");
            writer.WriteLine($"/// Amazon {context.BaseName} endpoint resolver.");
            writer.WriteLine("/// <para />");
            writer.WriteLine($"""/// Custom <see cref="PipelineHandler"/> responsible for resolving endpoint and setting authentication parameters for {context.BaseName} service requests.""");
            writer.WriteLine("/// <para />");
            writer.WriteLine($"/// Collects values for <see cref=\"{parametersName}\"/> and then tries to resolve endpoint by calling");
            writer.WriteLine($"/// <c>ResolveEndpoint</c> method on <see cref=\"GlobalEndpoints.Provider\"/> if present, otherwise uses <see cref=\"{context.ClientName}EndpointProvider\"/>.");
            writer.WriteLine("/// <para />");
            writer.WriteLine("/// Responsible for setting authentication and HTTP headers provided by resolved endpoint.");
            writer.WriteLine("/// </summary>");
            writer.OpenBlock($"public class {className} : BaseEndpointResolver", () =>
            {
                WriteServiceSpecificHandler(writer);
                writer.WriteLine();
                WriteMapEndpointsParameters(writer, ruleSet, parametersName);
            });
        });

        return writer.ToFormattedString(cancellationToken);
    }

    private static void WriteServiceSpecificHandler(CodeWriter writer)
    {
        writer.OpenBlock("protected override void ServiceSpecificHandler(IExecutionContext executionContext, EndpointParameters parameters)", () =>
        {
            writer.WriteLine("InjectHostPrefix(executionContext.RequestContext);");
        });
    }

    private void WriteMapEndpointsParameters(CodeWriter writer, EndpointRuleSet ruleSet, string parametersName)
    {
        writer.OpenBlock("protected override EndpointParameters MapEndpointsParameters(IRequestContext requestContext)", () =>
        {
            writer.WriteLine($"var config = ({context.ClientName}Config)requestContext.ClientConfig;");
            writer.WriteLine($"var result = new {parametersName}();");

            foreach (var (name, parameter) in ruleSet.Parameters)
            {
                if (parameter.BuiltIn is { } builtIn)
                {
                    writer.WriteLine($"result.{name} = {BuiltInSource(builtIn)};");
                }
            }

            // A clientContextParams entry is normally sourced from the config property it added, but a
            // parameter that *also* declares a builtIn takes the builtIn instead (C2J AssignClientContext).
            foreach (var parameter in context.ClientContextParameters)
            {
                var source = ruleSet.Parameters.TryGetValue(parameter.Name, out var declared) && declared.BuiltIn is { } builtIn
                    ? BuiltInSource(builtIn)
                    : $"config.{parameter.Name}";
                writer.WriteLine($"result.{parameter.Name} = {source};");
            }

            if (ruleSet.Parameters.ContainsKey("Region"))
            {
                writer.WriteLine();
                WriteRegionFromServiceUrl(writer);
            }

            // The comment is emitted only alongside real blocks. C2J emits it unconditionally, but it's
            // a comment, and emitting it for every service would churn every already-migrated resolver.
            if (context.OperationEndpointContexts.Count > 0)
            {
                writer.WriteLine();
                writer.WriteLine("// Assign staticContextParams and contextParam per operation");
                foreach (var operation in context.OperationEndpointContexts)
                {
                    WriteOperationContext(writer, operation);
                }
            }

            writer.WriteLine();
            writer.WriteLine("return result;");
        });
    }

    private static string BuiltInSource(string builtIn) =>
        BuiltInSources.TryGetValue(builtIn, out var source)
            ? source
            : throw new GeneratorException($"Endpoint parameter builtIn '{builtIn}' is not supported yet.");

    private static void WriteOperationContext(CodeWriter writer, OperationEndpointContext operation)
    {
        writer.OpenBlock($"""if (requestContext.RequestName == "{operation.OperationName}Request")""", () =>
        {
            foreach (var assignment in operation.StaticAssignments)
            {
                writer.WriteLine($"result.{assignment.Parameter} = {assignment.Expression};");
            }

            if (operation.RequestAssignments.Count > 0)
            {
                writer.WriteLine($"var request = ({operation.OperationName}Request)requestContext.OriginalRequest;");
                foreach (var assignment in operation.RequestAssignments)
                {
                    writer.WriteLine($"result.{assignment.Parameter} = {assignment.Expression};");
                }
            }

            writer.WriteLine("return result;");
        });
    }

    // Fills in the region from a custom ServiceURL when it isn't otherwise set, mirrors the legacy
    // endpoints.json "us-east-1-regional" rule, and lets an explicit AlternateEndpoint win.
    private static void WriteRegionFromServiceUrl(CodeWriter writer)
    {
        writer.WriteLine("// The region needs to be determined from the ServiceURL if not set.");
        writer.WriteLine("var regionEndpoint = config.RegionEndpoint;");
        writer.OpenBlock("if (regionEndpoint == null && !string.IsNullOrEmpty(config.ServiceURL))", () =>
        {
            writer.WriteLine("// Use the specified signing region if it was provided alongside a custom ServiceURL");
            writer.OpenBlock("if (!string.IsNullOrEmpty(config.AuthenticationRegion))", () =>
            {
                writer.WriteLine("result.Region = config.AuthenticationRegion;");
            });
            writer.OpenBlock("else // try to extract a region from the custom ServiceURL", () =>
            {
                writer.WriteLine("var regionName = AWSSDKUtils.DetermineRegion(config.ServiceURL);");
                writer.WriteLine("result.Region = RegionEndpoint.GetBySystemName(regionName).SystemName;");
            });
        });

        writer.WriteLine();
        writer.WriteLine("// To support legacy endpoint overriding rules in the endpoints.json");
        writer.OpenBlock("if (result.Region == \"us-east-1-regional\")", () =>
        {
            writer.WriteLine("result.Region = \"us-east-1\";");
        });

        writer.WriteLine();
        writer.WriteLine("// Use AlternateEndpoint region override if set");
        writer.OpenBlock("if (requestContext.Request.AlternateEndpoint != null)", () =>
        {
            writer.WriteLine("result.Region = requestContext.Request.AlternateEndpoint.SystemName;");
        });
    }
}
