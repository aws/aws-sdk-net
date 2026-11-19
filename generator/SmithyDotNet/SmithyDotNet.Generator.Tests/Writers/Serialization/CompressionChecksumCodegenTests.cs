using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Generation.Customizations;
using SmithyDotNet.Generator.Writers.Serialization;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers.Serialization;

/// <summary>
/// Drives <see cref="JsonRequestMarshallerWriter"/> against <c>@requestCompression</c>, the legacy
/// <c>@httpChecksumRequired</c> and <c>aws.protocols#httpChecksum</c>, pinning the calls and their placement against
/// C2J's <c>PutWithContentEncoding</c> and <c>HttpChecksumRequired</c> marshallers in RestJsonProtocol and S3's
/// <c>PutBucketTagging</c>.
/// </summary>
public class CompressionChecksumCodegenTests
{
    private const string ModelFileName = "example-2023-01-01.normal.json";

    private const string CompressionCall = "CompressionAlgorithmUtils.SetCompressionAlgorithm(request, CompressionEncodingAlgorithm.gzip);";
    private const string ChecksumCall = "ChecksumUtils.SetChecksumData(request);";

    private static string Marshaller(string operationName) => Marshaller(TestModels.Context("Codegen/compression-checksum-model.json"), operationName);

    private static string Marshaller(GenerationContext context, string operationName)
    {
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
    public void HttpChecksum_AlgorithmMember_EmitsSelectableCallAfterBodySerialization()
    {
        var m = Marshaller("DoFlexibleChecksum");

        Assert.Contains("ChecksumUtils.SetChecksumData(", m);
        Assert.Contains("publicRequest.ChecksumAlgorithm,", m);
        Assert.Contains("isRequestChecksumRequired: true,", m);
        Assert.Contains("""
            headerName: "x-amz-sdk-checksum-algorithm"
            """, m);
        Assert.True(IndexOf(m, "writer.Flush();") < IndexOf(m, "ChecksumUtils.SetChecksumData("));
    }

    [Fact]
    public void HttpChecksum_RequiredWithoutAlgorithmMember_EmitsDefaultAlgorithmCall()
    {
        var m = Marshaller("DoRequiredChecksum");

        Assert.Contains("ChecksumUtils.SetChecksumData(request, checksumAlgorithm: null, fallbackToMD5: false, isRequestChecksumRequired: true);", m);
    }

    [Fact]
    public void HttpChecksum_ResponseValidationOnly_EmitsNoCall()
    {
        Assert.DoesNotContain("ChecksumUtils", Marshaller("DoValidatedChecksum"));
    }

    [Fact]
    public void HttpChecksum_AlgorithmMemberMissing_Throws()
    {
        var exception = Assert.Throws<GeneratorException>(() => Marshaller("DoDanglingAlgorithmMember"));
        Assert.Contains("'missing'", exception.Message);
    }

    [Fact]
    public void SkipChecksumDuringMarshalling_EmitsNoCall()
    {
        var customizations = new CustomizationsModel();
        customizations.OperationModifiers["DoFlexibleChecksum"] = new OperationModifier { SkipChecksumDuringMarshalling = true };
        var context = TestModels.Context(TestModels.Load("Codegen/compression-checksum-model.json"), customizations);

        Assert.DoesNotContain("ChecksumUtils", Marshaller(context, "DoFlexibleChecksum"));
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
