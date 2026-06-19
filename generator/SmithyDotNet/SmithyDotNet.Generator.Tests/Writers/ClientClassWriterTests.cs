using SmithyDotNet.Generator.Writers;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers;

[Collection(nameof(CloudTrailModelCollection))]
public class ClientClassWriterTests
{
    private const string ModelFileName = "cloudtrail-data-2021-08-11.normal.json";

    private readonly string _output;

    public ClientClassWriterTests(CloudTrailModelFixture fixture)
    {
        var writer = new ClientClassWriter(fixture.Context, ModelFileName);
        _output = writer.Write(TestContext.Current.CancellationToken);
    }

    [Fact]
    public void EmitsClassDeclarationInServiceNamespace()
    {
        // Service-level namespace, NOT the .Model namespace (the client is interface-writer-shaped).
        Assert.Contains("namespace Amazon.CloudTrailData", _output);
        Assert.DoesNotContain("namespace Amazon.CloudTrailData.Model", _output);
        Assert.Contains("public partial class AmazonCloudTrailDataClient : AmazonServiceClient, IAmazonCloudTrailData", _output);
    }

    [Fact]
    public void EmitsClassSummaryWithImplementationPreambleAndThreadSafetyAndDoc()
    {
        // Generator-added preamble specific to the implementation class (distinct from the interface's
        // "Interface for accessing").
        Assert.Contains("<para>Implementation for accessing CloudTrailData</para>", _output);
        // Thread-safety paragraph, generator-added.
        Assert.Contains("Service client instances are thread-safe and can be shared across multiple threads.", _output);
        // Service-level @documentation, cleaned.
        Assert.Contains("The CloudTrail Data Service lets you ingest events", _output);
    }

    [Fact]
    public void EmitsServiceMetadataField()
    {
        // References the Amazon{Svc}Metadata sibling type emitted by the service-metadata writer.
        Assert.Contains("private static IServiceMetadata serviceMetadata = new AmazonCloudTrailDataMetadata();", _output);
    }

    [Fact]
    public void EmitsParameterlessConstructorChainingToConfig()
    {
        Assert.Contains("public AmazonCloudTrailDataClient()", _output);
        Assert.Contains(": base(new AmazonCloudTrailDataConfig())", _output);
    }

    [Fact]
    public void EmitsRegionEndpointConstructor()
    {
        Assert.Contains("public AmazonCloudTrailDataClient(RegionEndpoint region)", _output);
        // Brace spacing is Roslyn-formatter-determined (the existing C2J-generated client has tight braces; the
        // formatter normalizes to spaced). Whitespace inside the initializer is not load-bearing surface
        // and is stripped by the GATE B normalized diff.
        Assert.Contains(": base(new AmazonCloudTrailDataConfig { RegionEndpoint = region })", _output);
    }

    [Fact]
    public void EmitsConfigConstructor()
    {
        Assert.Contains("public AmazonCloudTrailDataClient(AmazonCloudTrailDataConfig config)", _output);
    }

    [Fact]
    public void EmitsCredentialsConstructors()
    {
        Assert.Contains("public AmazonCloudTrailDataClient(AWSCredentials credentials)", _output);
        Assert.Contains("public AmazonCloudTrailDataClient(AWSCredentials credentials, RegionEndpoint region)", _output);
        Assert.Contains("public AmazonCloudTrailDataClient(AWSCredentials credentials, AmazonCloudTrailDataConfig clientConfig)", _output);
    }

    [Fact]
    public void EmitsAccessKeyConstructors()
    {
        Assert.Contains("public AmazonCloudTrailDataClient(string awsAccessKeyId, string awsSecretAccessKey)", _output);
        Assert.Contains("public AmazonCloudTrailDataClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)", _output);
        Assert.Contains("public AmazonCloudTrailDataClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCloudTrailDataConfig clientConfig)", _output);
    }

    [Fact]
    public void EmitsSessionTokenConstructors()
    {
        Assert.Contains("public AmazonCloudTrailDataClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)", _output);
        Assert.Contains("public AmazonCloudTrailDataClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)", _output);
        Assert.Contains("public AmazonCloudTrailDataClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCloudTrailDataConfig clientConfig)", _output);
    }

    [Fact]
    public void EmitsAllTwelveConstructors()
    {
        // The existing C2J-generated client has exactly 12 constructors, all unconditional (identical across both TFMs).
        Assert.Equal(12, System.Text.RegularExpressions.Regex.Count(_output, @"public AmazonCloudTrailDataClient\("));
    }

