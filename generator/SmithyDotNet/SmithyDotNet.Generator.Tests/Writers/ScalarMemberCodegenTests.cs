using System.Text.Json;
using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Model.Shapes;
using SmithyDotNet.Generator.Writers;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers;

/// <summary>
/// Drives the JSON marshaller/unmarshaller writers against an inline model whose members cover the
/// supported scalars (bool/int/long/float/double/timestamp) in body, query, header, and label
/// positions. Complements <see cref="TypeMapperTests"/> (type mapping) by asserting the generated
/// marshalling code for each scalar.
/// </summary>
public class ScalarMemberCodegenTests
{
    private const string ModelFileName = "scalars.json";
    private const string Namespace = "com.example";

    // One operation:
    //  - input Scalars: a body member per scalar type, plus httpQuery(count), httpHeader(ratio),
    //    httpLabel(id) scalars.
    //  - output Scalars carried on the response and on a nested structure (Nested) so both the
    //    response unmarshaller and the structure unmarshaller see scalar members.
    private const string ModelJson = """
    {
      "smithy": "2.0",
      "shapes": {
        "com.example#Example": {
          "type": "service",
          "version": "2023-01-01",
          "operations": [{ "target": "com.example#DoThing" }],
          "traits": {
            "aws.api#service": { "sdkId": "Example", "endpointPrefix": "example" },
            "aws.protocols#restJson1": {}
          }
        },
        "com.example#DoThing": {
          "type": "operation",
          "input": { "target": "com.example#DoThingRequest" },
          "output": { "target": "com.example#DoThingResponse" },
          "traits": { "smithy.api#http": { "uri": "/things/{id}/{seq}/{when}", "method": "POST" } }
        },
        "com.example#DoThingRequest": {
          "type": "structure",
          "members": {
            "id":         { "target": "smithy.api#String", "traits": { "smithy.api#httpLabel": {}, "smithy.api#required": {} } },
            "seq":        { "target": "smithy.api#Integer", "traits": { "smithy.api#httpLabel": {}, "smithy.api#required": {} } },
            "when":       { "target": "smithy.api#Timestamp", "traits": { "smithy.api#httpLabel": {}, "smithy.api#required": {} } },
            "count":      { "target": "smithy.api#Integer", "traits": { "smithy.api#httpQuery": "count" } },
            "token":      { "target": "smithy.api#Integer", "traits": { "smithy.api#httpQuery": "token", "smithy.api#required": {} } },
            "since":      { "target": "smithy.api#Timestamp", "traits": { "smithy.api#httpQuery": "since", "smithy.api#timestampFormat": "epoch-seconds" } },
            "ratio":      { "target": "smithy.api#Double", "traits": { "smithy.api#httpHeader": "x-ratio" } },
            "stamp":      { "target": "smithy.api#Timestamp", "traits": { "smithy.api#httpHeader": "x-stamp" } },
            "until":      { "target": "smithy.api#Timestamp", "traits": { "smithy.api#httpHeader": "x-until", "smithy.api#timestampFormat": "date-time" } },
            "flag":       { "target": "smithy.api#Boolean" },
            "size":       { "target": "smithy.api#Long" },
            "fraction":   { "target": "smithy.api#Float" },
            "amount":     { "target": "smithy.api#Double" },
            "created":    { "target": "smithy.api#Timestamp" },
            "expiry":     { "target": "smithy.api#Timestamp", "traits": { "smithy.api#timestampFormat": "date-time" } },
            "sealedAt":   { "target": "com.example#HttpDateTimestamp" },
            "details":    { "target": "com.example#DetailList" }
          }
        },
        "com.example#HttpDateTimestamp": {
          "type": "timestamp",
          "traits": { "smithy.api#timestampFormat": "http-date" }
        },
        "com.example#DetailList": {
          "type": "list",
          "member": { "target": "com.example#Detail" }
        },
        "com.example#Detail": {
          "type": "structure",
          "members": {
            "level":    { "target": "smithy.api#Integer" },
            "at":       { "target": "smithy.api#Timestamp" }
          }
        },
        "com.example#DoThingResponse": {
          "type": "structure",
          "members": {
            "enabled":  { "target": "smithy.api#Boolean" },
            "total":    { "target": "smithy.api#Long" },
            "updated":  { "target": "smithy.api#Timestamp" },
            "nested":   { "target": "com.example#Nested" }
          }
        },
        "com.example#Nested": {
          "type": "structure",
          "members": {
            "seq":      { "target": "smithy.api#Integer" },
            "when":     { "target": "smithy.api#Timestamp" }
          }
        }
      }
    }
    """;

