using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Writers.Serialization;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers.Serialization;

/// <summary>
/// Drives the request marshaller writer against a model whose inputs carry an <c>@httpQueryParams</c>
/// map member. Each map entry becomes a query parameter; a <c>list&lt;string&gt;</c> value repeats the
/// key. Explicit <c>@httpQuery</c> members are emitted first and win on a key collision.
/// </summary>
public class QueryParamsCodegenTests
{
    private const string ModelFileName = "query-params-model.json";

    private readonly GenerationContext _context;

    public QueryParamsCodegenTests()
    {
        _context = TestModels.Context("Codegen/query-params-model.json");
    }

    private string RequestMarshaller(string operationName)
    {
        var operation = _context.Operations.Single(o => o.Name == operationName);
        return new JsonRequestMarshallerWriter(_context, ModelFileName)
            .Write(operation, TestContext.Current.CancellationToken);
    }

    [Fact]
    public void RequestMarshaller_MapOfStringList_RepeatsKeyViaParameterCollection()
    {
        var marshaller = RequestMarshaller("ListScrapers");

        Assert.Contains("if (publicRequest.IsSetFilters())", marshaller);
        Assert.Contains("foreach (var kvp in publicRequest.Filters)", marshaller);
        Assert.Contains("if (!request.ParameterCollection.ContainsKey(kvp.Key))", marshaller);
        Assert.Contains("request.ParameterCollection.Add(kvp.Key, kvp.Value);", marshaller);

        // The map contributes to the query string.
        Assert.Contains("request.UseQueryString = true;", marshaller);

        // The map is a query binding, not a body member — no JSON body is emitted.
        Assert.DoesNotContain("""context.Writer.WritePropertyName("filters");""", marshaller);
        Assert.DoesNotContain("request.ContentStream", marshaller);
    }

    [Fact]
    public void RequestMarshaller_ExplicitHttpQuery_EmittedBeforeQueryParamsMap()
    {
        var marshaller = RequestMarshaller("ListScrapers");

        // Explicit @httpQuery members still marshal normally...
        Assert.Contains("""request.Parameters.Add("nextToken", StringUtils.FromString(publicRequest.NextToken));""", marshaller);
        Assert.Contains("""request.Parameters.Add("maxResults", StringUtils.FromInt(publicRequest.MaxResults.Value));""", marshaller);

        // ...and are emitted before the map loop, so a colliding key is already present and the map's
        // ContainsKey guard skips it — @httpQuery wins per the Smithy spec.
        var explicitIndex = marshaller.IndexOf("request.Parameters.Add(\"nextToken", StringComparison.Ordinal);
        var mapIndex = marshaller.IndexOf("foreach (var kvp in publicRequest.Filters)", StringComparison.Ordinal);
        Assert.True(explicitIndex >= 0 && mapIndex >= 0 && explicitIndex < mapIndex);
    }

    [Fact]
    public void RequestMarshaller_MapOfString_OneParamPerEntryViaParameters()
    {
        var marshaller = RequestMarshaller("Search");

        Assert.Contains("if (publicRequest.IsSetTags())", marshaller);
        Assert.Contains("foreach (var kvp in publicRequest.Tags)", marshaller);
        Assert.Contains("if (!request.Parameters.ContainsKey(kvp.Key))", marshaller);
        Assert.Contains("request.Parameters.Add(kvp.Key, StringUtils.FromString(kvp.Value));", marshaller);
        Assert.Contains("request.UseQueryString = true;", marshaller);
    }
}
