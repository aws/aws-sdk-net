using SmithyDotNet.Generator.Generation;

namespace SmithyDotNet.Generator.Writers;

/// <summary>
/// Emits the C# source for a service's auth resolver (e.g.
/// <c>AmazonKeyManagementServiceAuthSchemeResolver</c>), which lives in the service's <c>.Internal</c>
/// namespace and contains three classes: the auth-scheme parameters (which include a <c>Region</c>
/// member only for SigV4-signing services), the handler that maps a request context into those
/// parameters, and the resolver whose <c>ResolveAuthScheme</c> switch returns the auth-scheme
/// option(s) for each operation.
/// <para />
/// Each switch arm returns the auth list modeled on that operation's <c>smithy.api#auth</c> trait;
/// the discard (<c>_</c>) arm returns the service-level list. The resolver returns the modeled schemes
/// directly and does not evaluate an endpoint rule set.
/// </summary>
public sealed class AuthResolverWriter(GenerationContext context, string modelFileName)
{
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
            writer.WriteLine("/// <summary>");
            writer.WriteLine($"/// Modeled auth scheme resolver for {context.ServiceName}.");
            writer.WriteLine("/// </summary>");
            writer.WriteLine($"public {resolverName} AuthSchemeResolver {{ get; }} = new();");
            writer.WriteLine();
            writer.WriteLine("/// <inheritdoc />");
            writer.OpenBlock("protected override List<IAuthSchemeOption> ResolveAuthOptions(IExecutionContext executionContext)", () =>
            {
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
