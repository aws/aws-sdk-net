using SmithyDotNet.Generator.Generation;

namespace SmithyDotNet.Generator.Writers;

/// <summary>
/// Emits the C# source for the public service interface (e.g. <c>IAmazonCloudTrailData</c>),
/// matching the public API surface of the existing AWS SDK for .NET. The interface declares a
/// synchronous and asynchronous method pair per operation, with doc comments.
/// </summary>
public sealed class ClientInterfaceWriter(GenerationContext context, string modelFileName)
{
    // Built once per writer rather than per Write() call. Instance (not static like
    // FileHeader.ModelUsings) because the service Model namespace is the only service-specific entry.
    private readonly IReadOnlyList<string> _usings =
    [
        "System",
        "System.Threading",
        "System.Threading.Tasks",
        "System.Collections.Generic",
        "Amazon.Runtime",
        $"{context.Namespace}.Model",
    ];

    /// <summary>
    /// Emits the complete formatted interface source for the service.
    /// </summary>
    public string Write(CancellationToken cancellationToken = default)
    {
        var writer = new CodeWriter();
        FileHeader.WriteLicense(writer, modelFileName);
        FileHeader.WriteUsings(writer, _usings);
        FileHeader.WritePragma(writer, ["CS1570"]);
        writer.OpenNamespace(context.Namespace, () =>
        {
            WriteInterfaceDocumentation(writer);
            writer.OpenBlock($"public partial interface I{context.ClientName} : IAmazonService, IDisposable", () =>
            {
                for (var i = 0; i < context.Operations.Count; i++)
                {
                    if (i > 0)
                    {
                        writer.WriteLine();
                    }

                    WriteOperation(writer, context.Operations[i]);
                }

                writer.WriteLine();
                WriteDetermineServiceOperationEndpoint(writer);
                writer.WriteLine();
                WriteStaticFactoryMethods(writer);
            });
        });

        return writer.ToFormattedString(cancellationToken);
    }

    private static void WriteDetermineServiceOperationEndpoint(CodeWriter writer)
    {
        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Returns the endpoint that will be used for a particular request.");
        writer.WriteLine("/// </summary>");
        writer.WriteLine("""/// <param name="request">Request for the desired service operation.</param>""");
        writer.WriteLine("/// <returns>The resolved endpoint for the given request.</returns>");
        writer.WriteLine("Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);");
    }

    // IAmazonService declares these as static abstract behind NET8_0_OR_GREATER, so every service
    // interface must implement them or any net8.0 consumer fails with CS0535. They are consumed by
    // AWSSDK.Extensions.NETCore.Setup to construct clients registered in the dependency-injection
    // container.
    private void WriteStaticFactoryMethods(CodeWriter writer)
    {
        var configType = $"{context.ClientName}Config";
        var clientType = $"{context.ClientName}Client";

        writer.WriteLine("#if NET8_0_OR_GREATER");
        writer.WriteLine("// Warning CA1033 is issued when the child types can not call the method defined in parent types.");
        writer.WriteLine("// In this use case the intended caller is only meant to be the interface as a factory");
        writer.WriteLine("// method to create the child types. Given the SDK use case the warning can be ignored.");
        writer.WriteLine("#pragma warning disable CA1033");
        writer.WriteLine("/// <inheritdoc/>");
        // DynamicDependency keeps the config's public properties through trimming; the DI setup
        // path binds them via reflection.
        writer.WriteLine($"[System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof({configType}))]");
        writer.WriteLine($"static ClientConfig IAmazonService.CreateDefaultClientConfig() => new {configType}();");
        writer.WriteLine();
        writer.WriteLine("/// <inheritdoc/>");
        writer.WriteLine("""[System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",""");
        writer.WriteLine("""    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]""");
        writer.OpenBlock("static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)", () =>
        {
            writer.WriteLine($"var serviceClientConfig = clientConfig as {configType};");
            writer.OpenBlock("if (serviceClientConfig == null)", () =>
            {
                writer.WriteLine($"""throw new AmazonClientException("ClientConfig is not of type {configType} to create {clientType}");""");
            });
            writer.WriteLine();
            writer.WriteLine("return awsCredentials == null ?");
            writer.WriteLine($"        new {clientType}(serviceClientConfig) :");
            writer.WriteLine($"        new {clientType}(awsCredentials, serviceClientConfig);");
        });
        writer.WriteLine("#pragma warning restore CA1033");
        writer.WriteLine("#endif");
    }

    private void WriteInterfaceDocumentation(CodeWriter writer)
    {
        writer.WriteLine("/// <summary>");
        writer.WriteLine($"/// <para>Interface for accessing {context.ServiceName}</para>");

        var cleaned = DocumentationFormatter.Cleanup(context.ServiceDocumentation);
        if (cleaned.Length > 0)
        {
            writer.WriteLine("///");
            DocumentationFormatter.WriteCommentBlock(writer, cleaned);
        }

        writer.WriteLine("/// </summary>");
    }

    private void WriteOperation(CodeWriter writer, Operation operation)
    {
        var responseType = $"{operation.Name}Response";
        var requestType = $"{operation.Name}Request";

        // Synchronous overload. The synchronous API surface exists only on .NET Framework (the C2J
        // generator emits it in the _bcl file, which is excluded from the netstandard/net builds), so
        // guard it with #if NETFRAMEWORK in this single-file output.
        writer.WriteLine("#if NETFRAMEWORK");
        DocumentationFormatter.WriteOperationDocumentation(writer, context, operation, isAsync: false);
        writer.WriteLine($"{responseType} {operation.Name}({requestType} request);");
        writer.WriteLine("#endif");
        writer.WriteLine();

        // Asynchronous overload.
        DocumentationFormatter.WriteOperationDocumentation(writer, context, operation, isAsync: true);
        writer.WriteLine($"Task<{responseType}> {operation.Name}Async({requestType} request, CancellationToken cancellationToken = default(CancellationToken));");
    }

}
