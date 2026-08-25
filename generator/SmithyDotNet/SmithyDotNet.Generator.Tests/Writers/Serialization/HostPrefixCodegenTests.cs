using Microsoft.CodeAnalysis.CSharp;
using SmithyDotNet.Generator.Writers.Serialization;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers.Serialization;

/// <summary>
/// Drives <see cref="JsonRequestMarshallerWriter"/> against operations that carry an <c>@endpoint</c>
/// host prefix, verifying <c>request.HostPrefix</c> is set (and its <c>@hostLabel</c> members validated
/// and interpolated) to match the legacy C2J output. The resolver's already-emitted
/// <c>InjectHostPrefix</c> consumes it.
/// </summary>
public class HostPrefixCodegenTests
{
    private const string ModelFileName = "example-2023-01-01.normal.json";

    private static string Marshaller(string operationName)
    {
        var context = TestModels.Context("Codegen/hostprefix-model.json");
        var operation = context.Operations.Single(o => o.Name == operationName);
        return new JsonRequestMarshallerWriter(context, ModelFileName)
            .Write(operation, TestContext.Current.CancellationToken);
    }

    [Fact]
    public void HostPrefixWithLabel_EmitsValidatedInterpolatedPrefix()
    {
        var m = Marshaller("DoHostPrefixWithLabel");

        // hostPrefixLabels anon object: keyed on the modeled name, value via StringUtils.FromString on
        // the property name.
        Assert.Contains("var hostPrefixLabels = new", m);
        Assert.Contains("name = StringUtils.FromString(publicRequest.Name),", m);

        // Each label is validated with the exact C2J message and base exception.
        Assert.Contains("if (!HostPrefixUtils.IsValidLabelValue(hostPrefixLabels.name))", m);
        Assert.Contains("""throw new AmazonExampleException("name can only contain alphanumeric characters and dashes and must be between 1 and 63 characters long.");""", m);

        // {name} is interpolated as {hostPrefixLabels.name}.
        Assert.Contains("""request.HostPrefix = $"foo.{hostPrefixLabels.name}.";""", m);

        // The host-label member is additive — it is still marshalled in its normal (body) binding.
        Assert.Contains("""context.Writer.WritePropertyName("name");""", m);
    }

    [Fact]
    public void HostPrefixNoLabel_EmitsLiteralPrefixWithoutLabels()
    {
        var m = Marshaller("DoHostPrefixNoLabel");

        Assert.Contains("""request.HostPrefix = $"data.";""", m);
        Assert.DoesNotContain("hostPrefixLabels", m);
        Assert.DoesNotContain("HostPrefixUtils", m);
    }

    [Fact]
    public void HostPrefixMultipleLabels_ValidatesAndInterpolatesEach()
    {
        var m = Marshaller("DoHostPrefixMultiLabel");

        // Each label gets its own anon-object entry, validation, and interpolation.
        Assert.Contains("a = StringUtils.FromString(publicRequest.A),", m);
        Assert.Contains("b = StringUtils.FromString(publicRequest.B),", m);
        Assert.Contains("if (!HostPrefixUtils.IsValidLabelValue(hostPrefixLabels.a))", m);
        Assert.Contains("if (!HostPrefixUtils.IsValidLabelValue(hostPrefixLabels.b))", m);
        Assert.Contains("""request.HostPrefix = $"{hostPrefixLabels.a}-{hostPrefixLabels.b}.";""", m);
    }

    [Fact]
    public void HostLabelAlsoHttpLabel_MarshalsToBothUriAndHostPrefix()
    {
        var m = Marshaller("DoHostPrefixHttpLabel");

        // The member is additive: bound to the URI path (@httpLabel) AND the host prefix (@hostLabel).
        Assert.Contains("""request.AddPathResource("{id}", StringUtils.FromString(publicRequest.Id));""", m);
        Assert.Contains("id = StringUtils.FromString(publicRequest.Id),", m);
        Assert.Contains("""request.HostPrefix = $"foo.{hostPrefixLabels.id}.";""", m);
    }

    [Fact]
    public void HostLabelAlsoHttpHeader_MarshalsToBothHeaderAndHostPrefix()
    {
        var m = Marshaller("DoHostPrefixHeaderLabel");

        // The member is additive: bound to a request header (@httpHeader) AND the host prefix (@hostLabel).
        Assert.Contains("""request.Headers["x-account"] = publicRequest.Account;""", m);
        Assert.Contains("account = StringUtils.FromString(publicRequest.Account),", m);
        Assert.Contains("""request.HostPrefix = $"{hostPrefixLabels.account}.";""", m);
    }

    [Fact]
    public void HostPrefix_EmittedAfterUseQueryString()
    {
        // request.HostPrefix is emitted last — after request.UseQueryString — matching C2J's ordering.
        var m = Marshaller("DoHostPrefixHeaderLabel");

        var queryIndex = m.IndexOf("request.UseQueryString", StringComparison.Ordinal);
        var hostPrefixIndex = m.IndexOf("request.HostPrefix", StringComparison.Ordinal);
        Assert.True(queryIndex >= 0, "expected request.UseQueryString to be emitted");
        Assert.True(hostPrefixIndex >= 0, "expected request.HostPrefix to be emitted");
        Assert.True(queryIndex < hostPrefixIndex, "request.HostPrefix must be emitted after request.UseQueryString");
    }

    [Fact]
    public void NoEndpointTrait_EmitsNoHostPrefix()
    {
        var m = Marshaller("DoNoHostPrefix");

        Assert.DoesNotContain("request.HostPrefix", m);
        Assert.DoesNotContain("hostPrefixLabels", m);
    }

    [Theory]
    [InlineData("DoHostPrefixWithLabel")]   // one anon field, one interpolation hole
    [InlineData("DoHostPrefixMultiLabel")]  // multiple anon fields, multiple holes
    [InlineData("DoHostPrefixNoLabel")]     // zero-hole $"..." literal, no anon object
    public void HostPrefixOutput_ParsesWithoutDiagnostics(string operationName)
    {
        // The interpolated $"..." prefix and the anon-object initializer are string-built, so guard
        // against a malformed emission that ToFormattedString would not reject.
        var m = Marshaller(operationName);

        var tree = CSharpSyntaxTree.ParseText(m, cancellationToken: TestContext.Current.CancellationToken);
        Assert.Empty(tree.GetDiagnostics(cancellationToken: TestContext.Current.CancellationToken));
    }
}