    private readonly GenerationContext _context;
    private readonly string _requestMarshaller;
    private readonly string _responseUnmarshaller;
    private readonly string _structureUnmarshaller;
    private readonly string _structureMarshaller;
    private readonly string _requestStructure;

    public ScalarMemberCodegenTests()
    {
        var model = JsonSerializer.Deserialize<SmithyModel>(ModelJson, CloudTrailModelFixture.Options)
            ?? throw new InvalidOperationException("Model deserialized to null.");
        _context = new GenerationContext(new ServiceIndex(model), new SdkVersionManifest
        {
            ServiceVersions = new Dictionary<string, ServiceVersion> { ["Example"] = new() { Version = "4.0.0.0" } },
        });

        var operation = _context.Operations.Single(o => o.Name == "DoThing");
        _requestMarshaller = new JsonRequestMarshallerWriter(_context, ModelFileName)
            .Write(operation, TestContext.Current.CancellationToken);
        _responseUnmarshaller = new JsonResponseUnmarshallerWriter(_context, ModelFileName)
            .Write(operation, TestContext.Current.CancellationToken);

        var nestedId = ShapeId.Parse($"{Namespace}#Nested");
        _structureUnmarshaller = new JsonStructureUnmarshallerWriter(_context, ModelFileName)
            .Write(_context.Structures[nestedId], nestedId, TestContext.Current.CancellationToken);

        var detailId = ShapeId.Parse($"{Namespace}#Detail");
        _structureMarshaller = new JsonStructureMarshallerWriter(_context, ModelFileName)
            .Write(_context.Structures[detailId], detailId, TestContext.Current.CancellationToken);

        var requestId = ShapeId.Parse($"{Namespace}#DoThingRequest");
        _requestStructure = new StructureWriter(_context, ModelFileName)
            .Write(_context.Structures[requestId], requestId, TestContext.Current.CancellationToken);
    }

    [Fact]
    public void RequestMarshaller_BodyScalars_WriteGuardedScalarValues()
    {
        // Each body scalar is guarded by IsSet, then written with the matching Utf8JsonWriter call:
        // bool -> WriteBooleanValue, int/long -> WriteNumberValue, timestamp -> epoch seconds.
        Assert.Contains("if (publicRequest.IsSetFlag())", _requestMarshaller);
        Assert.Contains("""context.Writer.WritePropertyName("created");""", _requestMarshaller);
        Assert.Contains("context.Writer.WriteBooleanValue(publicRequest.Flag.Value);", _requestMarshaller);
        Assert.Contains("context.Writer.WriteNumberValue(publicRequest.Size.Value);", _requestMarshaller);
        Assert.Contains("context.Writer.WriteNumberValue(System.Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(publicRequest.Created.Value)));", _requestMarshaller);

        // float/double branch through IsSpecial*Value: WriteNumberValue rejects NaN/±Infinity, which
        // JSON protocols send as strings.
        Assert.Contains("if (StringUtils.IsSpecialFloatValue(publicRequest.Fraction.Value))", _requestMarshaller);
        Assert.Contains("context.Writer.WriteStringValue(StringUtils.FromSpecialFloatValue(publicRequest.Fraction.Value));", _requestMarshaller);
        Assert.Contains("context.Writer.WriteNumberValue(publicRequest.Amount.Value);", _requestMarshaller);
    }

    [Fact]
    public void RequestMarshaller_TimestampFormat_ResolvesPerBindingAndOverride()
    {
        // Body defaults to epoch seconds; member and target @timestampFormat override it.
        Assert.Contains("context.Writer.WriteNumberValue(System.Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(publicRequest.Created.Value)));", _requestMarshaller);
        Assert.Contains("context.Writer.WriteStringValue(StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.Expiry));", _requestMarshaller);   // member @date-time
        Assert.Contains("context.Writer.WriteStringValue(StringUtils.FromDateTimeToRFC822(publicRequest.SealedAt));", _requestMarshaller);              // target @http-date

        // Header defaults to http-date, query/label to date-time; explicit formats override each.
        Assert.Contains("""request.Headers["x-stamp"] = StringUtils.FromDateTimeToRFC822(publicRequest.Stamp);""", _requestMarshaller);
        Assert.Contains("""request.Headers["x-until"] = StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.Until);""", _requestMarshaller);    // header @date-time
        Assert.Contains("""request.AddPathResource("{when}", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.When));""", _requestMarshaller);
        Assert.Contains("""request.Parameters.Add("since", StringUtils.FromDateTimeToUnixTimestamp(publicRequest.Since));""", _requestMarshaller);        // query @epoch-seconds
    }