    [Fact]
    public void EmitsCustomizeRuntimePipelineOverrideReferencingDeferredHandlers()
    {
        Assert.Contains("protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)", _output);
        Assert.Contains("pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();", _output);
        // References the Amazon{Svc}EndpointResolver / Amazon{Svc}AuthSchemeHandler sibling types emitted by the endpoint/auth writers.
        Assert.Contains("pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonCloudTrailDataEndpointResolver());", _output);
        Assert.Contains("pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonCloudTrailDataAuthSchemeHandler());", _output);
    }

    [Fact]
    public void EmitsSingleCustomizeRuntimePipelineDocForAllTargetFrameworks()
    {
        // The CustomizeRuntimePipeline doc text differs by TFM in the hand-written SDK (_bcl:
        // "Customize the pipeline" + empty <param>; _netstandard: "Customizes the runtime pipeline."
        // + populated <param>). Per generator-owner review, the writer emits ONE doc for all TFMs
        // rather than reproducing that per-TFM split: the wording is XML-doc-only (no API or behavior
        // impact), and a single doc keeps the generator simpler. This is a deliberate, documented
        // cosmetic divergence from the C2J output. The fuller _netstandard wording is the one emitted.
        Assert.Contains("/// Customizes the runtime pipeline.", _output);
        Assert.Contains("/// <param name=\"pipeline\">Runtime pipeline for the current client.</param>", _output);

        // The _bcl-only wording and its empty <param> are not emitted.
        Assert.DoesNotContain("/// Customize the pipeline", _output);
        Assert.DoesNotContain("/// <param name=\"pipeline\"></param>", _output);

        // The doc block carries no preprocessor guard. The only #if NETFRAMEWORK in the file is the
        // sync-method-visibility split, which sits after CustomizeRuntimePipeline.
        var pipelineDocIndex = _output.IndexOf("/// Customizes the runtime pipeline.", System.StringComparison.Ordinal);
        var firstIfIndex = _output.IndexOf("#if NETFRAMEWORK", System.StringComparison.Ordinal);
        Assert.True(firstIfIndex > pipelineDocIndex, "CustomizeRuntimePipeline doc must not be guarded by #if; the first #if (sync visibility) comes later in the file.");
    }

    [Fact]
    public void EmitsServiceMetadataOverride()
    {
        Assert.Contains("protected override IServiceMetadata ServiceMetadata", _output);
        Assert.Contains("return serviceMetadata;", _output);
    }

    [Fact]
    public void EmitsDisposeOverride()
    {
        Assert.Contains("protected override void Dispose(bool disposing)", _output);
        Assert.Contains("base.Dispose(disposing);", _output);
    }

    [Fact]
    public void EmitsAsynchronousOperationMethodWiringInvokeAsync()
    {
        Assert.Contains(
            "public virtual Task<PutAuditEventsResponse> PutAuditEventsAsync(PutAuditEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))",
            _output);
        // Operation body wires InvokeOptions with the marshaller/unmarshaller sibling types emitted by the marshaller writer.
        Assert.Contains("options.RequestMarshaller = PutAuditEventsRequestMarshaller.Instance;", _output);
        Assert.Contains("options.ResponseUnmarshaller = PutAuditEventsResponseUnmarshaller.Instance;", _output);
        Assert.Contains("return InvokeAsync<PutAuditEventsResponse>(request, options, cancellationToken);", _output);
    }

    [Fact]
    public void EmitsSynchronousOperationMethodWiringInvoke()
    {
        Assert.Contains("public virtual PutAuditEventsResponse PutAuditEvents(PutAuditEventsRequest request)", _output);
        Assert.Contains("return Invoke<PutAuditEventsResponse>(request, options);", _output);
    }

    [Fact]
    public void EmitsOperationDocumentationAndExceptionTags()
    {
        Assert.Contains("Ingests your application events into CloudTrail Lake.", _output);
        Assert.Contains("<param name=\"request\">Container for the necessary parameters to execute the PutAuditEvents service method.</param>", _output);
        Assert.Contains("<returns>The response from the PutAuditEvents service method, as returned by CloudTrailData.</returns>", _output);
        Assert.Contains("<exception cref=\"Amazon.CloudTrailData.Model.ChannelNotFoundException\">", _output);
        Assert.Contains("<exception cref=\"Amazon.CloudTrailData.Model.UnsupportedOperationException\">", _output);
        Assert.Contains("<seealso href=\"http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-data-2021-08-11/PutAuditEvents\">REST API Reference for PutAuditEvents Operation</seealso>", _output);
    }

