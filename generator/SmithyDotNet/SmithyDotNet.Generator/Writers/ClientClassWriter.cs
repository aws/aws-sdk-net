using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model.Traits;

namespace SmithyDotNet.Generator.Writers;

/// <summary>
/// Emits the C# source for the concrete service client (e.g. <c>AmazonCloudTrailDataClient</c>),
/// matching the public API surface of the existing AWS SDK for .NET. The client derives from
/// <see cref="Amazon.Runtime.AmazonServiceClient"/> and implements the service interface
/// (e.g. <c>IAmazonCloudTrailData</c>).
/// <para />
/// The client references sibling per-service types that are the responsibility of other writers —
/// the operation marshallers/unmarshallers, <c>Amazon{Service}Config</c>,
/// <c>Amazon{Service}Metadata</c>, and the <c>Amazon{Service}EndpointResolver</c> /
/// <c>Amazon{Service}AuthSchemeHandler</c>. This writer emits only the client class.
/// <para />
/// <c>CustomizeRuntimePipeline</c> emits the base handler set. Per-service pipeline handlers
/// (e.g. S3, EC2, SQS) come from <c>{service}.customizations.json</c>
/// (<c>runtimePipelineOverride.overrides</c>), which the Smithy model does not carry.
/// </summary>
public sealed class ClientClassWriter(GenerationContext context, string modelFileName)
{
    private readonly string _clientName = context.ClientName;
    private readonly string _configName = $"{context.ClientName}Config";

    // Built once per writer rather than per Write() call. Instance (not static like
    // FileHeader.ModelUsings) because the service Model namespaces are the only service-specific
    // entries. Mirrors the using set of the hand-written _bcl/_netstandard client.
    private readonly IReadOnlyList<string> _usings =
    [
        "System",
        "System.Runtime.ExceptionServices",
        "System.Threading",
        "System.Threading.Tasks",
        "System.Collections.Generic",
        "System.Net",
        $"{context.Namespace}.Model",
        $"{context.Namespace}.Model.Internal.MarshallTransformations",
        $"{context.Namespace}.Internal",
        "Amazon.Runtime",
        "Amazon.Runtime.Internal",
        "Amazon.Runtime.Internal.Auth",
        "Amazon.Runtime.Internal.Transform",
        "Amazon.Runtime.Endpoints",
    ];

    /// <summary>
    /// Emits the complete formatted client source for the service.
    /// </summary>
    public string Write(CancellationToken cancellationToken = default)
    {
        var writer = new CodeWriter();
        FileHeader.WriteLicense(writer, modelFileName);
        FileHeader.WriteUsings(writer, _usings);
        FileHeader.WritePragma(writer, ["CS1570"]);
        writer.OpenNamespace(context.Namespace, () =>
        {
            WriteClassDocumentation(writer);
            writer.OpenBlock($"public partial class {_clientName}Client : AmazonServiceClient, I{_clientName}", () =>
            {
                writer.WriteLine($"private static IServiceMetadata serviceMetadata = new {_clientName}Metadata();");

                WriteConstructors(writer);
                WriteOverrides(writer);
                WriteDispose(writer);

                foreach (var operation in context.Operations)
                {
                    WriteOperation(writer, operation);
                }

                WriteDetermineServiceOperationEndpoint(writer);
            });
        });

        return writer.ToFormattedString(cancellationToken);
    }

    private void WriteClassDocumentation(CodeWriter writer)
    {
        writer.WriteLine("/// <summary>");
        writer.WriteLine($"/// <para>Implementation for accessing {context.ServiceName}</para>");
        writer.WriteLine("/// <para>");
        writer.WriteLine("/// Service client instances are thread-safe and can be shared across multiple threads.");
        writer.WriteLine("/// For a given service configuration, it is recommended to reuse a client instance");
        writer.WriteLine("/// for the lifetime of your application.");
        writer.WriteLine("/// </para>");

        var cleaned = DocumentationFormatter.Cleanup(context.ServiceDocumentation);
        if (cleaned.Length > 0)
        {
            writer.WriteLine("///");
            DocumentationFormatter.WriteCommentBlock(writer, cleaned);
        }

        writer.WriteLine("/// </summary>");
    }

