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
