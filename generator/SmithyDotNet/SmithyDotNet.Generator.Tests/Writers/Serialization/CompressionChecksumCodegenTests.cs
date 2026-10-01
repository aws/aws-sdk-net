using SmithyDotNet.Generator.Writers.Serialization;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers.Serialization;

/// <summary>
/// Drives <see cref="JsonRequestMarshallerWriter"/> against <c>@requestCompression</c> and the legacy
/// <c>@httpChecksumRequired</c>, pinning both calls and their placement against C2J's
/// <c>PutWithContentEncoding</c> and <c>HttpChecksumRequired</c> marshallers in RestJsonProtocol.
/// </summary>
public class CompressionChecksumCodegenTests
{
    private const string ModelFileName = "example-2023-01-01.normal.json";

    private const string CompressionCall = "CompressionAlgorithmUtils.SetCompressionAlgorithm(request, CompressionEncodingAlgorithm.gzip);";
    private const string ChecksumCall = "ChecksumUtils.SetChecksumData(request);";

    private static string Marshaller(string operationName)
    {
        var context = TestModels.Context("Codegen/compression-checksum-model.json");
        var operation = context.Operations.Single(o => o.Name == operationName);
        return new JsonRequestMarshallerWriter(context, ModelFileName)
            .Write(operation, TestContext.Current.CancellationToken);
    }

    private static int IndexOf(string source, string value) => source.IndexOf(value, StringComparison.Ordinal);

    [Fact]
    public void RequestCompression_EmitsCallBeforeAnyHeader()
    {
        var m = Marshaller("DoCompression");

        Assert.Contains(CompressionCall, m);
        Assert.True(IndexOf(m, "new DefaultRequest(") < IndexOf(m, CompressionCall));
        Assert.True(IndexOf(m, CompressionCall) < IndexOf(m, """request.Headers["Content-Type"]"""));
    }

    [Fact]
    public void HttpChecksumRequired_EmitsCallAfterBodySerialization()
    {
        var m = Marshaller("DoChecksum");

        Assert.Contains(ChecksumCall, m);
        Assert.True(IndexOf(m, "writer.Flush();") < IndexOf(m, ChecksumCall));
    }

    [Fact]
    public void NeitherTrait_EmitsNoCompressionOrChecksumCall()
    {
        var m = Marshaller("DoNeither");

        Assert.DoesNotContain("CompressionAlgorithmUtils", m);
        Assert.DoesNotContain("ChecksumUtils", m);
    }

    [Fact]
    public void MixedEncodings_SkipsUnsupportedAndEmitsGzip()
    {
        Assert.Contains(CompressionCall, Marshaller("DoMixedEncodings"));
    }

    [Fact]
    public void NoSupportedEncoding_Throws()
    {
        var exception = Assert.Throws<GeneratorException>(() => Marshaller("DoUnsupportedEncoding"));

        Assert.Contains("'br'", exception.Message);
    }

    [Fact]
    public void CompressionWithFixedLengthStreamPayload_Throws()
    {
        var exception = Assert.Throws<GeneratorException>(() => Marshaller("DoCompressedFixedLengthStream"));

        Assert.Contains("@requiresLength", exception.Message);
    }
}