    [Fact]
    public void EmitsDetermineServiceOperationEndpoint()
    {
        Assert.Contains("public Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request)", _output);
        Assert.Contains("var parameters = new ServiceOperationEndpointParameters(request);", _output);
        Assert.Contains("return Config.DetermineServiceOperationEndpoint(parameters);", _output);
    }

    [Fact]
    public void GuardsSynchronousOperationMethodWithNetFrameworkDirective()
    {
        // The synchronous overload differs by TFM in the SDK: the _bcl client exposes it as
        // `public virtual` (with docs), the _netstandard client as `internal virtual` (no docs).
        // In a single generated file that is a #if NETFRAMEWORK (public) / #else (internal) pair;
        // the async overload is unconditional and must fall outside the guard entirely.
        Assert.Contains("#if NETFRAMEWORK", _output);

        // Anchor on the #if NETFRAMEWORK that guards the sync method by locating the public sync
        // signature first, then the directive immediately preceding it. (This sync-visibility split is
        // now the only #if in the file; CustomizeRuntimePipeline emits a single unguarded doc.)
        var publicSyncIndex = _output.IndexOf("public virtual PutAuditEventsResponse PutAuditEvents(PutAuditEventsRequest request)", System.StringComparison.Ordinal);
        var internalSyncIndex = _output.IndexOf("internal virtual PutAuditEventsResponse PutAuditEvents(PutAuditEventsRequest request)", System.StringComparison.Ordinal);
        var asyncIndex = _output.IndexOf("public virtual Task<PutAuditEventsResponse> PutAuditEventsAsync(", System.StringComparison.Ordinal);
        var ifIndex = _output.LastIndexOf("#if NETFRAMEWORK", publicSyncIndex, System.StringComparison.Ordinal);
        var elseIndex = _output.IndexOf("#else", publicSyncIndex, System.StringComparison.Ordinal);
        var endifIndex = _output.IndexOf("#endif", elseIndex, System.StringComparison.Ordinal);

        // The public sync method sits in the #if NETFRAMEWORK arm.
        Assert.InRange(publicSyncIndex, ifIndex, elseIndex);
        // The internal sync method sits in the #else arm.
        Assert.InRange(internalSyncIndex, elseIndex, endifIndex);
        // The asynchronous method sits outside (after) the guard.
        Assert.True(asyncIndex > endifIndex, "Async method must not be inside the #if NETFRAMEWORK guard.");
    }

    [Fact]
    public void EmitsNetstandardInternalSyncOverloadInElseBranch()
    {
        // The _netstandard client ships the sync overload as `internal virtual` with NO doc comment
        // (existing C2J client, _netstandard:261), a universal C2J convention; the _bcl form is `public virtual` with
        // docs. The single-file writer emits both via #if NETFRAMEWORK / #else, so the netstandard build
        // keeps the internal overload rather than dropping the sync method entirely.
        Assert.Contains("internal virtual PutAuditEventsResponse PutAuditEvents(PutAuditEventsRequest request)", _output);

        // The internal overload carries the same InvokeOptions body and Invoke<T> call as the public one.
        var internalSyncIndex = _output.IndexOf("internal virtual PutAuditEventsResponse PutAuditEvents(PutAuditEventsRequest request)", System.StringComparison.Ordinal);
        var bodyTail = _output.IndexOf("return Invoke<PutAuditEventsResponse>(request, options);", internalSyncIndex, System.StringComparison.Ordinal);
        Assert.True(bodyTail > internalSyncIndex, "Internal sync overload must wire InvokeOptions and call Invoke<T>.");
    }

    [Fact]
    public void EmitsLicenseAndPragmaHeader()
    {
        Assert.Contains("Do not modify this file. This file is generated from the cloudtrail-data-2021-08-11.normal.json service model.", _output);
        Assert.Contains("#pragma warning disable CS1570", _output);
    }

    [Fact]
    public void OmitsRegionDirectivesMatchingMergedWriterFamily()
    {
        // The merged StructureWriter, ExceptionWriter, and ClientInterfaceWriter emit no #region
        // blocks, even though the existing C2J clients carry them (the existing C2J interface has 2; the interface
        // writer drops them). #region markers are IDE-navigation scaffolding, not customer-facing
        // API surface, and the existing C2J client's own region spacing is internally inconsistent
        // (#region Constructors = one space, #region  PutAuditEvents = two). The client writer
        // follows the merged family and emits none; region scaffolding is a localized add if a
        // reviewer later wants it for navigability on large clients.
        Assert.DoesNotContain("#region", _output);
        Assert.DoesNotContain("#endregion", _output);
    }
}
