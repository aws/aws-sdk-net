using SmithyDotNet.Generator.Writers;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers;

[Collection(nameof(CloudTrailModelCollection))]
public class ClientInterfaceWriterTests
{
    private const string ModelFileName = "cloudtrail-data-2021-08-11.normal.json";

    private readonly string _output;

    public ClientInterfaceWriterTests(CloudTrailModelFixture fixture)
    {
        var writer = new ClientInterfaceWriter(fixture.Context, ModelFileName);
        _output = writer.Write(TestContext.Current.CancellationToken);
    }

    [Fact]
    public void EmitsInterfaceDeclarationInServiceNamespace()
    {
        Assert.Contains("namespace Amazon.CloudTrailData", _output);
        Assert.Contains("public partial interface IAmazonCloudTrailData : IAmazonService, IDisposable", _output);
    }

    [Fact]
    public void EmitsServiceSummaryWithPreambleAndDocumentation()
    {
        // Generator-added preamble, not from the model.
        Assert.Contains("<para>Interface for accessing CloudTrailData</para>", _output);
        // Service-level @documentation, cleaned.
        Assert.Contains("The CloudTrail Data Service lets you ingest events", _output);
    }

    [Fact]
    public void EmitsSynchronousOperationSignature()
    {
        Assert.Contains("PutAuditEventsResponse PutAuditEvents(PutAuditEventsRequest request);", _output);
    }

    [Fact]
    public void EmitsAsynchronousOperationSignature()
    {
        Assert.Contains(
            "Task<PutAuditEventsResponse> PutAuditEventsAsync(PutAuditEventsRequest request, CancellationToken cancellationToken = default(CancellationToken));",
            _output);
    }

    [Fact]
    public void EmitsOperationDocumentationAndRequestParam()
    {
        Assert.Contains("Ingests your application events into CloudTrail Lake.", _output);
        Assert.Contains("<param name=\"request\">Container for the necessary parameters to execute the PutAuditEvents service method.</param>", _output);
        Assert.Contains("<returns>The response from the PutAuditEvents service method, as returned by CloudTrailData.</returns>", _output);
    }

    [Fact]
    public void EmitsAnExceptionTagPerOperationError()
    {
        // PutAuditEvents declares six errors; each must surface as an <exception cref> on both overloads.
        Assert.Contains("<exception cref=\"Amazon.CloudTrailData.Model.ChannelNotFoundException\">", _output);
        Assert.Contains("<exception cref=\"Amazon.CloudTrailData.Model.UnsupportedOperationException\">", _output);
        // Six distinct error types × two overloads (sync + async) = 12 exception tags.
        Assert.Equal(12, System.Text.RegularExpressions.Regex.Count(_output, "<exception cref="));
    }

    [Fact]
    public void EmitsAsyncParamDocAndSeeAlso()
    {
        Assert.Contains("<param name=\"cancellationToken\">", _output);
        Assert.Contains("<seealso href=\"http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-data-2021-08-11/PutAuditEvents\">REST API Reference for PutAuditEvents Operation</seealso>", _output);
    }

    [Fact]
    public void EmitsDetermineServiceOperationEndpoint()
    {
        // Declared unconditionally in both C2J interface variants (_bcl and _netstandard); part of
        // the public API surface of every service interface.
        Assert.Contains("Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);", _output);
    }

    // IAmazonService declares static abstract factory members behind NET8_0_OR_GREATER
    // (IAmazonService.cs); every service interface must implement them or the net8.0 build of any
    // consumer fails with CS0535. The C2J generator emits them as explicit static interface
    // implementations on the service interface (see the checked-in _netstandard variant); consumed
    // by AWSSDK.Extensions.NETCore.Setup for dependency-injection client construction.
    [Fact]
    public void EmitsNet8StaticFactoryMembers()
    {
        Assert.Contains("#if NET8_0_OR_GREATER", _output);
        Assert.Contains("static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonCloudTrailDataConfig();", _output);
        Assert.Contains("static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)", _output);
        Assert.Contains("new AmazonCloudTrailDataClient(serviceClientConfig)", _output);
        Assert.Contains("new AmazonCloudTrailDataClient(awsCredentials, serviceClientConfig)", _output);
    }

    [Fact]
    public void StaticFactoryMembersCarryTrimmingAndAnalyzerAnnotations()
    {
        // DynamicDependency keeps the config's public properties through trimming (the DI path
        // reflects over them); the IL2026 suppression and CA1033 pragma mirror IAmazonService's own.
        Assert.Contains("[System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonCloudTrailDataConfig))]", _output);
        Assert.Contains("""[System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",""", _output);
        Assert.Contains("#pragma warning disable CA1033", _output);
        Assert.Contains("#pragma warning restore CA1033", _output);
    }

    [Fact]
    public void GuardsSynchronousOverloadWithNetFrameworkDirective()
    {
        // The synchronous overload exists only on .NET Framework in the SDK (C2J emits it in the
        // _bcl file only). In a single generated file it must be wrapped in #if NETFRAMEWORK ... #endif;
        // the async overload is unconditional and must fall outside the guard.
        Assert.Contains("#if NETFRAMEWORK", _output);

        var ifIndex = _output.IndexOf("#if NETFRAMEWORK", System.StringComparison.Ordinal);
        var endifIndex = _output.IndexOf("#endif", ifIndex, System.StringComparison.Ordinal);
        var syncIndex = _output.IndexOf("PutAuditEventsResponse PutAuditEvents(PutAuditEventsRequest request);", System.StringComparison.Ordinal);
        var asyncIndex = _output.IndexOf("Task<PutAuditEventsResponse> PutAuditEventsAsync(", System.StringComparison.Ordinal);

        // The synchronous signature sits inside the guard.
        Assert.InRange(syncIndex, ifIndex, endifIndex);
        // The asynchronous signature sits outside (after) the guard.
        Assert.True(asyncIndex > endifIndex, "Async overload must not be inside the #if NETFRAMEWORK guard.");
    }
}
