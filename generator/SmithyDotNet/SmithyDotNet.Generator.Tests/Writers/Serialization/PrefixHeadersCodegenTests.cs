using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Writers.Serialization;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers.Serialization;

/// <summary>
/// Drives the request marshaller and response/exception unmarshaller writers against a model whose
/// members carry <c>@httpPrefixHeaders</c> (modeled on dataExchange's SendApiAsset). Each map entry is
/// a header named <c>{prefix}{key}</c> on the request; on a response the matching-prefix headers are
/// collected back into the map with the prefix stripped.
/// </summary>
public class PrefixHeadersCodegenTests
{
    private const string ModelFileName = "prefix-headers-model.json";

    private readonly GenerationContext _context;

    public PrefixHeadersCodegenTests()
    {
        _context = TestModels.Context("Codegen/prefix-headers-model.json");
    }

    [Fact]
    public void RequestMarshaller_PrefixHeaders_EmitOneHeaderPerEntry()
    {
        var operation = _context.Operations.Single(o => o.Name == "SendApiAsset");
        var marshaller = new JsonRequestMarshallerWriter(_context, ModelFileName)
            .Write(operation, TestContext.Current.CancellationToken);

        Assert.Contains("if (publicRequest.IsSetRequestHeaders())", marshaller);
        Assert.Contains("foreach (var kvp in publicRequest.RequestHeaders)", marshaller);
        Assert.Contains("""request.Headers[$"x-amzn-dataexchange-header-{kvp.Key}"] = kvp.Value;""", marshaller);

        // The map is a header binding, not a body member.
        Assert.DoesNotContain("""context.Writer.WritePropertyName("requestHeaders");""", marshaller);
    }

    [Fact]
    public void RequestMarshaller_ExplicitHttpHeader_EmittedAfterPrefixHeaders()
    {
        var operation = _context.Operations.Single(o => o.Name == "SendApiAsset");
        var marshaller = new JsonRequestMarshallerWriter(_context, ModelFileName)
            .Write(operation, TestContext.Current.CancellationToken);

        // The explicit @httpHeader assetId still marshals...
        Assert.Contains("""request.Headers["x-amzn-dataexchange-asset-id"] = publicRequest.AssetId;""", marshaller);

        // ...and is emitted after the prefix-header loop, so on a name collision (only possible with an
        // empty prefix) its assignment overwrites the prefix-header value — @httpHeader wins per spec.
        var prefixIndex = marshaller.IndexOf("foreach (var kvp in publicRequest.RequestHeaders)", StringComparison.Ordinal);
        var headerIndex = marshaller.IndexOf("request.Headers[\"x-amzn-dataexchange-asset-id\"]", StringComparison.Ordinal);
        Assert.True(prefixIndex >= 0 && headerIndex >= 0 && prefixIndex < headerIndex);
    }

    [Fact]
    public void ResponseUnmarshaller_PrefixHeaders_CollectMatchingHeadersStrippingPrefix()
    {
        var operation = _context.Operations.Single(o => o.Name == "SendApiAsset");
        var unmarshaller = new JsonResponseUnmarshallerWriter(_context, ModelFileName)
            .Write(operation, TestContext.Current.CancellationToken);

        Assert.Contains("var headersForResponseHeaders = new Dictionary<string, string>();", unmarshaller);
        Assert.Contains("foreach (var headerName in context.ResponseData.GetHeaderNames())", unmarshaller);
        Assert.Contains("""if ("x-amzn-dataexchange-header-".Length > 0 && keyToUse.StartsWith("x-amzn-dataexchange-header-"))""", unmarshaller);
        Assert.Contains("""keyToUse = keyToUse.Substring("x-amzn-dataexchange-header-".Length);""", unmarshaller);
        Assert.Contains("""if (context.ResponseData.IsHeaderPresent($"x-amzn-dataexchange-header-{keyToUse}"))""", unmarshaller);
        Assert.Contains("""headersForResponseHeaders.Add(keyToUse, context.ResponseData.GetHeaderValue($"x-amzn-dataexchange-header-{keyToUse}"));""", unmarshaller);
        Assert.Contains("if (headersForResponseHeaders.Count > 0)", unmarshaller);
        Assert.Contains("unmarshalledObject.ResponseHeaders = headersForResponseHeaders;", unmarshaller);

        // The @httpPayload string body is still read as the whole payload.
        Assert.Contains("unmarshalledObject.Body = sr.ReadToEnd();", unmarshaller);
    }

    [Fact]
    public void ExceptionUnmarshaller_PrefixHeaders_CollectedFromResponseHeaders()
    {
        // @httpPrefixHeaders is valid on error structures too (Smithy spec), so the exception
        // unmarshaller collects them the same way rather than failing loud.
        var errorId = ShapeId.Parse("com.example#ThrottlingError");
        var unmarshaller = new JsonExceptionUnmarshallerWriter(_context, ModelFileName)
            .Write(_context.Errors[errorId], errorId, TestContext.Current.CancellationToken);

        Assert.Contains("var headersForRetryAfterHeaders = new Dictionary<string, string>();", unmarshaller);
        Assert.Contains("""if (context.ResponseData.IsHeaderPresent($"x-amzn-ratelimit-{keyToUse}"))""", unmarshaller);
        Assert.Contains("unmarshalledObject.RetryAfterHeaders = headersForRetryAfterHeaders;", unmarshaller);
    }
}
