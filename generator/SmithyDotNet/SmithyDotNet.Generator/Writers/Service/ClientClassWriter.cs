using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Generation.Customizations;
using SmithyDotNet.Generator.Generation.Operations;
using SmithyDotNet.Generator.Model.Shapes;

namespace SmithyDotNet.Generator.Writers.Service;

/// <summary>
/// Emits the C# source for the concrete service client (e.g. <c>AmazonCloudTrailDataClient</c>),
/// matching the public API surface of the existing AWS SDK for .NET. The client derives from
/// <c>Amazon.Runtime.AmazonServiceClient</c> and implements the service interface
/// (e.g. <c>IAmazonCloudTrailData</c>).
/// <para />
/// The client references sibling per-service types that are the responsibility of other writers —
/// the operation marshallers/unmarshallers, <c>Amazon{Service}Config</c>,
/// <c>Amazon{Service}Metadata</c>, and the <c>Amazon{Service}EndpointResolver</c> /
/// <c>Amazon{Service}AuthSchemeHandler</c>. This writer emits only the client class.
/// <para />
/// <c>CustomizeRuntimePipeline</c> emits the service's <c>runtimePipelineOverride</c> handlers, then the base handler set.
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

                if (context.HasPaginators)
                {
                    WritePaginatorsProperty(writer);
                }

                // A service whose endpoint isn't region-derived hand-writes its own constructors
                // under Custom\ and sets generate-client-constructors:false; the client is one
                // partial class, so emitting ours as well is CS0111 (mediastore-data,
                // iot-jobs-data, kinesis-video-archived-media, kinesis-video-media).
                if (context.Metadata?.GenerateClientConstructors ?? true)
                {
                    WriteConstructors(writer);
                }

                WriteOverrides(writer);
                WriteDispose(writer);

                if (context.EndpointDiscoveryOperation is { } discoveryOperation)
                {
                    WriteEndpointOperation(writer, discoveryOperation);
                }

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
        writer.WriteLine($"/// <para>Implementation for accessing {context.BaseName}</para>");
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

        DocumentationFormatter.WriteConstructorDocumentation(writer,DefaultCredentialsSummary());
        writer.WriteLine($"public {client}() : base(new {config}()) {{ }}");
        writer.WriteLine();

        DocumentationFormatter.WriteConstructorDocumentation(writer,DefaultCredentialsSummary(), ("region", "The region to connect."));
        writer.WriteLine($"public {client}(RegionEndpoint region) : base(new {config} {{ RegionEndpoint = region }}) {{ }}");
        writer.WriteLine();

        DocumentationFormatter.WriteConstructorDocumentation(writer,DefaultCredentialsSummary(), ("config", $"The {client} Configuration Object"));
        writer.WriteLine($"public {client}({config} config) : base(config) {{ }}");
        writer.WriteLine();

        DocumentationFormatter.WriteConstructorDocumentation(writer,[$"Constructs {client} with AWS Credentials"], ("credentials", "AWS Credentials"));
        writer.WriteLine($"public {client}(AWSCredentials credentials)");
        writer.OpenBlock($"    : this(credentials, new {config}())", () => { });
        writer.WriteLine();

        DocumentationFormatter.WriteConstructorDocumentation(writer,[$"Constructs {client} with AWS Credentials"], ("credentials", "AWS Credentials"), ("region", "The region to connect."));
        writer.WriteLine($"public {client}(AWSCredentials credentials, RegionEndpoint region)");
        writer.OpenBlock($"    : this(credentials, new {config} {{ RegionEndpoint = region }})", () => { });
        writer.WriteLine();

        DocumentationFormatter.WriteConstructorDocumentation(writer,[$"Constructs {client} with AWS Credentials and an", $"{client} Configuration object."], ("credentials", "AWS Credentials"), ("clientConfig", $"The {client} Configuration Object"));
        writer.WriteLine($"public {client}(AWSCredentials credentials, {config} clientConfig)");
        writer.OpenBlock("    : base(credentials, clientConfig)", () => { });
        writer.WriteLine();

        DocumentationFormatter.WriteConstructorDocumentation(writer,AccessKeySummary(), ("awsAccessKeyId", "AWS Access Key ID"), ("awsSecretAccessKey", "AWS Secret Access Key"));
        writer.WriteLine($"public {client}(string awsAccessKeyId, string awsSecretAccessKey)");
        writer.OpenBlock($"    : this(awsAccessKeyId, awsSecretAccessKey, new {config}())", () => { });
        writer.WriteLine();

        DocumentationFormatter.WriteConstructorDocumentation(writer,AccessKeySummary(), ("awsAccessKeyId", "AWS Access Key ID"), ("awsSecretAccessKey", "AWS Secret Access Key"), ("region", "The region to connect."));
        writer.WriteLine($"public {client}(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)");
        writer.OpenBlock($"    : this(awsAccessKeyId, awsSecretAccessKey, new {config} {{ RegionEndpoint = region }})", () => { });
        writer.WriteLine();

        DocumentationFormatter.WriteConstructorDocumentation(writer,[$"Constructs {client} with AWS Access Key ID, AWS Secret Key and an", $"{client} Configuration object. "], ("awsAccessKeyId", "AWS Access Key ID"), ("awsSecretAccessKey", "AWS Secret Access Key"), ("clientConfig", $"The {client} Configuration Object"));
        writer.WriteLine($"public {client}(string awsAccessKeyId, string awsSecretAccessKey, {config} clientConfig)");
        writer.OpenBlock("    : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)", () => { });
        writer.WriteLine();

        DocumentationFormatter.WriteConstructorDocumentation(writer,AccessKeySummary(), ("awsAccessKeyId", "AWS Access Key ID"), ("awsSecretAccessKey", "AWS Secret Access Key"), ("awsSessionToken", "AWS Session Token"));
        writer.WriteLine($"public {client}(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)");
        writer.OpenBlock($"    : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new {config}())", () => { });
        writer.WriteLine();

        DocumentationFormatter.WriteConstructorDocumentation(writer,AccessKeySummary(), ("awsAccessKeyId", "AWS Access Key ID"), ("awsSecretAccessKey", "AWS Secret Access Key"), ("awsSessionToken", "AWS Session Token"), ("region", "The region to connect."));
        writer.WriteLine($"public {client}(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)");
        writer.OpenBlock($"    : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new {config} {{ RegionEndpoint = region }})", () => { });
        writer.WriteLine();

        DocumentationFormatter.WriteConstructorDocumentation(writer,[$"Constructs {client} with AWS Access Key ID, AWS Secret Key and an", $"{client} Configuration object. "], ("awsAccessKeyId", "AWS Access Key ID"), ("awsSecretAccessKey", "AWS Secret Access Key"), ("awsSessionToken", "AWS Session Token"), ("clientConfig", $"The {client} Configuration Object"));
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
            foreach (var entry in context.Customizations.RuntimePipelineOverride?.Overrides ?? [])
            {
                var method = entry.Operation switch
                {
                    PipelineOverride.AddBefore => "AddHandlerBefore",
                    PipelineOverride.AddAfter => "AddHandlerAfter",
                    PipelineOverride.Replace => "ReplaceHandler",
                    _ => throw new GeneratorException($"Pipeline override operation '{entry.Operation}' is not supported."),
                };
                var call = $"pipeline.{method}<{entry.TargetType}>(new {entry.NewType}({entry.ConstructorInput}));";

                // As in C2J, an empty condition means none.
                if (string.IsNullOrEmpty(entry.Condition))
                {
                    writer.WriteLine(call);
                }
                else
                {
                    writer.OpenBlock($"if ({entry.Condition})", () => writer.WriteLine(call));
                }
            }

            // The endpoint-resolver swap exists only for services with an endpoint rule set (test
            // services have none), matching C2J.
            if (context.HasEndpointRuleSet)
            {
                writer.WriteLine("pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();");
                writer.WriteLine($"pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new {_clientName}EndpointResolver());");
            }

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

    // Core calls this on an endpoint cache miss or refresh (C2J ServiceClientsNetStandard.tt). It shares the
    // discovery operation's HTTP/2 guard, since it calls that operation.
    private void WriteEndpointOperation(CodeWriter writer, Operation discoveryOperation)
    {
        var endpoints = DiscoveryMember(TypeMapper.ResolveMembers(discoveryOperation.Output, context), discoveryOperation.Output, "Endpoints");
        var endpointShape = endpoints.Type.ListElement?.Target as StructureShape
            ?? throw new GeneratorException($"Endpoint discovery: '{discoveryOperation.Output.Id.Name}.Endpoints' is not a list of structures.");

        // Passed straight to Core's DiscoveryEndpoint(string, long), so a dataTypeSwap here could not compile.
        var endpointMembers = TypeMapper.ResolveMembers(endpointShape, context);
        var address = DiscoveryMember(endpointMembers, endpointShape, "Address", "string").PropertyName;
        var cachePeriod = DiscoveryMember(endpointMembers, endpointShape, "CachePeriodInMinutes", "long?").PropertyName;

        if (discoveryOperation.RequiresHttp2)
        {
            writer.WriteLine("#if NET8_0_OR_GREATER");
        }

        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Resolve endpoint for service api request.");
        writer.WriteLine("/// </summary>");
        writer.OpenBlock("protected override IEnumerable<DiscoveryEndpointBase> EndpointOperation(EndpointOperationContextBase context)", () =>
        {
            writer.OpenBlock("return EndpointDiscoveryResolver.ResolveEndpoints(context, () =>", "});", () =>
            {
                writer.WriteLine($"var response = {discoveryOperation.Name}(new {discoveryOperation.Name}Request());");
                writer.OpenBlock($"if (response.HttpStatusCode != HttpStatusCode.OK || response.{endpoints.PropertyName} == null)", () =>
                {
                    writer.WriteLine("return null;");
                });
                writer.WriteLine();
                writer.WriteLine("var endpoints = new List<DiscoveryEndpointBase>();");
                writer.OpenBlock($"foreach (var endpoint in response.{endpoints.PropertyName})", () =>
                {
                    writer.WriteLine($"endpoints.Add(new DiscoveryEndpoint(endpoint.{address}, endpoint.{cachePeriod}.GetValueOrDefault()));");
                });
                writer.WriteLine();
                writer.WriteLine("return endpoints;");
            });
        });

        if (discoveryOperation.RequiresHttp2)
        {
            writer.WriteLine("#endif");
        }
        writer.WriteLine();
    }

    // The Smithy spec fixes these member names, which a rename doesn't change.
    private static Member DiscoveryMember(List<Member> members, StructureShape shape, string name, string? requiredType = null)
    {
        var member = members.FirstOrDefault(m => m.ModeledName == name)
            ?? throw new GeneratorException($"Endpoint discovery: '{shape.Id.Name}' has no '{name}' member.");

        if (requiredType is not null && member.Type.DotNetType != requiredType)
        {
            throw new GeneratorException($"Endpoint discovery: '{shape.Id.Name}.{name}' is '{member.Type.DotNetType}', but must be '{requiredType}'.");
        }

        return member;
    }

    private void WriteOperation(CodeWriter writer, Operation operation)
    {
        var responseType = $"{operation.Name}Response";
        var requestType = $"{operation.Name}Request";

        // HTTP/2 operations exist only on net8+ (h2 is unavailable on .NET Framework and pre-net8
        // netstandard); C2J omits them there entirely, so guard the whole operation.
        if (operation.RequiresHttp2)
        {
            writer.WriteLine("#if NET8_0_OR_GREATER");
        }

        // Synchronous method. The SDK ships it at different visibility per TFM: the _bcl client
        // exposes it as `public virtual` (with full docs), while the _netstandard client keeps it
        // `internal virtual` (no docs) to reduce the modern-TFM public surface. In this single-file
        // output that is a #if NETFRAMEWORK (public + docs) / #else (internal, no docs) pair. Both
        // arms share the same InvokeOptions body; the async overload below is emitted on every target
        // (unless the whole operation is h2-guarded above).
        var obsolete = TypeMapper.BuildObsolete(operation.Shape);

        writer.WriteLine("#if NETFRAMEWORK");
        DocumentationFormatter.WriteOperationDocumentation(writer, context, operation, isAsync: false);
        if (obsolete is not null)
        {
            writer.WriteLine(obsolete);
        }
        writer.OpenBlock($"public virtual {responseType} {operation.Name}({requestType} request)", () =>
        {
            WriteInvokeOptions(writer, operation);
            writer.WriteLine($"return Invoke<{responseType}>(request, options);");
        });
        writer.WriteLine("#else");
        if (obsolete is not null)
        {
            writer.WriteLine(obsolete);
        }
        writer.OpenBlock($"internal virtual {responseType} {operation.Name}({requestType} request)", () =>
        {
            WriteInvokeOptions(writer, operation);
            writer.WriteLine($"return Invoke<{responseType}>(request, options);");
        });
        writer.WriteLine("#endif");
        writer.WriteLine();

        // Asynchronous method. Emitted on every target framework (the h2 guard above, when present,
        // still excludes it below net8).
        DocumentationFormatter.WriteOperationDocumentation(writer, context, operation, isAsync: true);
        if (obsolete is not null)
        {
            writer.WriteLine(obsolete);
        }
        writer.OpenBlock($"public virtual Task<{responseType}> {operation.Name}Async({requestType} request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))", () =>
        {
            WriteInvokeOptions(writer, operation);
            writer.WriteLine($"return InvokeAsync<{responseType}>(request, options, cancellationToken);");
        });

        // Convenience overloads (simpleMethods, then noArgOverloads) sit inside the same h2 guard as the
        // operation they wrap, so they are excluded below net8 along with it.
        WriteSimpleMethods(writer, operation, obsolete);
        WriteNoArgOverloads(writer, operation, obsolete);

        if (operation.RequiresHttp2)
        {
            writer.WriteLine("#endif");
        }
        writer.WriteLine();
    }

    // simpleMethods: for each form, a sync overload (NETFRAMEWORK-only `public virtual`) and an async
    // overload (all targets), each building the request from the positional parameters and delegating to
    // the request-taking method. C2J emits no netstandard sync simple method, so the sync overload is
    // guarded without an #else.
    private void WriteSimpleMethods(CodeWriter writer, Operation operation, string? obsolete)
    {
        if (context.Customizations.MethodFormsFor(operation.Name) is not { } forms)
        {
            return;
        }

        var responseType = $"{operation.Name}Response";
        var requestType = $"{operation.Name}Request";
        var members = TypeMapper.ResolveMembers(operation.Input, context);

        foreach (var form in forms)
        {
            var formMembers = ConvenienceMembers.Resolve(form, members);
            var parameters = ConvenienceMembers.ParameterList(formMembers, remapStream: true);
            var paramTags = formMembers.Select(m => (SdkNaming.ToParameterName(m.PropertyName), DocumentationFormatter.ParamDocForOperation(m.Documentation, operation.Name))).ToList();

            void WriteBody(string delegateCall)
            {
                writer.WriteLine($"var request = new {requestType}();");
                foreach (var member in formMembers)
                {
                    writer.WriteLine($"request.{member.PropertyName} = {SdkNaming.ToParameterName(member.PropertyName)};");
                }

                writer.WriteLine(delegateCall);
            }

            writer.WriteLine();
            writer.WriteLine("#if NETFRAMEWORK");
            DocumentationFormatter.WriteOperationDocumentation(writer, context, operation, isAsync: false, parameters: paramTags);
            if (obsolete is not null)
            {
                writer.WriteLine(obsolete);
            }
            writer.OpenBlock($"public virtual {responseType} {operation.Name}({parameters})", () => WriteBody($"return {operation.Name}(request);"));
            writer.WriteLine("#endif");

            writer.WriteLine();
            DocumentationFormatter.WriteOperationDocumentation(writer, context, operation, isAsync: true, parameters: paramTags);
            if (obsolete is not null)
            {
                writer.WriteLine(obsolete);
            }

            var asyncParameters = parameters.Length > 0 ? $"{parameters}, " : parameters;
            writer.OpenBlock($"public virtual Task<{responseType}> {operation.Name}Async({asyncParameters}System.Threading.CancellationToken cancellationToken = default(CancellationToken))", () => WriteBody($"return {operation.Name}Async(request, cancellationToken);"));
        }
    }

    // noArgOverloads: a parameterless sync overload (public on NETFRAMEWORK, internal elsewhere, mirroring
    // the request-taking method's visibility split) and a parameterless async overload (all targets), each
    // delegating with a fresh empty request.
    private void WriteNoArgOverloads(CodeWriter writer, Operation operation, string? obsolete)
    {
        if (!context.Customizations.CreateNoArgOverload(operation.Name))
        {
            return;
        }

        var responseType = $"{operation.Name}Response";
        var requestType = $"{operation.Name}Request";

        writer.WriteLine();
        writer.WriteLine("#if NETFRAMEWORK");
        DocumentationFormatter.WriteOperationDocumentation(writer, context, operation, isAsync: false, parameters: []);
        if (obsolete is not null)
        {
            writer.WriteLine(obsolete);
        }
        writer.OpenBlock($"public virtual {responseType} {operation.Name}()", () => writer.WriteLine($"return {operation.Name}(new {requestType}());"));
        writer.WriteLine("#else");
        if (obsolete is not null)
        {
            writer.WriteLine(obsolete);
        }
        writer.OpenBlock($"internal virtual {responseType} {operation.Name}()", () => writer.WriteLine($"return {operation.Name}(new {requestType}());"));
        writer.WriteLine("#endif");

        writer.WriteLine();
        DocumentationFormatter.WriteOperationDocumentation(writer, context, operation, isAsync: true, parameters: []);
        if (obsolete is not null)
        {
            writer.WriteLine(obsolete);
        }
        writer.OpenBlock($"public virtual Task<{responseType}> {operation.Name}Async(System.Threading.CancellationToken cancellationToken = default(CancellationToken))", () => writer.WriteLine($"return {operation.Name}Async(new {requestType}(), cancellationToken);"));
    }

    private void WriteInvokeOptions(CodeWriter writer, Operation operation)
    {
        writer.WriteLine("var options = new Amazon.Runtime.Internal.InvokeOptions();");
        writer.WriteLine($"options.RequestMarshaller = {operation.Name}RequestMarshaller.Instance;");
        writer.WriteLine($"options.ResponseUnmarshaller = {operation.Name}ResponseUnmarshaller.Instance;");
        if (context.DiscoveredOperations.ContainsKey(operation.Shape.Id))
        {
            writer.WriteLine($"options.EndpointDiscoveryMarshaller = {operation.Name}EndpointDiscoveryMarshaller.Instance;");
            writer.WriteLine("options.EndpointOperation = EndpointOperation;");
        }
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

    private void WritePaginatorsProperty(CodeWriter writer)
    {
        var factoryInterface = $"I{context.ServiceName}PaginatorFactory";
        var factoryClass = $"{context.ServiceName}PaginatorFactory";

        writer.WriteLine($"private {factoryInterface} _paginators;");
        writer.WriteLine();
        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Paginators for the service");
        writer.WriteLine("/// </summary>");
        writer.OpenBlock($"public {factoryInterface} Paginators", () =>
        {
            writer.OpenBlock("get", () =>
            {
                writer.OpenBlock("if (this._paginators == null)", () =>
                {
                    writer.WriteLine($"this._paginators = new {factoryClass}(this);");
                });
                writer.WriteLine("return this._paginators;");
            });
        });
    }
}
