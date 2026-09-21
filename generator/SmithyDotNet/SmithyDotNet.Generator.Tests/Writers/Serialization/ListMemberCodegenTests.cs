using System.Text.Json;
using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Generation.Operations;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Writers.Serialization;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers.Serialization;

/// <summary>
/// Drives <see cref="JsonRequestMarshallerWriter"/> and <see cref="JsonResponseUnmarshallerWriter"/>
/// against the shared codegen model, whose DoLists operation binds list members (string, int, and
/// timestamp elements) in query and header positions on both the request and the response.
/// <see cref="ScalarMemberCodegenTests"/> covers the scalar bindings.
/// </summary>
public class ListMemberCodegenTests
{
    private const string ModelFileName = "lists.json";

    private readonly GenerationContext _context;
    private readonly Operation _doLists;

    public ListMemberCodegenTests()
    {
        // DoLists binds list HTTP members in query and header positions: string lists (tagKeys query,
        // required requiredKeys query, tokens header), value-type lists (counts query, amounts header),
        // and timestamp lists (stamps query, when header). Its response reads string/int/timestamp
        // list headers.
        _context = TestModels.Context("Codegen/codegen-model.json");
        _doLists = _context.Operations.Single(o => o.Name == "DoLists");
    }

    private string RequestMarshaller => new JsonRequestMarshallerWriter(_context, ModelFileName)
        .Write(_doLists, TestContext.Current.CancellationToken);