    [Fact]
    public void RequestMarshaller_HttpBindingScalars_ConvertThroughStringUtils()
    {
        Assert.Contains("""request.Parameters.Add("count", StringUtils.FromInt(publicRequest.Count.Value));""", _requestMarshaller);
        Assert.Contains("""request.Headers["x-ratio"] = StringUtils.FromDouble(publicRequest.Ratio.Value);""", _requestMarshaller);
        Assert.Contains("""request.AddPathResource("{id}", StringUtils.FromString(publicRequest.Id));""", _requestMarshaller);
        Assert.Contains("""request.AddPathResource("{seq}", StringUtils.FromInt(publicRequest.Seq.Value));""", _requestMarshaller);

        // A required non-string query member is null-checked; IsSet alone would silently omit it.
        Assert.Contains("if (publicRequest.Token == null)", _requestMarshaller);
        Assert.Contains("""throw new AmazonExampleException("Request object does not have required field Token set");""", _requestMarshaller);
    }

    [Fact]
    public void ResponseUnmarshaller_Scalars_UseRuntimeUnmarshallers()
    {
        Assert.Contains("var unmarshaller = NullableBoolUnmarshaller.Instance;", _responseUnmarshaller);
        Assert.Contains("response.Enabled = unmarshaller.Unmarshall(context, ref reader);", _responseUnmarshaller);
        Assert.Contains("var unmarshaller = NullableLongUnmarshaller.Instance;", _responseUnmarshaller);
        Assert.Contains("var unmarshaller = NullableDateTimeUnmarshaller.Instance;", _responseUnmarshaller);
        Assert.Contains("""if (context.TestExpression("updated", targetDepth, ref reader))""", _responseUnmarshaller);
    }

    [Fact]
    public void StructureUnmarshaller_Scalars_UseRuntimeUnmarshallers()
    {
        Assert.Contains("public partial class NestedUnmarshaller", _structureUnmarshaller);
        Assert.Contains("var unmarshaller = NullableIntUnmarshaller.Instance;", _structureUnmarshaller);
        Assert.Contains("unmarshalledObject.Seq = unmarshaller.Unmarshall(context, ref reader);", _structureUnmarshaller);
        Assert.Contains("var unmarshaller = NullableDateTimeUnmarshaller.Instance;", _structureUnmarshaller);
        Assert.Contains("""if (context.TestExpression("when", targetDepth, ref reader))""", _structureUnmarshaller);
    }

    [Fact]
    public void Structure_ScalarIsSet_UsesHasValue_StringIsSet_UsesNullCheck()
    {
        // Nullable value types check .HasValue; the string label member keeps the != null form.
        Assert.Contains("internal bool IsSetFlag() => this.Flag.HasValue;", _requestStructure);
        Assert.Contains("internal bool IsSetCreated() => this.Created.HasValue;", _requestStructure);
        Assert.Contains("internal bool IsSetId() => this.Id != null;", _requestStructure);
    }

    [Fact]
    public void StructureMarshaller_Scalars_UseCorrectWriterCalls()
    {
        Assert.Contains("public partial class DetailMarshaller", _structureMarshaller);
        Assert.Contains("if (requestObject.IsSetLevel())", _structureMarshaller);
        Assert.Contains("""context.Writer.WritePropertyName("level");""", _structureMarshaller);
        Assert.Contains("context.Writer.WriteNumberValue(requestObject.Level.Value);", _structureMarshaller);
        Assert.Contains("context.Writer.WriteNumberValue(System.Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(requestObject.At.Value)));", _structureMarshaller);
    }

    [Fact]
    public void ScalarList_Throws()
    {
        var json = """{ "type": "list", "member": { "target": "smithy.api#Integer" } }""";
        var list = JsonSerializer.Deserialize<Shape>(json, CloudTrailModelFixture.Options) ?? throw new InvalidOperationException("Shape deserialized to null.");
        var id = ShapeId.Parse($"{Namespace}#TestList");

        Assert.Throws<GeneratorException>(() => TypeMapper.MapType(id, list, _context));
    }
}
