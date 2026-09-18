using SmithyDotNet.Generator.Generation;

namespace SmithyDotNet.Generator.Writers.Service;

/// <summary>
/// Emits the C# source for a service's auth resolver (e.g.
/// <c>AmazonKeyManagementServiceAuthSchemeResolver</c>), which lives in the service's <c>.Internal</c>
/// namespace and contains three classes: the auth-scheme parameters (which include a <c>Region</c>
/// member only for SigV4-signing services), the handler that maps a request context into those
/// parameters, and the resolver whose <c>ResolveAuthScheme</c> switch returns the auth-scheme
/// option(s) for each operation.
/// <para />
/// Each switch arm returns the auth list modeled on that operation's <c>smithy.api#auth</c> trait;
/// the discard (<c>_</c>) arm returns the service-level list. For the services in
/// <see cref="EndpointAuthDelegatedServices"/> the handler first asks the endpoint resolver for the
/// auth schemes its rule set attached to the resolved endpoint; every other service returns the
/// modeled schemes directly.
/// </summary>
public sealed class AuthResolverWriter(GenerationContext context, string modelFileName)
{
    /// <summary>
    /// Services whose endpoint rule set selects the auth scheme (e.g. SigV4a for SESv2 multi-region
    /// endpoints). Many rule sets carry <c>authSchemes</c>, but C2J only delegates for these four
    /// (<c>ModeledResolver.partial.cs</c>), so the list is kept by name rather than derived from the rules.
    /// </summary>
    private static readonly HashSet<string> EndpointAuthDelegatedServices =
    [
        "S3",
        "EventBridge",
        "SimpleEmailServiceV2",
        "CloudFrontKeyValueStore",
    ];

    // The endpoint resolver type only exists when the model carries a rule set.
    private bool DelegatesToEndpoint =>
        context.HasEndpointRuleSet && EndpointAuthDelegatedServices.Contains(context.BaseName);

    /// <summary>
    /// Emits the complete formatted auth resolver source for the service.
    /// </summary>
    public string Write(CancellationToken cancellationToken = default)
    {
        var parametersName = $"{context.ClientName}AuthSchemeParameters";
        var handlerName = $"{context.ClientName}AuthSchemeHandler";
        var resolverName = $"{context.ClientName}AuthSchemeResolver";

        var writer = new CodeWriter();
        FileHeader.WriteLicense(writer, modelFileName);
        FileHeader.WriteUsings(writer, FileHeader.AuthResolverUsings);
        writer.OpenNamespace($"{context.Namespace}.Internal", () =>
        {
            WriteParameters(writer, parametersName);
            writer.WriteLine();
            WriteHandler(writer, handlerName, parametersName, resolverName);
            writer.WriteLine();
            WriteResolver(writer, resolverName, parametersName);
        });

        return writer.ToFormattedString(cancellationToken);
    }

    private void WriteParameters(CodeWriter writer, string parametersName)
    {
        writer.WriteLine("/// <inheritdoc cref=\"IAuthSchemeParameters\" />");
        writer.OpenBlock($"public class {parametersName} : IAuthSchemeParameters", () =>
        {
            writer.WriteLine("/// <inheritdoc />");
            writer.WriteLine("public string Operation { get; set; }");

            // SigV4-signing services resolve their auth scheme per region; token-only services do not
            // emit the parameter.
            if (context.SupportsSigV4)
            {
                writer.WriteLine();
                writer.WriteLine("/// <summary>");
                writer.WriteLine("/// Region is included as the service supports SigV4.");
                writer.WriteLine("/// </summary>");
                writer.WriteLine("public string Region { get; set; }");
            }
        });
    }

