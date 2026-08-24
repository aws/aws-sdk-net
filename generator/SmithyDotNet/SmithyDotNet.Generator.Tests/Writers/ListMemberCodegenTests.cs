using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Writers;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers;

/// <summary>
/// Drives <see cref="JsonRequestMarshallerWriter"/> against the shared codegen model, whose DoLists
/// operation binds <c>list&lt;string&gt;</c> members in query and header positions.
/// <see cref="ScalarMemberCodegenTests"/> covers the scalar bindings; the rejection of
/// non-string element types is covered in <see cref="TypeMapperTests"/>.
/// </summary>
public class ListMemberCodegenTests
{
    private const string ModelFileName = "lists.json";

    private readonly GenerationContext _context;
    private readonly Operation _doLists;

    public ListMemberCodegenTests()
    {
        // DoLists' input carries three list<string> HTTP-binding members: a plain query (tagKeys), a
        // required query (requiredKeys), and a header (tokens).
        _context = TestModels.Context("Codegen/codegen-model.json");
        _doLists = _context.Operations.Single(o => o.Name == "DoLists");
    }

    private string RequestMarshaller => new JsonRequestMarshallerWriter(_context, ModelFileName)
        .Write(_doLists, TestContext.Current.CancellationToken);

    [Fact]
    public void RequestMarshaller_QueryStringList_AddsToParameterCollection()
    {
        // A list<string> query member adds the List<string> directly to the typed ParameterCollection
        // (repeated params, ordinal-sorted at runtime); request.Parameters is a string-only facade.
        var marshaller = RequestMarshaller;
        Assert.Contains("if (publicRequest.IsSetTagKeys())", marshaller);
        Assert.Contains("""request.ParameterCollection.Add("tagKeys", publicRequest.TagKeys);""", marshaller);
        // A non-required list gets no null guard, so this asserts the guard is absent.
        Assert.DoesNotContain("if (publicRequest.TagKeys == null)", marshaller);
    }

    [Fact]
    public void RequestMarshaller_RequiredQueryList_GuardsOnNull()
    {
        // A required list gets a null check (string.IsNullOrEmpty only applies to string members).
        var marshaller = RequestMarshaller;
        Assert.Contains("if (publicRequest.RequiredKeys == null)", marshaller);
        Assert.Contains("""throw new AmazonExampleException("Request object does not have required field RequiredKeys set");""", marshaller);
        // The guard precedes the same Add emission every list gets.
        Assert.Contains("""request.ParameterCollection.Add("requiredKeys", publicRequest.RequiredKeys);""", marshaller);
    }

    [Fact]
    public void RequestMarshaller_HeaderStringList_JoinsViaFromList()
    {
        // A list<string> header joins to one comma-separated value via StringUtils.FromList.
        var marshaller = RequestMarshaller;
        Assert.Contains("if (publicRequest.IsSetTokens())", marshaller);
        Assert.Contains("""request.Headers["x-tokens"] = StringUtils.FromList(publicRequest.Tokens);""", marshaller);
    }

    [Fact]
    public void RequestMarshaller_QueryList_SetsUseQueryString()
    {
        Assert.Contains("request.UseQueryString = true;", RequestMarshaller);
    }

    [Fact]
    public void RequestMarshaller_BodyLessListOp_OmitsContentType()
    {
        // Every member is a query/header binding, so there is no body and no Content-Type, matching C2J.
        Assert.DoesNotContain("""request.Headers["Content-Type"]""", RequestMarshaller);
    }
}