    private string ResponseUnmarshaller => new JsonResponseUnmarshallerWriter(_context, ModelFileName)
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
    public void RequestMarshaller_QueryValueTypeList_ConvertsEachElement()
    {
        // A value-type query list converts per element into the ParameterCollection via ConvertAll,
        // matching C2J. A timestamp query list defaults to ISO8601 (WithOptionalMs).
        var marshaller = RequestMarshaller;
        Assert.Contains("""request.ParameterCollection.Add("counts", publicRequest.Counts.ConvertAll<string>(item => StringUtils.FromInt(item)));""", marshaller);
        Assert.Contains("""request.ParameterCollection.Add("stamps", publicRequest.Stamps.ConvertAll<string>(item => StringUtils.FromDateTimeToISO8601WithOptionalMs(item)));""", marshaller);
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
    public void RequestMarshaller_HeaderValueTypeList_JoinsViaFromValueTypeList()
    {
        // A value-type header list (incl. timestamps) joins via StringUtils.FromValueTypeList; its List<T>
        // overload lowercases bool and forces DateTime to RFC822, so no per-element/format branch is emitted.
        var marshaller = RequestMarshaller;
        Assert.Contains("""request.Headers["x-amounts"] = StringUtils.FromValueTypeList(publicRequest.Amounts);""", marshaller);
        Assert.Contains("""request.Headers["x-when"] = StringUtils.FromValueTypeList(publicRequest.When);""", marshaller);
    }

    [Fact]
    public void ResponseUnmarshaller_HeaderLists_ParseViaMultiValueHeaderParser()
    {
        // A list<T> response header is parsed by MultiValueHeaderParser: strings via ToStringList, value
        // types via the generic ToValueTypeList<T>, timestamps via ToDateTimeList with the C2J format
        // name (header default RFC822). Matches C2J.
        var unmarshaller = ResponseUnmarshaller;
        Assert.Contains("""if (context.ResponseData.IsHeaderPresent("x-strs"))""", unmarshaller);
        Assert.Contains("""unmarshalledObject.StringHeader = MultiValueHeaderParser.ToStringList(context.ResponseData.GetHeaderValue("x-strs"));""", unmarshaller);
        Assert.Contains("""unmarshalledObject.IntHeader = MultiValueHeaderParser.ToValueTypeList<int>(context.ResponseData.GetHeaderValue("x-ints"));""", unmarshaller);
        Assert.Contains("""unmarshalledObject.TimestampHeader = MultiValueHeaderParser.ToDateTimeList(context.ResponseData.GetHeaderValue("x-stamps"), "RFC822");""", unmarshaller);
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

    [Theory]
    [InlineData("smithy.api#httpQuery", "q", "Unsupported query list element type 'List<string>'")]
    [InlineData("smithy.api#httpHeader", "x-nested", "Unsupported header list element type 'List<string>'")]
    public void RequestMarshaller_NonScalarListElement_FailsLoud(string binding, string name, string expectedMessage)
    {
        // A nested-list element has no query/header wire form (C2J throws NotImplementedException here).
        var ex = Assert.Throws<GeneratorException>(() => MarshalNestedListMember(binding, name));
        Assert.Contains(expectedMessage, ex.Message);
    }

    // Marshals an "Op" whose single input member targets a list<list<string>> bound to the given HTTP
    // trait — the non-scalar element the query/header list writers reject.
    private static string MarshalNestedListMember(string binding, string name)
    {
        var json = $$"""
        {
          "smithy": "2.0",
          "shapes": {
            "com.example#Example": {
              "type": "service",
              "version": "2023-01-01",
              "operations": [{ "target": "com.example#Op" }],
              "traits": {
                "aws.api#service": { "sdkId": "Example", "endpointPrefix": "example" },
                "aws.protocols#restJson1": {}
              }
            },
            "com.example#Op": {
              "type": "operation",
              "input": { "target": "com.example#OpRequest" },
              "output": { "target": "smithy.api#Unit" },
              "traits": { "smithy.api#http": { "uri": "/op", "method": "POST" } }
            },
            "com.example#OpRequest": {
              "type": "structure",
              "members": { "nested": { "target": "com.example#NestedList", "traits": { "{{binding}}": "{{name}}" } } }
            },
            "com.example#NestedList": { "type": "list", "member": { "target": "com.example#StringList" } },
            "com.example#StringList": { "type": "list", "member": { "target": "smithy.api#String" } }
          }
        }
        """;
        var model = JsonSerializer.Deserialize<SmithyModel>(json, TestModels.Options)
            ?? throw new InvalidOperationException("Model deserialized to null.");
        var context = TestModels.Context(model);
        var operation = context.Operations.Single(o => o.Name == "Op");
        return new JsonRequestMarshallerWriter(context, ModelFileName).Write(operation, TestContext.Current.CancellationToken);
    }

    [Theory]
    [InlineData("date-time")]
    [InlineData("epoch-seconds")]
    public void RequestMarshaller_HeaderTimestampList_NonHttpDateFormat_FailsLoud(string timestampFormat)
    {
        // StringUtils.FromValueTypeList always emits RFC822, so an explicit non-http-date format on a
        // header timestamp list would be silently sent as RFC822 - fail loud instead.
        var ex = Assert.Throws<GeneratorException>(() => MarshalHeaderTimestampList(timestampFormat));
        Assert.Contains($"@httpHeader list of timestamps with @timestampFormat '{timestampFormat}' is not supported", ex.Message);
    }

    [Fact]
    public void RequestMarshaller_HeaderTimestampList_HttpDateFormat_JoinsViaFromValueTypeList()
    {
        // An explicit http-date matches what FromValueTypeList emits (RFC822), so it is allowed.
        Assert.Contains("""request.Headers["x-when"] = StringUtils.FromValueTypeList(publicRequest.When);""", MarshalHeaderTimestampList("http-date"));
    }

    // Marshals an "Op" with a list<timestamp> @httpHeader member whose element carries the given
    // @timestampFormat (on the list's member reference).
    private static string MarshalHeaderTimestampList(string timestampFormat)
    {
        var json = $$"""
        {
          "smithy": "2.0",
          "shapes": {
            "com.example#Example": {
              "type": "service",
              "version": "2023-01-01",
              "operations": [{ "target": "com.example#Op" }],
              "traits": {
                "aws.api#service": { "sdkId": "Example", "endpointPrefix": "example" },
                "aws.protocols#restJson1": {}
              }
            },
            "com.example#Op": {
              "type": "operation",
              "input": { "target": "com.example#OpRequest" },
              "output": { "target": "smithy.api#Unit" },
              "traits": { "smithy.api#http": { "uri": "/op", "method": "POST" } }
            },
            "com.example#OpRequest": {
              "type": "structure",
              "members": { "when": { "target": "com.example#TimestampList", "traits": { "smithy.api#httpHeader": "x-when" } } }
            },
            "com.example#TimestampList": {
              "type": "list",
              "member": { "target": "smithy.api#Timestamp", "traits": { "smithy.api#timestampFormat": "{{timestampFormat}}" } }
            }
          }
        }
        """;
        var model = JsonSerializer.Deserialize<SmithyModel>(json, TestModels.Options)
            ?? throw new InvalidOperationException("Model deserialized to null.");
        var context = TestModels.Context(model);
        var operation = context.Operations.Single(o => o.Name == "Op");
        return new JsonRequestMarshallerWriter(context, ModelFileName).Write(operation, TestContext.Current.CancellationToken);
    }

    [Theory]
    [InlineData("smithy.api#Float")]
    [InlineData("smithy.api#Double")]
    public void RequestMarshaller_HeaderFloatOrDoubleList_JoinsViaFromValueTypeList(string elementTarget)
    {
        // Float/double header lists join like any other value-type list via StringUtils.FromValueTypeList.
        Assert.Contains("""request.Headers["x-values"] = StringUtils.FromValueTypeList(publicRequest.Values);""", MarshalHeaderScalarList(elementTarget));
    }

    [Theory]
    [InlineData("smithy.api#Float")]
    [InlineData("smithy.api#Double")]
    [InlineData("smithy.api#Integer")]
    public void RequestMarshaller_HeaderSparseList_FailsLoud(string elementTarget)
    {
        // A @sparse header list has nullable value-type elements, which FromValueTypeList can't join - fail loud.
        var ex = Assert.Throws<GeneratorException>(() => MarshalHeaderScalarList(elementTarget, sparse: true));
        Assert.Contains("Unsupported header list element type", ex.Message);
    }

    // Marshals an "Op" with a list @httpHeader member whose scalar element targets the given shape.
    private static string MarshalHeaderScalarList(string elementTarget, bool sparse = false)
    {
        var json = $$"""
        {
          "smithy": "2.0",
          "shapes": {
            "com.example#Example": {
              "type": "service",
              "version": "2023-01-01",
              "operations": [{ "target": "com.example#Op" }],
              "traits": {
                "aws.api#service": { "sdkId": "Example", "endpointPrefix": "example" },
                "aws.protocols#restJson1": {}
              }
            },
            "com.example#Op": {
              "type": "operation",
              "input": { "target": "com.example#OpRequest" },
              "output": { "target": "smithy.api#Unit" },
              "traits": { "smithy.api#http": { "uri": "/op", "method": "POST" } }
            },
            "com.example#OpRequest": {
              "type": "structure",
              "members": { "values": { "target": "com.example#ScalarList", "traits": { "smithy.api#httpHeader": "x-values" } } }
            },
            "com.example#ScalarList": { "type": "list", "member": { "target": "{{elementTarget}}" }{{(sparse ? """, "traits": { "smithy.api#sparse": {} }""" : "")}} }
          }
        }
        """;
        var model = JsonSerializer.Deserialize<SmithyModel>(json, TestModels.Options)
            ?? throw new InvalidOperationException("Model deserialized to null.");
        var context = TestModels.Context(model);
        var operation = context.Operations.Single(o => o.Name == "Op");
        return new JsonRequestMarshallerWriter(context, ModelFileName).Write(operation, TestContext.Current.CancellationToken);
    }
}