    private void WriteHandler(CodeWriter writer, string handlerName, string parametersName, string resolverName)
    {
        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Handler responsible for converting the request context into the parameters expected by the auth scheme resolver.");
        writer.WriteLine("/// </summary>");
        writer.OpenBlock($"public class {handlerName} : BaseAuthResolverHandler", () =>
        {
            if (DelegatesToEndpoint)
            {
                writer.WriteLine($"private readonly {context.ClientName}EndpointResolver _endpointResolver = new();");
                writer.WriteLine();
            }

            writer.WriteLine("/// <summary>");
            writer.WriteLine($"/// Modeled auth scheme resolver for {context.BaseName}.");
            writer.WriteLine("/// </summary>");
            writer.WriteLine($"public {resolverName} AuthSchemeResolver {{ get; }} = new();");
            writer.WriteLine();
            writer.WriteLine("/// <inheritdoc />");
            writer.OpenBlock("protected override List<IAuthSchemeOption> ResolveAuthOptions(IExecutionContext executionContext)", () =>
            {
                if (DelegatesToEndpoint)
                {
                    writer.WriteLine($"// Since {context.BaseName} includes auth schemes in its endpoint rules, we'll attempt to delegate resolution to the endpoint");
                    writer.WriteLine("// resolver first (falling back to the modeled resolver if no options are returned).");
                    writer.WriteLine("var endpoint = _endpointResolver.GetEndpoint(executionContext);");
                    writer.WriteLine();
                    writer.WriteLine("// This means the endpoints resolver is executed twice intentionally (at this point and then later in the pipeline");
                    writer.WriteLine("// to determine which endpoint the SDK should use for the request).");
                    writer.WriteLine("var endpointAuthSchemes = RetrieveSchemesFromEndpoint(endpoint);");
                    writer.OpenBlock("if (endpointAuthSchemes != null)", () =>
                    {
                        writer.WriteLine("return endpointAuthSchemes;");
                    });
                    writer.WriteLine();
                }

                writer.WriteLine("var requestContext = executionContext.RequestContext;");
                writer.OpenBlock($"var mappedParameters = new {parametersName}", "};", () =>
                {
                    writer.WriteLine("Operation = requestContext.Request.RequestName,");
                    if (context.SupportsSigV4)
                    {
                        writer.WriteLine("Region = requestContext.ClientConfig.RegionEndpoint?.SystemName,");
                    }
                });
                writer.WriteLine();
                writer.WriteLine("return AuthSchemeResolver.ResolveAuthScheme(mappedParameters);");
            });
        });
    }

    private void WriteResolver(CodeWriter writer, string resolverName, string parametersName)
    {
        writer.WriteLine($"/// <inheritdoc cref=\"IAuthSchemeResolver{{T}}\" />");
        writer.OpenBlock($"public class {resolverName} : IAuthSchemeResolver<{parametersName}>", () =>
        {
            writer.WriteLine("/// <inheritdoc />");
            writer.WriteLine($"public List<IAuthSchemeOption> ResolveAuthScheme({parametersName} authParameters) =>");
            writer.Indent(() =>
            {
                writer.OpenBlock("authParameters.Operation switch", "};", () =>
                {
                    foreach (var operation in context.OperationsWithModeledAuth)
                    {
                        WriteSwitchArm(writer, $"\"{operation.Name}Request\"", operation.Schemes);
                    }

                    WriteSwitchArm(writer, "_", context.ServiceAuthSchemes,
                        "// Default for the service, applies to all remaining operations.");
                });
            });
        });
    }

    // Emits one switch-expression arm: "<pattern> => <scheme>,". A known scheme list maps to its
    // AuthSchemeOption.DEFAULT_* constant; any other list maps to an inline List<IAuthSchemeOption>
    // with one entry per scheme. An optional comment is emitted above the arm (used to document the
    // discard arm's service-wide fallback behavior).
    private static void WriteSwitchArm(CodeWriter writer, string pattern, IReadOnlyList<string> schemes,
        string? comment = null)
    {
        if (comment is not null)
        {
            writer.WriteLine(comment);
        }

        if (AuthSchemeMapping.TryGetKnownDefault(schemes, out var knownDefault))
        {
            writer.WriteLine($"{pattern} => {knownDefault},");
            return;
        }

        writer.OpenBlock($"{pattern} => new List<IAuthSchemeOption>", "},", () =>
        {
            foreach (var scheme in schemes)
            {
                writer.WriteLine($"new AuthSchemeOption {{ SchemeId = {CodeWriter.Literal(scheme)} }},");
            }
        });
    }
}