    private void WriteConstructors(CodeWriter writer)
    {
        var client = $"{_clientName}Client";
        var config = _configName;

        WriteCtorDoc(writer, DefaultCredentialsSummary());
        writer.WriteLine($"public {client}() : base(new {config}()) {{ }}");
        writer.WriteLine();

        WriteCtorDoc(writer, DefaultCredentialsSummary(), ("region", "The region to connect."));
        writer.WriteLine($"public {client}(RegionEndpoint region) : base(new {config} {{ RegionEndpoint = region }}) {{ }}");
        writer.WriteLine();

        WriteCtorDoc(writer, DefaultCredentialsSummary(), ("config", $"The {client} Configuration Object"));
        writer.WriteLine($"public {client}({config} config) : base(config) {{ }}");
        writer.WriteLine();

        WriteCtorDoc(writer, [$"Constructs {client} with AWS Credentials"], ("credentials", "AWS Credentials"));
        writer.WriteLine($"public {client}(AWSCredentials credentials)");
        writer.OpenBlock($"    : this(credentials, new {config}())", () => { });
        writer.WriteLine();

        WriteCtorDoc(writer, [$"Constructs {client} with AWS Credentials"], ("credentials", "AWS Credentials"), ("region", "The region to connect."));
        writer.WriteLine($"public {client}(AWSCredentials credentials, RegionEndpoint region)");
        writer.OpenBlock($"    : this(credentials, new {config} {{ RegionEndpoint = region }})", () => { });
        writer.WriteLine();

        WriteCtorDoc(writer, [$"Constructs {client} with AWS Credentials and an", $"{client} Configuration object."], ("credentials", "AWS Credentials"), ("clientConfig", $"The {client} Configuration Object"));
        writer.WriteLine($"public {client}(AWSCredentials credentials, {config} clientConfig)");
        writer.OpenBlock("    : base(credentials, clientConfig)", () => { });
        writer.WriteLine();

        WriteCtorDoc(writer, AccessKeySummary(), ("awsAccessKeyId", "AWS Access Key ID"), ("awsSecretAccessKey", "AWS Secret Access Key"));
        writer.WriteLine($"public {client}(string awsAccessKeyId, string awsSecretAccessKey)");
        writer.OpenBlock($"    : this(awsAccessKeyId, awsSecretAccessKey, new {config}())", () => { });
        writer.WriteLine();

        WriteCtorDoc(writer, AccessKeySummary(), ("awsAccessKeyId", "AWS Access Key ID"), ("awsSecretAccessKey", "AWS Secret Access Key"), ("region", "The region to connect."));
        writer.WriteLine($"public {client}(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)");
        writer.OpenBlock($"    : this(awsAccessKeyId, awsSecretAccessKey, new {config} {{ RegionEndpoint = region }})", () => { });
        writer.WriteLine();

        WriteCtorDoc(writer, [$"Constructs {client} with AWS Access Key ID, AWS Secret Key and an", $"{client} Configuration object. "], ("awsAccessKeyId", "AWS Access Key ID"), ("awsSecretAccessKey", "AWS Secret Access Key"), ("clientConfig", $"The {client} Configuration Object"));
        writer.WriteLine($"public {client}(string awsAccessKeyId, string awsSecretAccessKey, {config} clientConfig)");
        writer.OpenBlock("    : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)", () => { });
        writer.WriteLine();

        WriteCtorDoc(writer, AccessKeySummary(), ("awsAccessKeyId", "AWS Access Key ID"), ("awsSecretAccessKey", "AWS Secret Access Key"), ("awsSessionToken", "AWS Session Token"));
        writer.WriteLine($"public {client}(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)");
        writer.OpenBlock($"    : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new {config}())", () => { });
        writer.WriteLine();

        WriteCtorDoc(writer, AccessKeySummary(), ("awsAccessKeyId", "AWS Access Key ID"), ("awsSecretAccessKey", "AWS Secret Access Key"), ("awsSessionToken", "AWS Session Token"), ("region", "The region to connect."));
        writer.WriteLine($"public {client}(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)");
        writer.OpenBlock($"    : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new {config} {{ RegionEndpoint = region }})", () => { });
        writer.WriteLine();

        WriteCtorDoc(writer, [$"Constructs {client} with AWS Access Key ID, AWS Secret Key and an", $"{client} Configuration object. "], ("awsAccessKeyId", "AWS Access Key ID"), ("awsSecretAccessKey", "AWS Secret Access Key"), ("awsSessionToken", "AWS Session Token"), ("clientConfig", $"The {client} Configuration Object"));
        writer.WriteLine($"public {client}(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, {config} clientConfig)");
        writer.OpenBlock("    : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)", () => { });
        writer.WriteLine();
    }

    private string[] DefaultCredentialsSummary() =>
    [
        $"Constructs {_clientName}Client with the credentials loaded from the application's",
        "default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.",
        "",
        "Example App.config with credentials set. ",
        "<code>",
        "&lt;?xml version=\"1.0\" encoding=\"utf-8\" ?&gt;",
        "&lt;configuration&gt;",
        "    &lt;appSettings&gt;",
        "        &lt;add key=\"AWSProfileName\" value=\"AWS Default\"/&gt;",
        "    &lt;/appSettings&gt;",
        "&lt;/configuration&gt;",
        "</code>",
        "",
    ];

    private string[] AccessKeySummary() =>
    [
        $"Constructs {_clientName}Client with AWS Access Key ID and AWS Secret Key",
    ];

    private static void WriteCtorDoc(CodeWriter writer, string[] summaryLines, params (string Name, string Description)[] paramTags)
    {
        writer.WriteLine("/// <summary>");
        foreach (var line in summaryLines)
        {
            writer.WriteLine(line.Length == 0 ? "/// " : $"/// {line}");
        }

        writer.WriteLine("/// </summary>");
        foreach (var (name, description) in paramTags)
        {
            writer.WriteLine($"/// <param name=\"{name}\">{description}</param>");
        }
    }

    private void WriteOverrides(CodeWriter writer)
    {
        // The CustomizeRuntimePipeline doc text differs by TFM in the hand-written client (_bcl:
        // "Customize the pipeline" + empty <param>; _netstandard: "Customizes the runtime pipeline."
        // + populated <param>). The writer emits ONE doc for all TFMs rather than reproducing that
        // split: the wording is XML-doc-only (no API or behavior impact) and a single doc keeps the
        // generator simpler. Deliberate, documented cosmetic divergence from C2J; the fuller
        // _netstandard wording is the one kept.
        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Customizes the runtime pipeline.");
        writer.WriteLine("/// </summary>");
        writer.WriteLine("/// <param name=\"pipeline\">Runtime pipeline for the current client.</param>");
        writer.OpenBlock("protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)", () =>
        {
            // Base handler set, emitted for every service. Per-service extra handlers (e.g. S3,
            // EC2, SQS) come from {service}.customizations.json (runtimePipelineOverride.overrides),
            // which the Smithy model does not carry.
            writer.WriteLine("pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();");
            writer.WriteLine($"pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new {_clientName}EndpointResolver());");
            writer.WriteLine($"pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new {_clientName}AuthSchemeHandler());");
        });
        writer.WriteLine();

        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Capture metadata for the service.");
        writer.WriteLine("/// </summary>");
        writer.OpenBlock("protected override IServiceMetadata ServiceMetadata", () =>
        {
            writer.OpenBlock("get", () =>
            {
                writer.WriteLine("return serviceMetadata;");
            });
        });
        writer.WriteLine();
    }

    private static void WriteDispose(CodeWriter writer)
    {
        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Disposes the service client.");
        writer.WriteLine("/// </summary>");
        writer.OpenBlock("protected override void Dispose(bool disposing)", () =>
        {
            writer.WriteLine("base.Dispose(disposing);");
        });
        writer.WriteLine();
    }

    private void WriteOperation(CodeWriter writer, Operation operation)
    {
        var responseType = $"{operation.Name}Response";
        var requestType = $"{operation.Name}Request";

        // Synchronous method. The SDK ships it at different visibility per TFM: the _bcl client
        // exposes it as `public virtual` (with full docs), while the _netstandard client keeps it
        // `internal virtual` (no docs) to reduce the modern-TFM public surface. In this single-file
        // output that is a #if NETFRAMEWORK (public + docs) / #else (internal, no docs) pair. Both
        // arms share the same InvokeOptions body; the async overload below is unconditional.
        writer.WriteLine("#if NETFRAMEWORK");
        DocumentationFormatter.WriteOperationDocumentation(writer, context, operation, isAsync: false);
        writer.OpenBlock($"public virtual {responseType} {operation.Name}({requestType} request)", () =>
        {
            WriteInvokeOptions(writer, operation);
            writer.WriteLine($"return Invoke<{responseType}>(request, options);");
        });
        writer.WriteLine("#else");
        writer.OpenBlock($"internal virtual {responseType} {operation.Name}({requestType} request)", () =>
        {
            WriteInvokeOptions(writer, operation);
            writer.WriteLine($"return Invoke<{responseType}>(request, options);");
        });
        writer.WriteLine("#endif");
        writer.WriteLine();

        // Asynchronous method. Unconditional across all target frameworks.
        DocumentationFormatter.WriteOperationDocumentation(writer, context, operation, isAsync: true);
        writer.OpenBlock($"public virtual Task<{responseType}> {operation.Name}Async({requestType} request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))", () =>
        {
            WriteInvokeOptions(writer, operation);
            writer.WriteLine($"return InvokeAsync<{responseType}>(request, options, cancellationToken);");
        });
        writer.WriteLine();
    }

    private static void WriteInvokeOptions(CodeWriter writer, Operation operation)
    {
        writer.WriteLine("var options = new Amazon.Runtime.Internal.InvokeOptions();");
        writer.WriteLine($"options.RequestMarshaller = {operation.Name}RequestMarshaller.Instance;");
        writer.WriteLine($"options.ResponseUnmarshaller = {operation.Name}ResponseUnmarshaller.Instance;");
        writer.WriteLine();
    }

    private static void WriteDetermineServiceOperationEndpoint(CodeWriter writer)
    {
        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Returns the endpoint that will be used for a particular request.");
        writer.WriteLine("/// </summary>");
        writer.WriteLine("/// <param name=\"request\">Request for the desired service operation.</param>");
        writer.WriteLine("/// <returns>The resolved endpoint for the given request.</returns>");
        writer.OpenBlock("public Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request)", () =>
        {
            writer.WriteLine("var parameters = new ServiceOperationEndpointParameters(request);");
            writer.WriteLine("return Config.DetermineServiceOperationEndpoint(parameters);");
        });
    }
}
